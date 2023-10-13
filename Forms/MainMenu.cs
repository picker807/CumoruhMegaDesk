
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
    public partial class MainMenu : Form
    {
        private AddQuote addQuoteView;
        private ViewAllQuotes viewAllQuotesView;        


        public MainMenu()
        {
            InitializeComponent();
            this.ControlBox = false;
        }


        // Navigate to the AddQuote view
        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            if(addQuoteView == null)
            {
                addQuoteView = new AddQuote(this);
            }
            
            this.Hide();
            addQuoteView.Show();

        }


        // Navigate to the ViewAllQuotes view
        private void displayQuoteButton_Click(object sender, EventArgs e)
        {
            if (viewAllQuotesView == null)
            {
                viewAllQuotesView = new ViewAllQuotes(this);
            }
            
            this.Hide();
            viewAllQuotesView.Show();
 
        }


        // Close the app
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
