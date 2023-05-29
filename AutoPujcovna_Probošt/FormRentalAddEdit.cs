using AutoPujcovna_Probošt.Entities;
using AutoPujcovna_Probošt.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPujcovna_Probošt
{
    public partial class FormRentalAddEdit : Form
    {
        public Rental Rental { get; set; }
        public RentalValidator Validator { get; set; }
        public FormRentalAddEdit(Rental rental)
        {
            Validator = new RentalValidator();
            Rental = rental;
            InitializeComponent();
            SetComponentValues();
        }
        private void SetComponentValues()
        {
            textBoxFirstName.Text = Rental.FirstName;
            textBoxLastName.Text = Rental.LastName;
            textBoxPhone.Text = Rental.Phone;
            textBoxEmail.Text = Rental.Email;
            numericUpDownRealPricePerDay.Value = Rental.RealPricePerDay;
            dateTimePickerDateFrom.Value = Rental.DateFrom;
            dateTimePickerDateTo.Value = Rental.DateTo;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) //uloží pouze v případě, že jsou všechny prvky ve formuláři validní
            {
                Rental.FirstName = textBoxFirstName.Text;
                Rental.LastName = textBoxLastName.Text;
                Rental.Phone = textBoxPhone.Text;
                Rental.Email = textBoxEmail.Text;
                Rental.RealPricePerDay = numericUpDownRealPricePerDay.Value;
                Rental.DateFrom = dateTimePickerDateFrom.Value;
                Rental.DateTo = dateTimePickerDateTo.Value;

                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void textBoxFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsFirstNameValid(textBoxFirstName.Text);
            if (valid)
            {
                errorProvider.SetError(textBoxFirstName, null);
            }
            else
            {
                errorProvider.SetError(textBoxFirstName, "Zadané jméno není platné");
                e.Cancel = true;
            }
        }
        private void textBoxLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsLastNameValid(textBoxLastName.Text);
            if (valid)
            {
                errorProvider.SetError(textBoxLastName, null);
            }
            else
            {
                errorProvider.SetError(textBoxLastName, "Zadané příjmení není platné");
                e.Cancel = true;
            }
        }
        private void textBoxPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsPhoneValid(textBoxPhone.Text);
            if (valid)
            {
                errorProvider.SetError(textBoxPhone, null);
            }
            else
            {
                errorProvider.SetError(textBoxPhone, "Zadané tel. číslo není platné");
                e.Cancel = true;
            }
        }
        private void textBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsEmailValid(textBoxEmail.Text);
            if (valid)
            {
                errorProvider.SetError(textBoxEmail, null);
            }
            else
            {
                errorProvider.SetError(textBoxEmail, "Zadané jméno není platné");
                e.Cancel = true;
            }
        }
        private void numericUpDownRealPricePerDay_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsRealPricePerDayValid(numericUpDownRealPricePerDay.Value);
            if (valid)
            {
                errorProvider.SetError(numericUpDownRealPricePerDay, null);
            }
            else
            {
                errorProvider.SetError(numericUpDownRealPricePerDay, "Zadané jméno není platné");
                e.Cancel = true;
            }
        }
        private void dateTimePickerDateFrom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsDateFromValid(dateTimePickerDateFrom.Value, dateTimePickerDateTo.Value);
            if (valid)
            {
                errorProvider.SetError(dateTimePickerDateFrom, null);
            }
            else
            {
                errorProvider.SetError(dateTimePickerDateFrom, "Zadané jméno není platné");
                e.Cancel = true;
            }
        }
        private void dateTimePickerDateTo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsDateToValid(dateTimePickerDateFrom.Value, dateTimePickerDateTo.Value);
            if (valid)
            {
                errorProvider.SetError(dateTimePickerDateTo, null);
            }
            else
            {
                errorProvider.SetError(dateTimePickerDateTo, "Zadané jméno není platné");
                e.Cancel = true;
            }
        }
    }
}
