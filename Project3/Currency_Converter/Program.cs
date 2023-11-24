using System;

namespace Currency_Converter
{
    class Program
    {
        private static double start_currency;

        static void Main(string[] args)
        {
            //exchange rates for multiple currencies
            double UsdtoEuroRates = 0.95;
            double UsdtoKshsRates = 147.55;
            double KshstoEuroRates = 0.0064;
            double KshstoUsdRates = 0.0068;
            double EurotoUsdRates = 1.06;
            double EurotoKshsRates = 156.10;
            double DirtoEuroRates = 0.26;
            double DirtoKshsRates = 40.97;
            double DirtoUsdRates = 0.27;
            double KshstoDirRates = 0.024;
            double UsdtoDirRates = 3.67;
            double EurotoDirRates = 3.88;

            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine("** Welcome to the currency converter! **");
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine(" ");
            //indicates the currencies that can be converted.
            System.Console.WriteLine("These are the currencies you can convert");
            System.Console.WriteLine("Euros(EUR), Kenyan Shillings(KSHS), United States Dollars(USD), Dirhams(DIR).");

            do
            {
                //get the user input on the ammount to be converted and give an error if the data type is wrong.
                System.Console.Write("Enter the amount you want to convert from: ");
                if ( double.TryParse(Console.ReadLine(), out start_currency)){}
                else 
                {
                    System.Console.WriteLine("INVALID INPUT OF THE AMOUNT!");
                }
                
                System.Console.WriteLine("Here are the currencies conversion choices.");
                System.Console.WriteLine("");
                System.Console.WriteLine("EURTOKSH : Euros to Kenyan Shillings");
                System.Console.WriteLine("EURTOUSD : Euros to United states Dollars");
                System.Console.WriteLine("KSHSTOEUR : Kenyan Shillings to Euros");
                System.Console.WriteLine("KSHSTOUSD : Kenyan Shilling to United States Dollars");
                System.Console.WriteLine("USDTOEUR : United  States Dollars to Euros");
                System.Console.WriteLine("USDTOKSHS : United States Dollars to Kenyan Shillings");
                System.Console.WriteLine("DIRTOKSHS : Dirhams to Kenyan Shillings");
                System.Console.WriteLine("DIRTOEURO : Dirhams to Euros");
                System.Console.WriteLine("DIRTOUSD : Dirhams to United States Dollars");
                System.Console.WriteLine("KSHSTODIR : Kenyan Shilling to Dirhams");
                System.Console.WriteLine("EURTODIR : Euros to Dirhams");
                System.Console.WriteLine("USDTODIR : United States Dollars to Dirhams");
                System.Console.WriteLine("");
                System.Console.WriteLine("Enter your choice: ");    
                string initials = Console.ReadLine();

                double final_currency = 0;
                switch(initials)
                {
                    case "EURTOKSHS":
                        final_currency = start_currency * EurotoKshsRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} KSHS");
                        break;
                    case "EURTOUSD":
                        final_currency = start_currency * EurotoUsdRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} USD");
                        break;
                    case "KSHSTOEUR":
                        final_currency = start_currency * KshstoEuroRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} EUR");
                        break;
                    case "KSHSTOUSD":
                        final_currency = start_currency * KshstoUsdRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} USD");
                        break;
                    case "USDTOEUR":
                        final_currency = start_currency * UsdtoEuroRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} EUR");
                        break;
                    case "USDTOKSHS":
                        final_currency = start_currency * UsdtoKshsRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} KSHS");
                        break;
                    case "DIRTOUSD":
                        final_currency = start_currency * DirtoUsdRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} USD");
                        break;
                    case "DIRTOKSHS":
                        final_currency = start_currency * DirtoKshsRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} KSHS");
                        break;
                    case "DIRTOEURO":
                        final_currency = start_currency * DirtoEuroRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} EUR");
                        break;
                    case "EURTODIR":
                        final_currency = start_currency * EurotoDirRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} DIR");
                        break;
                    case "KSHSTODIR":
                        final_currency = start_currency * KshstoDirRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} DIR");
                        break;
                    case "USDTODIR":
                        final_currency = start_currency * UsdtoDirRates;
                        System.Console.WriteLine($"Converted amount = {final_currency} DIR");
                        break;
                    default:
                        System.Console.WriteLine("INVALID OPTION!");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = Yes, N = No): ");
            }
            while(Console.ReadLine().ToUpper() == "Y");

            System.Console.WriteLine("Thank you and Bye!  (^_^)");
        }
    }
}