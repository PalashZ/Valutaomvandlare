namespace Valutaomvandlare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double CurrencyEUR = 0.089;
            const double CurrencyGBP = 0.075;
            const double CurrencyJPY = 15.720;
            const double CurrencyUSD = 0.100;


            Console.WriteLine("Hello, how much money do you want exchange");
            double CurrencySEK = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please choose a currency : EUR, GBP, JPY, USD");
            string Currency = Console.ReadLine().ToUpper();

            double result;

            switch (Currency)
            {
                case "EUR":
                    result = CurrencySEK * CurrencyEUR;
                    Console.WriteLine(CurrencySEK + "SEK is " + result + " EUR");
                    break;

                case "GBP":
                    result = CurrencySEK * CurrencyGBP;
                    Console.WriteLine("SEK is " + result + " GBP");
                    break;


                case "JPY":
                    result = CurrencySEK * CurrencyJPY;
                    Console.WriteLine("SEK is " + result + " JPY");
                    break;

                case "USD":
                    result = CurrencySEK * CurrencyUSD;
                    Console.WriteLine("SEK is " + result + " USD");
                    break;

                default:
                    Console.WriteLine("Unknown Currency!");
                    break;
            }
            
        }
    }
}
