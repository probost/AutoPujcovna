namespace AutoPujcovna_Probošt
{
    partial class FormRentalAddEdit
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
            nominalPriceLabel = new Label();
            yearLabel = new Label();
            modelLabel = new Label();
            textBoxLastName = new TextBox();
            brandLabel = new Label();
            textBoxFirstName = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            saveButton = new Button();
            closeButton = new Button();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDownRealPricePerDay = new NumericUpDown();
            dateTimePickerDateFrom = new DateTimePicker();
            dateTimePickerDateTo = new DateTimePicker();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRealPricePerDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nominalPriceLabel
            // 
            nominalPriceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nominalPriceLabel.AutoSize = true;
            nominalPriceLabel.Location = new Point(3, 100);
            nominalPriceLabel.Name = "nominalPriceLabel";
            nominalPriceLabel.Size = new Size(94, 15);
            nominalPriceLabel.TabIndex = 6;
            nominalPriceLabel.Text = "Email";
            // 
            // yearLabel
            // 
            yearLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(3, 69);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(94, 15);
            yearLabel.TabIndex = 4;
            yearLabel.Text = "Phone";
            // 
            // modelLabel
            // 
            modelLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(3, 38);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(94, 15);
            modelLabel.TabIndex = 2;
            modelLabel.Text = "LastName";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBoxLastName, 2);
            textBoxLastName.Location = new Point(103, 34);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(258, 23);
            textBoxLastName.TabIndex = 3;
            textBoxLastName.Validating += textBoxLastName_Validating;
            // 
            // brandLabel
            // 
            brandLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(3, 7);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(94, 15);
            brandLabel.TabIndex = 0;
            brandLabel.Text = "FirstName";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBoxFirstName, 2);
            textBoxFirstName.Location = new Point(103, 3);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(258, 23);
            textBoxFirstName.TabIndex = 1;
            textBoxFirstName.Validating += textBoxFirstName_Validating;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(saveButton, 0, 9);
            tableLayoutPanel1.Controls.Add(closeButton, 0, 9);
            tableLayoutPanel1.Controls.Add(nominalPriceLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(yearLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(modelLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxLastName, 1, 1);
            tableLayoutPanel1.Controls.Add(brandLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxFirstName, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxPhone, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 6);
            tableLayoutPanel1.Controls.Add(numericUpDownRealPricePerDay, 1, 4);
            tableLayoutPanel1.Controls.Add(dateTimePickerDateFrom, 1, 5);
            tableLayoutPanel1.Controls.Add(dateTimePickerDateTo, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(384, 319);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Fill;
            saveButton.Location = new Point(3, 281);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 35);
            saveButton.TabIndex = 15;
            saveButton.Text = "Uložit";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += buttonSave_Click;
            // 
            // closeButton
            // 
            closeButton.Dock = DockStyle.Fill;
            closeButton.Location = new Point(103, 281);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(126, 35);
            closeButton.TabIndex = 16;
            closeButton.Text = "Zavřít";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += buttonClose_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBoxPhone, 2);
            textBoxPhone.Location = new Point(103, 65);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(258, 23);
            textBoxPhone.TabIndex = 10;
            textBoxPhone.Validating += textBoxPhone_Validating;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBoxEmail, 2);
            textBoxEmail.Location = new Point(103, 96);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(258, 23);
            textBoxEmail.TabIndex = 11;
            textBoxEmail.Validating += textBoxEmail_Validating;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 131);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 17;
            label1.Text = "RealPricePerDay";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 162);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 21;
            label2.Text = "Date From";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 193);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 22;
            label3.Text = "Date To";
            // 
            // numericUpDownRealPricePerDay
            // 
            tableLayoutPanel1.SetColumnSpan(numericUpDownRealPricePerDay, 2);
            numericUpDownRealPricePerDay.Location = new Point(103, 126);
            numericUpDownRealPricePerDay.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownRealPricePerDay.Name = "numericUpDownRealPricePerDay";
            numericUpDownRealPricePerDay.Size = new Size(180, 23);
            numericUpDownRealPricePerDay.TabIndex = 23;
            numericUpDownRealPricePerDay.Validating += numericUpDownRealPricePerDay_Validating;
            // 
            // dateTimePickerDateFrom
            // 
            dateTimePickerDateFrom.Location = new Point(103, 157);
            dateTimePickerDateFrom.MaxDate = new DateTime(2200, 5, 29, 0, 0, 0, 0);
            dateTimePickerDateFrom.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            dateTimePickerDateFrom.Size = new Size(126, 23);
            dateTimePickerDateFrom.TabIndex = 24;
            dateTimePickerDateFrom.Value = new DateTime(2023, 5, 29, 0, 0, 0, 0);
            dateTimePickerDateFrom.Validating += dateTimePickerDateFrom_Validating;
            // 
            // dateTimePickerDateTo
            // 
            dateTimePickerDateTo.Location = new Point(103, 188);
            dateTimePickerDateTo.MaxDate = new DateTime(2200, 5, 29, 0, 0, 0, 0);
            dateTimePickerDateTo.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            dateTimePickerDateTo.Size = new Size(126, 23);
            dateTimePickerDateTo.TabIndex = 25;
            dateTimePickerDateTo.Value = new DateTime(2023, 5, 29, 0, 0, 0, 0);
            dateTimePickerDateTo.Validating += dateTimePickerDateTo_Validating;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormRentalAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 319);
            Controls.Add(tableLayoutPanel1);
            Name = "FormRentalAddEdit";
            Text = "FormRentalAddEdit";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRealPricePerDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label nominalPriceLabel;
        private Label yearLabel;
        private Label modelLabel;
        private TextBox textBoxLastName;
        private Label brandLabel;
        private TextBox textBoxFirstName;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private Button saveButton;
        private Button closeButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownRealPricePerDay;
        private DateTimePicker dateTimePickerDateFrom;
        private DateTimePicker dateTimePickerDateTo;
        private ErrorProvider errorProvider;
    }
}