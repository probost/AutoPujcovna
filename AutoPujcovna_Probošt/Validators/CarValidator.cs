using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPujcovna_Probošt.Validators
{
    public class CarValidator
    {
        public bool IsBrandValid(string brand)
        {
            return
                !string.IsNullOrWhiteSpace(brand)
                && !(brand.Length > 32);
        }
        public bool IsModelValid(string model)
        {
            return
                !string.IsNullOrWhiteSpace(model)
                && !(model.Length > 32);
        }
        public bool IsYearValid(int year)
        {
            return
                !(year < 1900)
                && !(year > DateTime.Now.Year);
        }
        public bool IsNominalPricePerDayValid(decimal nominalPrice)
        {
            return
                !(nominalPrice < 0)
                && !(nominalPrice > 1000000);
        }

    }
}
