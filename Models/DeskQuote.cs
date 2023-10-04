using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Picker
{
    internal class DeskQuote
    {
        internal Desk Desk;
        internal string CustomerName;
        internal DateTime Date { get; set; }
        private double BaseDeskPrice { get; set; }
        private double AdditionalSqInchCost { get; set; }
        private double DrawerCost { get; set; }
        private double SurfaceMaterialCost { get; set; }
        private double RushOrderCost {  get; set; }
        internal double TotalPrice { get; set; }

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

            // Headers help to easily find the coordinates of the priceChart
            int[] rushOrderHeader = { 3, 5, 7 };
            int[] deskSizeHeader = { 1000, 2000, 4610 }; //4608 is the max area given the maximum values of width and depth.

            // Find the index corresponding to sqInch is less than the value.
            int indexSize = Array.FindIndex(deskSizeHeader, header => sqInch < header);
            // Find the index that matches the value of rush days
            int indexRush = Array.IndexOf(rushOrderHeader, rush);
            
            // Chart contains grid of prices for area vs rush days
            double[,] priceChart = new double[,]
            {
                {60, 70, 80 },
                {40, 50, 60 },
                {30, 35, 40 }
            };
            // Return the value corresponding to the indexSize and indexRush coordinates
            return priceChart[indexSize, indexRush];
        }

        private double CalcTotalPrice()
        {
            return BaseDeskPrice + AdditionalSqInchCost + DrawerCost + SurfaceMaterialCost + RushOrderCost;
        }
    }
}
