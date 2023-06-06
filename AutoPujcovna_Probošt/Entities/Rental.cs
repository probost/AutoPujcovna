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
    [Table("rental")]

    public class Rental
    {
        [Key]
        [Column("id")]
        public int ID {  get; set; }
        [Browsable(false)]
        [Column("car_id")]
        public int CarID { get; set; }
        [Column("first_name")]

        public string FirstName { get; set; }
        [Column("last_name")]

        public string LastName { get; set; }
        [Column("phone")]

        public string Phone { get; set; }
        [Column("email")]

        public string Email { get; set; }
        [Column("real_price_per_day")]

        public decimal RealPricePerDay { get; set; }
        [Column("date_from")]

        public DateTime DateFrom { get; set; }
        [Column("date_to")]

        public DateTime DateTo { get; set; }
        public int NumberOfDays
        {
           get { return CalculateNumberOfDays(); }
        }
        public decimal RentalPrice
        {
            get { return CalculateRentalPrice(); }
        }


        public Rental()
        {
            ID = 0;
            CarID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            RealPricePerDay = 0;
            DateFrom = DateTime.Now;
            DateTo = DateTime.Now;
        }
        public Rental(int carID, string firstName, string lastName, string phone, string email, decimal realPricePerDay, DateTime dateFrom, DateTime dateTo)
        {
            CarID = carID;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            RealPricePerDay = realPricePerDay;
            DateFrom = dateFrom;
            DateTo = dateTo;
        }
        public int CalculateNumberOfDays()
        {
            return (int)Math.Ceiling((DateTo - DateFrom).TotalDays);
        }
        public decimal CalculateRentalPrice()
        {
            return CalculateNumberOfDays()*RealPricePerDay;
        }
        public bool DetermineIsInRentalPeriod(DateTime date)
        {
            return date >= DateFrom && date <= DateTo;
        }
    }
}
