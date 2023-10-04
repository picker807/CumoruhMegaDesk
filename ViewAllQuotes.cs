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
    public partial class ViewAllQuotes : Form
    {
        private MainMenu menu;
        public ViewAllQuotes(MainMenu menu)
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
