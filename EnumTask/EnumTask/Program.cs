namespace EnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Currency targetCurrency = Currency.Usd;
            decimal amountInAZN = 100;
            CurrencyConverter currencyConverter = new CurrencyConverter();

            Currency targetCurrency2 = Currency.Eur;
            Currency targetCurrency3 = Currency.TRY;
            Currency targetCurrency4 = Currency.Rub;


            decimal convertedAmount = currencyConverter.ConvertCurrency(targetCurrency, amountInAZN);
            decimal convertedAmount2 = currencyConverter.ConvertCurrency(targetCurrency2, amountInAZN);
            decimal convertedAmount3 = currencyConverter.ConvertCurrency(targetCurrency3, amountInAZN);
            decimal convertedAmount4 = currencyConverter.ConvertCurrency(targetCurrency4, amountInAZN);






            Console.WriteLine($"{amountInAZN} AZN is equivalent to {convertedAmount} {targetCurrency}");
            Console.WriteLine($"{amountInAZN} AZN is equivalent to {convertedAmount2} {targetCurrency2}");
            Console.WriteLine($"{amountInAZN} AZN is equivalent to {convertedAmount3} {targetCurrency3}");
            Console.WriteLine($"{amountInAZN} AZN is equivalent to {convertedAmount4} {targetCurrency4}");




        }
    }
}