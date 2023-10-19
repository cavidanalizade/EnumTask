using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTask
{
    internal class CurrencyConverter
    {
        public  decimal ConvertCurrency(Currency targetCurrency, decimal amountInAZN)
        {
            decimal convertedAmount = 0;

            switch (targetCurrency)
            {
                case Currency.Usd:

                    convertedAmount = amountInAZN * 0.59M;
                    break;
                case Currency.Eur:
                    convertedAmount = amountInAZN * 0.56M;
                    break;
                case Currency.TRY:
                    convertedAmount = amountInAZN * 16.4826M;
                    break;
                case Currency.Rub:
                    convertedAmount = amountInAZN * 56.9726M;
                    break;
            }

            return convertedAmount;
        }
    }
}
