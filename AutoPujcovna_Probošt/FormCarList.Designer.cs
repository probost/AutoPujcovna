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
            pronájmyToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDataSourceBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCar
            // 
            dataGridViewCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCar.Dock = DockStyle.Fill;
            dataGridViewCar.Location = new Point(0, 24);
            dataGridViewCar.Name = "dataGridViewCar";
            dataGridViewCar.RowTemplate.Height = 25;
            dataGridViewCar.Size = new Size(800, 426);
            dataGridViewCar.TabIndex = 0;
            // 
            // carDataSourceBindingSource
            // 
            carDataSourceBindingSource.DataSource = typeof(Datasources.CarDataSource);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { autoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // autoToolStripMenuItem
            // 
            autoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, pronájmyToolStripMenuItem });
            autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            autoToolStripMenuItem.Size = new Size(45, 20);
            autoToolStripMenuItem.Text = "Auto";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(180, 22);
            addToolStripMenuItem.Text = "Přidat";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Upravit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Smazat";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // pronájmyToolStripMenuItem
            // 
            pronájmyToolStripMenuItem.Name = "pronájmyToolStripMenuItem";
            pronájmyToolStripMenuItem.Size = new Size(180, 22);
            pronájmyToolStripMenuItem.Text = "Pronájmy";
            pronájmyToolStripMenuItem.Click += rentalsToolStripMenuItem_Click;
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
        private ToolStripMenuItem pronájmyToolStripMenuItem;
    }
}