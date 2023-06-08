using AutoPujcovna_Probošt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPujcovna_Probošt.Exporting
{
    public class CarCSVWriter
    {
        public CarParser Parser { get; set; }

        public CarCSVWriter()
        {
            Parser = new CarParser();
        }

        public void WriteCSV(string filePath, List<Car> cars)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Car car in cars)
                {
                    string line = Parser.AssembleCSVString(car);
                    writer.WriteLine(line);
                }
            }
        }
    }
}
