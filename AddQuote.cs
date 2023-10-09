using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace MegaDesk_Picker
{
    public partial class AddQuote : Form
    {
        private MainMenu menu;
        DeskQuote quote;

        public AddQuote (MainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.ControlBox = false;
            PopulateMaterialBox();
            PopulateRushBox();
            PopulateDrawerBox();
            

        }


        private void PopulateMaterialBox()
        {
            List<DesktopMaterial> Materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

            //Use the DesktopMaterial enum from Desk.cs file to populate
            foreach (DesktopMaterial material in Materials)
            {
                materialComboBox.Items.Add(material.ToString());
            }
            materialComboBox.SelectedItem = "Rosewood";
        }

        private void PopulateRushBox()
        {
            // Hard code the available rush options
            int[] rushOrderValues = { 3, 5, 7, 14 };

            foreach (int value in rushOrderValues)
            {
                rushComboBox.Items.Add(value);
            }
            rushComboBox.SelectedItem = 14;
        }

        private void PopulateDrawerBox()
        {
            // Populate with 0-7 drawers
            for (int i = 0; i<= 7;  i++)
            {
                drawersComboBox.Items.Add(i);
            }
            drawersComboBox.SelectedItem = 2;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Button returns to the Main Menu
            this.Hide();
            menu.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Get all data from the form
            string customerName = nameTextBox.Text;
            string widthText = widthTextBox.Text;
            string depthText = depthTextBox.Text;
            string drawersText = drawersComboBox.SelectedItem.ToString();
            string surfaceMaterialText = materialComboBox.SelectedItem.ToString();  
            string rushOrderText = rushComboBox.SelectedItem.ToString();

            // Validate width and height. Convert data types.
            int width =  ValidateWidth(widthText);
            int depth = ValidateDepth(depthText);
            int drawers = int.Parse(drawersText);
            Enum.TryParse(surfaceMaterialText, out DesktopMaterial material);
           int rushOrder = int.Parse(rushOrderText);

            // If width and height are valid, create a DeskQuote object and display the quote.
           if (width != -1 && depth != -1)
            {
                quote = new DeskQuote(customerName, width, depth, drawers, material, rushOrder);
                quote.CreateNewQuote();
                DisplayQuote display = new DisplayQuote(quote, this);
                display.Show();
                this.Hide();

            }
            
        }

        // Validate that the width is an integer and within min/ max values
            private int ValidateWidth(string widthText)
            {
                int width;
                int min = Desk.MinWidth;
                int max = Desk.MaxWidth;

                try
                {
                    if (int.TryParse(widthText, out width))
                    {
                        if (width < min || width > max)
                        {
                            widthTextBox.BackColor = Color.Red;
                            MessageBox.Show($"Width must be between {min} and {max}"); 
                            widthTextBox.Focus(); 
                            return -1; // Return an invalid value to indicate validation failure
                        }
                        else
                        {
                            // Reset any error indicators
                            widthTextBox.BackColor = System.Drawing.SystemColors.Window; 
                            return width; // Return valid width
                        }
                    }
                    else
                    {
                        widthTextBox.BackColor = Color.Red;
                        MessageBox.Show("Width must be a valid number");
                        widthTextBox.Focus();
                        return -1; // Return an invalid value to indicate validation failure
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during validation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }

        // Validate teh depth is an integer and within min/ max values
        private int ValidateDepth(string depthText)
        {
            int depth;
            int min = Desk.MinDepth;
            int max = Desk.MaxDepth;

            try
            {
                if (int.TryParse(depthText, out depth))
                {
                    if (depth < min || depth > max)
                    {
                        depthTextBox.BackColor = Color.Red;
                        MessageBox.Show($"Depth must be between {min} and {max}");
                        depthTextBox.Focus();
                        return -1; // Return an invalid value to indicate validation failure
                    }
                    else
                    {
                        // Reset any error indicators
                        depthTextBox.BackColor = SystemColors.Window;
                        return depth; // Return valid width
                    }
                }
                else
                {
                    depthTextBox.BackColor = Color.Red;
                    MessageBox.Show("Depth must be a valid number");
                    depthTextBox.Focus();
                    return -1; // Return an invalid value to indicate validation failure
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during validation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }





    }
}
