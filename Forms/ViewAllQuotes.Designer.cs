namespace MegaDesk_Picker
{
    partial class ViewAllQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backButton = new System.Windows.Forms.Button();
            this.allQuotesGrid = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesktopMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushOrderDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allQuotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(18, 15);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(116, 27);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Main Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // allQuotesGrid
            // 
            this.allQuotesGrid.AllowDrop = true;
            this.allQuotesGrid.AllowUserToDeleteRows = false;
            this.allQuotesGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allQuotesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.allQuotesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allQuotesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.allQuotesGrid.CausesValidation = false;
            this.allQuotesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allQuotesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.allQuotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allQuotesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.Date,
            this.TotalPrice,
            this.Width,
            this.Depth,
            this.NumberOfDrawers,
            this.DesktopMaterial,
            this.RushOrderDays});
            this.allQuotesGrid.Location = new System.Drawing.Point(11, 59);
            this.allQuotesGrid.Margin = new System.Windows.Forms.Padding(2);
            this.allQuotesGrid.Name = "allQuotesGrid";
            this.allQuotesGrid.ReadOnly = true;
            this.allQuotesGrid.RowHeadersWidth = 82;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.BurlyWood;
            this.allQuotesGrid.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.allQuotesGrid.RowTemplate.Height = 33;
            this.allQuotesGrid.RowTemplate.ReadOnly = true;
            this.allQuotesGrid.Size = new System.Drawing.Size(941, 391);
            this.allQuotesGrid.TabIndex = 1;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.MinimumWidth = 10;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 200;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 10;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.MinimumWidth = 10;
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            // 
            // Depth
            // 
            this.Depth.HeaderText = "Depth";
            this.Depth.MinimumWidth = 10;
            this.Depth.Name = "Depth";
            this.Depth.ReadOnly = true;
            // 
            // NumberOfDrawers
            // 
            this.NumberOfDrawers.HeaderText = "Drawers";
            this.NumberOfDrawers.MinimumWidth = 10;
            this.NumberOfDrawers.Name = "NumberOfDrawers";
            this.NumberOfDrawers.ReadOnly = true;
            // 
            // DesktopMaterial
            // 
            this.DesktopMaterial.HeaderText = "Material";
            this.DesktopMaterial.MinimumWidth = 10;
            this.DesktopMaterial.Name = "DesktopMaterial";
            this.DesktopMaterial.ReadOnly = true;
            // 
            // RushOrderDays
            // 
            this.RushOrderDays.HeaderText = "Rush Order";
            this.RushOrderDays.MinimumWidth = 10;
            this.RushOrderDays.Name = "RushOrderDays";
            this.RushOrderDays.ReadOnly = true;
            // 
            // materialComboBox
            // 
            this.materialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(537, 18);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(121, 24);
            this.materialComboBox.TabIndex = 2;
            this.materialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialBox_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter Quotes By Material:";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(963, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.allQuotesGrid);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Quotes";
            this.VisibleChanged += new System.EventHandler(this.On_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.allQuotesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView allQuotesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesktopMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushOrderDays;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label label1;
    }
}