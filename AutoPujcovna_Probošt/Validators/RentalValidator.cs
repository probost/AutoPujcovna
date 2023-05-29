using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoPujcovna_Probošt.Validators
{
    public class RentalValidator
    {
        public bool IsFirstNameValid(string firstName)
        {
            return !string.IsNullOrWhiteSpace(firstName)
                && !(firstName.Length > 64)
                && !firstName[0].Equals(firstName.ToUpper()[0]);
        }
        public bool IsLastNameValid(string lastName)
        {
            return !string.IsNullOrWhiteSpace(lastName)
                && !(lastName.Length > 64)
                && !lastName[0].Equals(lastName.ToUpper()[0]);
        }
        public bool IsPhoneValid(string phone) 
        {
            Regex phoneRegex = new Regex(@"^(\+420 ?)?[0-9]{3} ?[0-9]{3} ?[0-9]{3}$");
            return phoneRegex.IsMatch(phone) || string.IsNullOrWhiteSpace(phone);
        }
        public bool IsEmailValid(string email)
        {
            Regex emailRegex = new Regex(@"^[a-z0-9-.]+@[a-z0-9-.]+\.[a-z0-9]{2,}$");
            return emailRegex.IsMatch(email) || string.IsNullOrWhiteSpace(email);
        }
        public bool IsRealPricePerDayValid(decimal realPricePerDay)
        {
            return !(realPricePerDay < 0)
                && !(realPricePerDay > 100000);
        }
        public bool IsDateFromValid(DateTime dateFrom, DateTime dateTo)
        {
            return dateFrom < dateTo;
        }
        public bool IsDateToValid(DateTime dateFrom, DateTime dateTo)
        {
            return dateFrom < dateTo;
        }
    }
}
