using AutoPujcovna_Probošt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPujcovna_Probošt.Exporting
{
    public class RentalCSVWriter
    {
        public RentalParser Parser { get; set; }

        public RentalCSVWriter()
        {
            Parser = new RentalParser();
        }

        public void WriteCSV(string filePath, List<Rental> rentals)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Rental rental in rentals)
                {
                    string line = Parser.AssembleCSVString(rental);
                    writer.WriteLine(line);
                }
            }
        }
    }
}
