using AutoPujcovna_Probošt.Datasources;
using AutoPujcovna_Probošt.Entities;
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

        public RentalDataSource DataSource { get; set; }

        public FormRentalList(Car car)
        {
            Car = car;
            DataSource = new RentalDataSource();

            InitializeComponent();
            SetComponentValues();

            dataGridViewRentals.DataSource = DataSource;
        }

        private void SetComponentValues()
        {
            textBoxBrand.Text = Car.Brand;
            textBoxModel.Text = Car.Model;
            textBoxYear.Text = Convert.ToString(Car.Year);
            textBoxNominalPricePerDay.Text = Convert.ToString(Car.NominalpricePerDay);
        }

        private void FormRentalList_Load(object sender, EventArgs e)
        {
            DataSource.LoadAllByCar(Car);
        }
    }
}

