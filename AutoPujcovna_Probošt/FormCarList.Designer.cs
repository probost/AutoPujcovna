namespace AutoPujcovna_Probošt
{
    partial class FormCarList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewCar = new DataGridView();
            carDataSourceBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            autoToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            rentalsToolStripMenuItem = new ToolStripMenuItem();
            souborToolStripMenuItem = new ToolStripMenuItem();
            exportCSVToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialogCSV = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDataSourceBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCar
            // 
            dataGridViewCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCar.Dock = DockStyle.Fill;
            dataGridViewCar.Location = new Point(0, 24);
            dataGridViewCar.Name = "dataGridViewCar";
            dataGridViewCar.RowTemplate.Height = 25;
            dataGridViewCar.Size = new Size(800, 426);
            dataGridViewCar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { autoToolStripMenuItem, souborToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // autoToolStripMenuItem
            // 
            autoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, rentalsToolStripMenuItem });
            autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            autoToolStripMenuItem.Size = new Size(45, 20);
            autoToolStripMenuItem.Text = "Auto";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(125, 22);
            addToolStripMenuItem.Text = "Přidat";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(125, 22);
            editToolStripMenuItem.Text = "Upravit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(125, 22);
            deleteToolStripMenuItem.Text = "Smazat";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // rentalsToolStripMenuItem
            // 
            rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            rentalsToolStripMenuItem.Size = new Size(125, 22);
            rentalsToolStripMenuItem.Text = "Pronájmy";
            rentalsToolStripMenuItem.Click += rentalsToolStripMenuItem_Click;
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
            saveFileDialogCSV.FileName = "export_cars";
            saveFileDialogCSV.Filter = "Comma-separated values (*.csv)|*.csv";
            // 
            // FormCarList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewCar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormCarList";
            Text = "Autopůjčovna - seznam aut";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDataSourceBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCar;
        private BindingSource carDataSourceBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem autoToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem rentalsToolStripMenuItem;
        private ToolStripMenuItem souborToolStripMenuItem;
        private ToolStripMenuItem exportCSVToolStripMenuItem;
        private SaveFileDialog saveFileDialogCSV;
    }
}