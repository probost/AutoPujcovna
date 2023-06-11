using AutoPujcovna_Probošt.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
        public string AssembleHTMLTableRow(Car car)
        {
            
            string brand = car.Brand;
            string model = car.Model;
            int year = car.Year;
            decimal nominalPricePerDay = car.NominalpricePerDay;

            int totalRentalDays = car.TotalRentalDays;
            decimal totalRentalPrice = car.TotalRentalPrice;

            return $"<tr><td>{brand}</td><td>{model}</td><td>{year}</td><td>{nominalPricePerDay}</td>" +
                   $"<td>{totalRentalDays}</td><td>{totalRentalPrice}</td></tr>";
        }
        public string AssembleHTMLTableRow(Rental rental)
        {
            string firstname = rental.FirstName;
            string lastname = rental.LastName;
            string phone = rental.Phone;
            string email = rental.Email;
            decimal realPricePerDay = rental.RealPricePerDay;
            decimal rentalPrice = rental.RentalPrice;

            DateTime dateFrom = rental.DateFrom;
            DateTime dateTo = rental.DateTo;

            return $"<tr><td>{firstname}</td><td>{lastname}</td><td>{phone}</td><td>{email}</td><td>{realPricePerDay}</td><td>{rentalPrice}</td><td>{dateFrom}</td><td>{dateTo}</td></tr>";
        }
    }
}
