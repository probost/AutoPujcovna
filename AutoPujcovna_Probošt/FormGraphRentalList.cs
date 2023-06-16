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
    public partial class FormGraphRentalList : Form
    {
        List<Rental> Rentals = new List<Rental>();
        public FormGraphRentalList(List<Rental> TopThreeRentals)
        {
            Rentals = TopThreeRentals;
            InitializeComponent();
            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            float graphStartX = 50;
            float graphStartY = 50;

            float graphHeight = (pictureBox.Height - 50) / 3;
            float graphWidth = (pictureBox.Width - 50);

            List<decimal> RentalPrices = Rentals.Select(r => r.RentalPrice).ToList();
            float firstPrice = (float)RentalPrices[0];
            float secondPrice = (float)RentalPrices[1];
            float thirdPrice = (float)RentalPrices[2];


            g.FillRectangle(Brushes.Red, graphStartX, graphStartY, graphWidth, graphHeight);
            g.FillRectangle(Brushes.OrangeRed, graphStartX, graphStartY + graphHeight + 5, secondPrice / firstPrice*graphWidth, graphHeight);
            g.FillRectangle(Brushes.Orange, graphStartX, graphStartY + 2 * graphHeight + 10, thirdPrice / firstPrice * graphWidth, graphHeight);

            
            g.DrawString($"ID:{Rentals[0].ID}, {firstPrice}", Font, Brushes.Black, graphStartX + 5, graphStartY + 5);
            g.DrawString($"ID:{Rentals[1].ID}, {secondPrice}", Font, Brushes.Black, graphStartX + 5, graphStartY + graphHeight + 5 + 5);
            g.DrawString($"ID:{Rentals[2].ID}, {thirdPrice}", Font, Brushes.Black, graphStartX + 5, graphStartY + 2 *  graphHeight + 5 + 5);

        }
    }
}
