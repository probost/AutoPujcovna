﻿using AutoPujcovna_Probošt.Datasources;
using AutoPujcovna_Probošt.Entities;
using AutoPujcovna_Probošt.Exporting;
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
    public partial class FormRentalList : Form
    {
        public Car Car { get; set; }
        public RentalCSVWriter RentalsCSV { get; set; }
        public CarHTMLGenerator CarHTML { get; set; }
        public RentalDataSource RentalDataSource { get; set; }

        public FormRentalList(Car car)
        {

            Car = car;
            RentalDataSource = new RentalDataSource();
            RentalsCSV = new RentalCSVWriter();
            CarHTML = new CarHTMLGenerator();

            InitializeComponent();
            SetComponentValues();

            dataGridViewRentals.DataSource = RentalDataSource;
            //dataGridViewRentals.Columns.Add("NumberOfDays", "Number of days");
        }
        private void FormRentalList_Load(object sender, EventArgs e)
        {
            RentalDataSource.LoadAllByCar(Car);
        }

        private void SetComponentValues()
        {
            textBoxBrand.Text = Car.Brand;
            textBoxModel.Text = Car.Model;
            textBoxYear.Text = Convert.ToString(Car.Year);
            textBoxNominalPricePerDay.Text = Convert.ToString(Car.NominalpricePerDay);
        }



        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental();


            FormRentalAddEdit form = new FormRentalAddEdit(rental, Car);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                RentalDataSource.Add(rental);
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRentals.CurrentCell == null)
                return;

            int index = dataGridViewRentals.CurrentCell.RowIndex;
            Rental Rental = RentalDataSource.GetByIndex(index);

            FormRentalAddEdit form = new FormRentalAddEdit(Rental, Car);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                RentalDataSource.Update(index, Rental);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRentals.CurrentCell == null)
                return;

            int index = dataGridViewRentals.CurrentCell.RowIndex;
            Rental Rental = RentalDataSource.GetByIndex(index);

            DialogResult result = MessageBox.Show(
                $"Opravdu chcete odstranit pronájem s ID:{Rental.ID}, jména: {Rental.LastName}, {Rental.FirstName}, data: {Rental.DateFrom},{Rental.DateTo}?",
                "Odstranění pronájmu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                RentalDataSource.Remove(index);
            }
        }

        private void exportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialogCSV.ShowDialog();
            if (result == DialogResult.OK)
            {
                List<Rental> rentals = RentalDataSource.GetAll();
                string path = saveFileDialogCSV.FileName;
                RentalsCSV.WriteCSV(path, rentals);
            }
        }

        private void exportHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialogHTML.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = saveFileDialogHTML.FileName;
                string templateFilePath = @".\template.html";
                //TODO: FileOpenDialog box pro využití vlastního html template 
                CarHTML.GenerateHTMLToFile(path, Car, templateFilePath);
            }
        }

        private void graphTopThreeRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRentals.CurrentCell == null || Car.rentals.Count < 3)
                return;


            List<Rental> TopThreeRentals = Car.rentals.OrderByDescending(r => r.RentalPrice).Take(3).ToList();

            FormGraphRentalList form = new FormGraphRentalList(TopThreeRentals);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}

