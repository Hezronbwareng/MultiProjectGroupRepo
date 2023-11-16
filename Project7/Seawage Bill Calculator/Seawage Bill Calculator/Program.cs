using System;

namespace SewageBill
{
    class SewageBillCalculator
    {
        public static void Main(string[] args)
        {
            int usage_type = 0;
            float water_consumed = 0f;
            float water_bill = 0f;
            float rate = 0f;
            float rate_residential = 10f;
            float rate_commercial = 12.50f;
            float rate_industrial = 15f;

            bool err_wrong_usage_type = true;
            bool err_wrong_water_consumed_amount = true;

            Console.WriteLine("Sewage Bill Calculator");

            while (err_wrong_usage_type)
            {
                Console.WriteLine("Select usage type: ");
                Console.Write("1. Residential \n" + 
                                    "2. Commercial \n" +
                                    "3. Industrial \n");

                if (Int32.TryParse(Console.ReadLine(), out usage_type) )
                {
                    err_wrong_usage_type = false;
                }
                else
                {
                    err_wrong_usage_type = true;
                    Console.WriteLine("\nInvalid usage type. Try again.");
                    continue;
                }

                switch (usage_type)
                {
                    case 1:
                        rate = rate_residential;
                        err_wrong_usage_type = false;
                        break;

                    case 2:
                        rate = rate_commercial;
                        err_wrong_usage_type = false;
                        break;

                    case 3:
                        rate = rate_industrial;
                        err_wrong_usage_type |= false; 
                        break;

                    default:
                        Console.WriteLine("\nInavalid usage type. Try again.");
                        err_wrong_usage_type = true;
                        break;
                }
            }

            while (err_wrong_water_consumed_amount)
            {
                Console.WriteLine("Input water consumed amount:");

                if (float.TryParse(Console.ReadLine(), out water_consumed))
                {
                    err_wrong_water_consumed_amount = false;

                    if (water_consumed < 0)
                    {
                        err_wrong_water_consumed_amount = true;
                        Console.WriteLine("\nInvalid water consumed amount. Try again.");
                    }
                    else
                    {
                        err_wrong_water_consumed_amount = false;
                    }
                }
                else
                {
                    err_wrong_water_consumed_amount = true;
                    Console.WriteLine("\nInvalid water consumed amount. Try again.");
                }
            }

            water_bill = rate * water_consumed;

            Console.WriteLine("Sewage Bill");
            Console.WriteLine("Usage Type: " + usage_type);
            Console.WriteLine("Rate: " + rate);
            Console.WriteLine("Bill Amount: " + water_bill);
        }
    }
}