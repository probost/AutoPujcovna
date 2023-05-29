namespace AutoPujcovna_Probošt
{
    partial class FormCarAddEdit
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            numericUpDownNominalPricePerDay = new NumericUpDown();
            nominalPriceLabel = new Label();
            yearLabel = new Label();
            modelLabel = new Label();
            textBoxModel = new TextBox();
            brandLabel = new Label();
            textBoxBrand = new TextBox();
            closeButton = new Button();
            saveButton = new Button();
            numericUpDownYear = new NumericUpDown();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNominalPricePerDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(numericUpDownNominalPricePerDay, 1, 3);
            tableLayoutPanel1.Controls.Add(nominalPriceLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(yearLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(modelLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxModel, 1, 1);
            tableLayoutPanel1.Controls.Add(brandLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxBrand, 1, 0);
            tableLayoutPanel1.Controls.Add(closeButton, 2, 4);
            tableLayoutPanel1.Controls.Add(saveButton, 1, 4);
            tableLayoutPanel1.Controls.Add(numericUpDownYear, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.00062F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006256F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006313F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9981232F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(384, 261);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // numericUpDownNominalPricePerDay
            // 
            numericUpDownNominalPricePerDay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(numericUpDownNominalPricePerDay, 2);
            numericUpDownNominalPricePerDay.Location = new Point(99, 181);
            numericUpDownNominalPricePerDay.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownNominalPricePerDay.Name = "numericUpDownNominalPricePerDay";
            numericUpDownNominalPricePerDay.Size = new Size(186, 23);
            numericUpDownNominalPricePerDay.TabIndex = 11;
            numericUpDownNominalPricePerDay.Validating += numericUpDownNominalPricePerDay_Validating;
            // 
            // nominalPriceLabel
            // 
            nominalPriceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nominalPriceLabel.AutoSize = true;
            nominalPriceLabel.Location = new Point(3, 185);
            nominalPriceLabel.Name = "nominalPriceLabel";
            nominalPriceLabel.Size = new Size(90, 15);
            nominalPriceLabel.TabIndex = 6;
            nominalPriceLabel.Text = "Nominal price";
            // 
            // yearLabel
            // 
            yearLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(3, 130);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(90, 15);
            yearLabel.TabIndex = 4;
            yearLabel.Text = "Year";
            // 
            // modelLabel
            // 
            modelLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(3, 75);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(90, 15);
            modelLabel.TabIndex = 2;
            modelLabel.Text = "Model";
            // 
            // textBoxModel
            // 
            textBoxModel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBoxModel, 2);
            textBoxModel.Location = new Point(99, 71);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(186, 23);
            textBoxModel.TabIndex = 3;
            textBoxModel.Validating += textBoxModel_Validating;
            // 
            // brandLabel
            // 
            brandLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(3, 20);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(90, 15);
            brandLabel.TabIndex = 0;
            brandLabel.Text = "Brand";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBoxBrand, 2);
            textBoxBrand.Location = new Point(99, 16);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(186, 23);
            textBoxBrand.TabIndex = 1;
            textBoxBrand.Validating += textBoxBrand_Validating;
            // 
            // closeButton
            // 
            closeButton.Dock = DockStyle.Fill;
            closeButton.Location = new Point(195, 223);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(90, 35);
            closeButton.TabIndex = 9;
            closeButton.Text = "Zavřít";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += buttonClose_Click;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Fill;
            saveButton.Location = new Point(99, 223);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(90, 35);
            saveButton.TabIndex = 8;
            saveButton.Text = "Uložit";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += buttonSave_Click;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(numericUpDownYear, 2);
            numericUpDownYear.Location = new Point(99, 126);
            numericUpDownYear.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(186, 23);
            numericUpDownYear.TabIndex = 10;
            numericUpDownYear.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDownYear.Validating += numericUpDownYear_Validating;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormCarAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(tableLayoutPanel1);
            Name = "FormCarAddEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CarAddEdit";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNominalPricePerDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label nominalPriceLabel;
        private Label yearLabel;
        private Label modelLabel;
        private TextBox textBoxModel;
        private Label brandLabel;
        private TextBox textBoxBrand;
        private Button closeButton;
        private Button saveButton;
        private NumericUpDown numericUpDownNominalPricePerDay;
        private NumericUpDown numericUpDownYear;
        private ErrorProvider errorProvider;
    }
}