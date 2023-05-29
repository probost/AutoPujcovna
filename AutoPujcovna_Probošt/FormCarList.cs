using AutoPujcovna_Probošt.Datasources;
using AutoPujcovna_Probošt.Entities;

namespace AutoPujcovna_Probošt
{
    public partial class FormCarList : Form
    {
        public CarDataSource CarDataSource;
        public FormCarList()
        {
            CarDataSource = new CarDataSource();
            InitializeComponent();
            dataGridViewCar.DataSource = CarDataSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarDataSource.LoadAll();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car car = new Car();

            FormCarAddEdit form = new FormCarAddEdit(car);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                CarDataSource.Add(car);
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCar.CurrentCell == null)
                return;

            int index = dataGridViewCar.CurrentCell.RowIndex;
            Car Car = CarDataSource.GetByIndex(index);

            FormCarAddEdit form = new FormCarAddEdit(Car);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                CarDataSource.Update(index, Car);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCar.CurrentCell == null)
                return;

            int index = dataGridViewCar.CurrentCell.RowIndex;
            Car Car = CarDataSource.GetByIndex(index);

            DialogResult result = MessageBox.Show(
                $"Opravdu chcete odstranit auto s ID:{Car.ID}, {Car.Brand},{Car.Model}, rok {Car.Year}?",
                "Odstranění auta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                CarDataSource.Remove(index);
            }
        }

        private void rentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCar.CurrentCell == null)
                return;

            int index = dataGridViewCar.CurrentCell.RowIndex;
            Car car = CarDataSource.GetByIndex(index);

            FormRentalList form = new FormRentalList(car);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}