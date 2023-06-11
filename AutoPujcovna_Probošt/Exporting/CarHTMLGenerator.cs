using AutoPujcovna_Probošt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoPujcovna_Probošt.Exporting
{
    public class CarHTMLGenerator
    {
        private CarParser Parser { get; set; }

        public CarHTMLGenerator()
        {
            Parser = new CarParser();
        }

        public void GenerateHTMLToFile(string outputFilePath,Car car, string templateFilePath)
        {
            string contentHTML = GenerateHTML(car, templateFilePath);
            File.WriteAllText(outputFilePath, contentHTML);
        }

        public string GenerateHTML(Car car, string templateFilePath)
        {
            string layoutHTML = File.ReadAllText(templateFilePath);
            string contentTable = GenerateHTMLTableContent(car);
            string contentHTML = string.Format(layoutHTML, contentTable);
            return contentHTML;
        }

        private string GenerateHTMLTableContent(Car car)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Parser.AssembleHTMLTableRow(car));

            builder.Append($"<th>Jméno</th><th>Příjmení</th><th>Tel.</th><th>Email</th><th>Skutečná cena/den</th><th>Cena pronájmu</th><th>Datum Od</th><th>Datum Do</th>");
                foreach (Rental rental in car.rentals)
                {
                    builder.Append(Parser.AssembleHTMLTableRow(rental));
                }
            
            return builder.ToString();
        }
    }
}
