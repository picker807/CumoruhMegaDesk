using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Picker
{
    public class DeskQuote
    {
        [JsonProperty]
        internal Desk Desk;
        [JsonProperty]
        internal string CustomerName;
        [JsonProperty]
        internal DateTime Date { get; set; }
        private double BaseDeskPrice { get; set; }
        private double AdditionalSqInchCost { get; set; }
        private double DrawerCost { get; set; }
        private double SurfaceMaterialCost { get; set; }
        private double RushOrderCost {  get; set; }
        [JsonProperty]
        internal double TotalPrice { get; set; }
        private double[,] rushOrderPrices;

        public DeskQuote(string customerName, int width, int depth, int numberOfDrawers, DesktopMaterial desktopMaterial, int rushOrderDays)
        {
            Date = DateTime.Today;
            this.CustomerName = customerName;

            Desk = new Desk(width,
                            depth,
                            numberOfDrawers,
                            desktopMaterial,
                            rushOrderDays);

            BaseDeskPrice = 200;
           

            

        }

        // Get all the costs and add them up
        public void CreateNewQuote()
        {
            AdditionalSqInchCost = CalcAdditionalSqInchCost();
            DrawerCost = CalcDrawerCost();
            SurfaceMaterialCost = CalcSurfaceMaterialCost();
            RushOrderCost = CalcRushOrderCost();
            TotalPrice = CalcTotalPrice();


           /* Console.WriteLine($"AdditionalSqInchCost = {AdditionalSqInchCost}, DrawerCost = {DrawerCost}, " +
                $"SurfaceMaterialCost = {SurfaceMaterialCost}, RushOrderCost = {RushOrderCost}," +
                $" TotalCost = {TotalPrice}"); */
        }

        // Calculate the cost of adding more desk area
        private double CalcAdditionalSqInchCost ()
        {
            double pricePerInch = 1;
            double squareInches = Desk.Width * Desk.Depth;
            double sqInchCost = squareInches * pricePerInch;
            return sqInchCost;
        }  

        // Calculate the added cost of drawers
        private double CalcDrawerCost()
        {
            double costPerDrawer = 50;
            
            return costPerDrawer * Desk.NumberOfDrawers;
        }

        // Get the cost of the desktop material already contained in the DesktopMaterials enum values
        private double CalcSurfaceMaterialCost()
        {
            return (double)Desk.DesktopMaterial;
        }

        private double CalcRushOrderCost()
        {
            double sqInch = Desk.Width * Desk.Depth;
            int rush = Desk.RushOrderDays;

            // If rush days are 14, then there is no rush or added cost.
            if (rush == 14)
            {
                return 0;
            }

            // Call GetRushOrder to populate rushOrderPrices array
            GetRushOrder();

            // Headers help to easily find the coordinates of the priceChart
            int[] rushOrderHeader = { 3, 5, 7 };
            int[] deskSizeHeader = { 1000, 2000, 4610 }; //4608 is the max area given the maximum values of width and depth.

            // Find the index corresponding to sqInch is less than the value.
            int indexSize = Array.FindIndex(deskSizeHeader, header => sqInch < header);
            // Find the index that matches the value of rush days
            int indexRush = Array.IndexOf(rushOrderHeader, rush);

            // Check if rushOrderPrices is null, indicating an error in reading the file
            if (rushOrderPrices == null)
            {
                // Handle the error, for example, by returning a default value or showing an error message.
                Console.WriteLine("Error: Unable to retrieve rush order prices.");
                return 0; // Default value, or handle the error as needed.
            }

            // Calculate the rush order cost using rushOrderPrices array
            double rushOrderCost = rushOrderPrices[indexSize, indexRush];

            return rushOrderCost;
        }

        // New method to handle rush order prices
        public void GetRushOrder()
        {
            try
            {
                string filePath = "Resources/rushOrderPrices.txt";
                string[] lines = File.ReadAllLines(filePath);

                // Initialize the existing class-level 2D array with three rows and three columns
                rushOrderPrices = new double[3, 3];

                int row = 0;
                int col = 0;

                foreach (string line in lines)
                {
                    // Parse the price from each line and add it to the array
                    if (row < 3 && col < 3)
                    {
                        if (double.TryParse(line, out double price))
                        {
                            rushOrderPrices[row, col] = price;
                            col++;
                        }
                    }

                    if (col >= 3)
                    {
                        col = 0;
                        row++;
                    }

                    if (row >= 3)
                    {
                        break; // We have filled the entire 3x3 array
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading rush order prices: {ex.Message}");
            }
        }


        private double CalcTotalPrice()
        {
            return BaseDeskPrice + AdditionalSqInchCost + DrawerCost + SurfaceMaterialCost + RushOrderCost;
        }
    }
}
