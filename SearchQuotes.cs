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
    public partial class SearchQuotes : Form
    {
        private MainMenu menu;  
        public SearchQuotes(MainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();    
        }
    }
}
