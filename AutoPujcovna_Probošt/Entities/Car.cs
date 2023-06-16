using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPujcovna_Probošt.Entities
{
    [Table("car")]
    public class Car
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("brand")]
        public string Brand { get; set; }
        [Column("model")]
        public string Model { get; set; }
        [Column("year")]
        public int Year { get; set; }
        [Column("nominal_price_per_day")]

        public decimal NominalpricePerDay { get; set; }
        [Browsable(false)]

        public virtual List<Rental> rentals { get; set; }


        public int TotalRentalDays
        {
            get { return CalculateTotalRentalDays(); }
        }
        public decimal TotalRentalPrice
        {
            get { return CalculateTotalRentalPrice(); }
        }
        [DisplayName("Pronajato")]
        public string IsRentedNow
        {
            get 
            { 
                if(DetermineIsRentedNow())
                {
                    return "ano";
                }
                else
                {
                    return "ne";
                }
            }
        }


        public Car()
        {
            rentals = new List<Rental>();
            ID = 0;
            Brand = string.Empty;
            Model = string.Empty;
            Year = DateTime.Now.Year;
            NominalpricePerDay = 0;
        }
        public Car(string brand, string model, int year, decimal nominalpricePerDay)
        {
            rentals = new List<Rental>();
            Brand = brand;
            Model = model;
            Year = year;
            NominalpricePerDay = nominalpricePerDay;
        }
        public int CalculateTotalRentalDays()
        {
            return rentals.Sum(r => r.CalculateNumberOfDays());
        }
        public decimal CalculateTotalRentalPrice()
        {
            return rentals.Sum(r =>r.CalculateRentalPrice());
        }

        public bool DetermineIsRentedNow()
        {
            return rentals.Any(r =>r.DetermineIsInRentalPeriod(DateTime.Now));
        }
    }
}
