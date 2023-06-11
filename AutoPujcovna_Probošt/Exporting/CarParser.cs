using AutoPujcovna_Probošt.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPujcovna_Probošt.Exporting
{
    public class CarParser
    {
        //public Car ParseCSVString(string text)
        //{
        //    string[] parts = text.Split(';');

        //    int id = Convert.ToInt32(parts[0]);
        //    string brand = parts[1];
        //    string model = parts[2];
        //    int year = Convert.ToInt32(parts[3]);
        //    decimal nominalPricePerDay = Convert.ToInt32(parts[4]);

        //    return new Car(brand,model,year,nominalPricePerDay);
        //}

        public string AssembleCSVString(Car car)
        {
            int id = car.ID;
            string brand = car.Brand;
            string model = car.Model;
            int year = car.Year;
            decimal nominalPricePerDay = car.NominalpricePerDay;

            return $"{id};{brand};{model};{year};{nominalPricePerDay}";
        }
        //public string AssembleHTMLTableRow(Car car)
        //{
        //    string classname = student.ClassName;
        //    string lastname = student.LastName;
        //    string firstname = student.FirstName;
        //    string average = student.AverageGradeText;

        //    return $"<tr><td>{classname}</td><td>{lastname}</td><td>{firstname}</td><td>{average}</td></tr>";
        //}
    }
}
