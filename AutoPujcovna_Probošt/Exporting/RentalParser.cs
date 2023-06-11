using AutoPujcovna_Probošt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPujcovna_Probošt.Exporting
{
    public class RentalParser
    {
        public string AssembleCSVString(Rental rental)
        {
            int id = rental.ID;
            int carId = rental.CarID;
            string firstname = rental.FirstName;
            string lastname = rental.LastName;
            string phone = rental.Phone;
            string email = rental.Email;
            decimal realPricePerDay = rental.RealPricePerDay;
            DateTime dateFrom = rental.DateFrom;
            DateTime dateTo = rental.DateTo;




            return $"{id};{carId};{firstname};{lastname};{phone};{email};{realPricePerDay};{dateFrom};{dateTo}";
        }
    }
}
