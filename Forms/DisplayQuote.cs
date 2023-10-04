using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Picker
{
    public partial class DisplayQuote : Form
    {
        AddQuote addQuote;
        DeskQuote deskQuote;
        Desk desk;
        int rush;
        DesktopMaterial material;
        int drawers;
        int depth;
        int width;
        DateTime date;
        string name;
        double price;

        internal DisplayQuote(DeskQuote deskQuote, AddQuote addQuote)
        {
            InitializeComponent();
            this.deskQuote = deskQuote;
            this.desk = deskQuote.Desk;
            this.rush = desk.RushOrderDays;
            this.material = desk.DesktopMaterial;
            this.drawers = desk.NumberOfDrawers;
            this.depth = desk.Depth;
            this.width = desk.Width;
            this.date = deskQuote.Date;
            this.name = deskQuote.CustomerName;
            this.price = deskQuote.TotalPrice;
            this.addQuote = addQuote;
            PopulateForm();

            this.ControlBox = false;
        }

        private void PopulateForm()
        {
            NameLabel.Text = name;
            DateLabel.Text = date.ToString("yyyy-MM-dd");
            DepthLabel.Text = depth.ToString() + " in";
            WidthLabel.Text = width.ToString() + " in";
            DrawerLabel.Text = drawers.ToString();
            MaterialLabel.Text = material.ToString();
            RushLabel.Text = rush.ToString() + " days";
            if (rush == 14)
            {
                RushLabel.Text += " (no rush)";
            }
            PriceLabel.Text = price.ToString("C");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button returns to the AddQuote view where you can revise the order. 
            addQuote.Show();
            this.Close();
        }
    }
}
