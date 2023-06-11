namespace AutoPujcovna_Probošt
{
    partial class FormRentalList
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxNominalPricePerDay = new TextBox();
            textBoxYear = new TextBox();
            textBoxModel = new TextBox();
            textBoxBrand = new TextBox();
            dataGridViewRentals = new DataGridView();
            menuStrip1 = new MenuStrip();
            rentalToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            souborToolStripMenuItem = new ToolStripMenuItem();
            exportCSVToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialogCSV = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentals).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewRentals, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(984, 437);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(textBoxNominalPricePerDay, 3, 0);
            tableLayoutPanel2.Controls.Add(textBoxYear, 2, 0);
            tableLayoutPanel2.Controls.Add(textBoxModel, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxBrand, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(978, 44);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxNominalPricePerDay
            // 
            textBoxNominalPricePerDay.Dock = DockStyle.Fill;
            textBoxNominalPricePerDay.Location = new Point(735, 3);
            textBoxNominalPricePerDay.Name = "textBoxNominalPricePerDay";
            textBoxNominalPricePerDay.ReadOnly = true;
            textBoxNominalPricePerDay.Size = new Size(240, 23);
            textBoxNominalPricePerDay.TabIndex = 3;
            // 
            // textBoxYear
            // 
            textBoxYear.Dock = DockStyle.Fill;
            textBoxYear.Location = new Point(491, 3);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.ReadOnly = true;
            textBoxYear.Size = new Size(238, 23);
            textBoxYear.TabIndex = 2;
            // 
            // textBoxModel
            // 
            textBoxModel.Dock = DockStyle.Fill;
            textBoxModel.Location = new Point(247, 3);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.ReadOnly = true;
            textBoxModel.Size = new Size(238, 23);
            textBoxModel.TabIndex = 1;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Dock = DockStyle.Fill;
            textBoxBrand.Location = new Point(3, 3);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.ReadOnly = true;
            textBoxBrand.Size = new Size(238, 23);
            textBoxBrand.TabIndex = 0;
            // 
            // dataGridViewRentals
            // 
            dataGridViewRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRentals.Dock = DockStyle.Fill;
            dataGridViewRentals.Location = new Point(3, 53);
            dataGridViewRentals.Name = "dataGridViewRentals";
            dataGridViewRentals.RowTemplate.Height = 25;
            dataGridViewRentals.Size = new Size(978, 381);
            dataGridViewRentals.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { rentalToolStripMenuItem, souborToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // rentalToolStripMenuItem
            // 
            rentalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            rentalToolStripMenuItem.Name = "rentalToolStripMenuItem";
            rentalToolStripMenuItem.Size = new Size(52, 20);
            rentalToolStripMenuItem.Text = "Rental";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(112, 22);
            addToolStripMenuItem.Text = "Přidat";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(112, 22);
            editToolStripMenuItem.Text = "Upravit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(112, 22);
            deleteToolStripMenuItem.Text = "Smazat";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // souborToolStripMenuItem
            // 
            souborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCSVToolStripMenuItem });
            souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            souborToolStripMenuItem.Size = new Size(57, 20);
            souborToolStripMenuItem.Text = "Soubor";
            // 
            // exportCSVToolStripMenuItem
            // 
            exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            exportCSVToolStripMenuItem.Size = new Size(180, 22);
            exportCSVToolStripMenuItem.Text = "Export CSV";
            exportCSVToolStripMenuItem.Click += exportCSVToolStripMenuItem_Click;
            // 
            // saveFileDialogCSV
            // 
            saveFileDialogCSV.DefaultExt = "csv";
            saveFileDialogCSV.FileName = "rental-export";
            saveFileDialogCSV.Filter = "Comma-separated list (.csv)|*.csv";
            saveFileDialogCSV.Title = "Uložit CSV";
            // 
            // FormRentalList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormRentalList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormRentalList";
            Load += FormRentalList_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentals).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxBrand;
        private DataGridView dataGridViewRentals;
        private TextBox textBoxNominalPricePerDay;
        private TextBox textBoxYear;
        private TextBox textBoxModel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem rentalToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem souborToolStripMenuItem;
        private ToolStripMenuItem exportCSVToolStripMenuItem;
        private SaveFileDialog saveFileDialogCSV;
    }
}