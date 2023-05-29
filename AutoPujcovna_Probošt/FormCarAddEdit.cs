using AutoPujcovna_Probošt.Entities;
using AutoPujcovna_Probošt.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPujcovna_Probošt
{
    public partial class FormCarAddEdit : Form
    {
        public Car Car { get; set; }
        public CarValidator Validator { get; set; }
        public FormCarAddEdit(Car car)
        {
            Validator = new CarValidator();
            Car = car;
            InitializeComponent();
            SetComponentValues();
        }
        private void SetComponentValues()
        {
            textBoxBrand.Text = Car.Brand;
            textBoxModel.Text = Car.Model;
            numericUpDownYear.Value = Car.Year;
            numericUpDownNominalPricePerDay.Value = Car.NominalpricePerDay;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) //uloží pouze v případě, že jsou všechny prvky ve formuláři validní
            {
                Car.Brand = textBoxBrand.Text;
                Car.Model = textBoxModel.Text;
                Car.Year = (int)numericUpDownYear.Value;
                Car.NominalpricePerDay = (int)numericUpDownNominalPricePerDay.Value;

                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void textBoxBrand_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsBrandValid(textBoxBrand.Text);
            if (valid)
            {
                errorProvider.SetError(textBoxBrand, null);
            }
            else
            {
                errorProvider.SetError(textBoxBrand, "Zadaná značka není platná");
                e.Cancel = true;
            }
        }

        private void textBoxModel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsModelValid(textBoxModel.Text);
            if (valid)
            {
                errorProvider.SetError(textBoxModel, null);
            }
            else
            {
                errorProvider.SetError(textBoxModel, "Zadaný model není platný");
                e.Cancel = true;
            }
        }

        private void numericUpDownYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsYearValid((int)numericUpDownYear.Value);
            if (valid)
            {
                errorProvider.SetError(numericUpDownYear, null);
            }
            else
            {
                errorProvider.SetError(textBoxModel, "Zadaný rok není platný");
                e.Cancel = true;
            }
        }

        private void numericUpDownNominalPricePerDay_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool valid = Validator.IsNominalPricePerDayValid((int)numericUpDownNominalPricePerDay.Value);
            if (valid)
            {
                errorProvider.SetError(numericUpDownNominalPricePerDay, null);
            }
            else
            {
                errorProvider.SetError(numericUpDownNominalPricePerDay, "Zadaná nominální cena na den není platná");
                e.Cancel = true;
            }
        }
    }
}
