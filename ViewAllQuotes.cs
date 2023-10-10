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
        private BindingSource bindingSource = new BindingSource();
        private FileHandler fileHandler = new FileHandler();
        public ViewAllQuotes(MainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            LoadAllQuotes();
        }

        private void LoadAllQuotes()
        {
            try
            {
                List<DeskQuote> quotes = fileHandler.LoadQuotes();
              
                allQuotesGrid.AutoGenerateColumns = false;
                allQuotesGrid.RowHeadersVisible = false;
                allQuotesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                allQuotesGrid.RowsDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
                allQuotesGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);
                allQuotesGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                allQuotesGrid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                foreach (var quote in quotes)
                {
                    // Convert integer properties to strings
                    string widthStr = quote.Desk.Width.ToString();
                    string depthStr = quote.Desk.Depth.ToString();
                    string numberOfDrawersStr = quote.Desk.NumberOfDrawers.ToString();
                    string desktopMaterialStr = quote.Desk.DesktopMaterial.ToString();
                    string rushOrderDaysStr = quote.Desk.RushOrderDays.ToString() + " days";
                    if (quote.Desk.RushOrderDays == 14)
                    {
                        rushOrderDaysStr += " (no rush)";
                    }
                    

                    // Add string values to DataGridView
                    allQuotesGrid.Rows.Add(
                        quote.CustomerName,
                        quote.Date.ToShortDateString(),
                        quote.TotalPrice.ToString("C"),
                        $"{widthStr} in",
                        $"{depthStr} in",
                        numberOfDrawersStr,
                        desktopMaterialStr,
                        rushOrderDaysStr
                    );
                }
                // Resize columns to accomodate cell contents (min width) and fill the form.
                allQuotesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                allQuotesGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}
