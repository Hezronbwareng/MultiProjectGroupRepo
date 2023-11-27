namespace WATER_BILLING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WATER BILL CALCULATOR");
            Console.WriteLine();
            Usage();
        }  
        static void Usage()
        {
            Console.WriteLine("Specify your usage Type\n 1. Residential.\n 2. Commercial.\n 3. Industrial.\n 4. Check for Water Rates");
            Console.WriteLine();
            Compute();
            
        }
        public static void Compute()
        {
            try
            {
                Console.Write(">>>");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.Write("Enter consumed water in Cubic Metres: ");
                        double Consumption = Convert.ToDouble(Console.ReadLine());
                        double Bill = Consumption * 25.00;
                        double Tax = Bill * 0.03;
                        double SewerageCost = Bill * 0.02;
                        double TotalBill = Bill + Tax + SewerageCost;
                        Console.WriteLine();
                        Console.WriteLine(
                            "\nYOUR USAGE BILL IS AS FOLLOWS " +
                            "\nWater Bill amount: \t|" + Bill +
                            "\nTax: \t\t\t|" + Tax +
                            "\nSewerage Cost: \t\t|" + SewerageCost +
                             "\n---------------------------------" +
                             $"\nTOTAL COST: \t\t| {TotalBill:C}");
                        break;
                    case 2:
                        Console.Write("Enter consumed water in Cubic Metres: ");
                        Consumption = Convert.ToDouble(Console.ReadLine());
                        Bill = Consumption * 30.50;
                        Tax = Bill * 0.03;
                        SewerageCost = Bill * 0.02;
                        TotalBill = Bill + Tax + SewerageCost;
                        Console.WriteLine();
                        Console.WriteLine(
                            "\nYOUR USAGE BILL IS AS FOLLOWS " +
                            "\nWater Bill amount: \t|" + Bill +
                            "\nTax: \t\t\t|" + Tax +
                            "\nSewerage Cost: \t\t|" + SewerageCost +
                             "\n---------------------------------" +
                             $"\nTOTAL COST: \t\t| {TotalBill:C}");
                        break;

                    case 3:
                        Console.Write("Enter consumed water in Cubic Metres: ");
                        Consumption = Convert.ToDouble(Console.ReadLine());
                        Bill = Consumption * 37.75;
                        Tax = Bill * 0.03;
                        SewerageCost = Bill * 0.02;
                        TotalBill = Bill + Tax + SewerageCost;
                        Console.WriteLine();
                        Console.WriteLine(
                            "\nYOUR USAGE BILL IS AS FOLLOWS " +
                            "\nWater Bill amount: \t|" + Bill +
                            "\nTax: \t\t\t|" + Tax +
                            "\nSewerage Cost: \t\t|" + SewerageCost +
                            "\n---------------------------------" +
                            $"\nTOTAL COST: \t\t| {TotalBill:C}");

                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine(
                            "USAGE TYPE        RATES  \n" +
                             "---------------------------\n" +
                            "Residential       | 25.00\n" +
                            "Commercial        | 30.50\n" +
                            "Industrial        | 35.75\n" +
                            "Tax               | 3%\n" +
                            "Sewerage Cost     | 2%\n");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        Usage();
                        break;
                }
            }
            catch (FormatException) { 
                Console.WriteLine("invalid input");
                Usage();
            }
        }
        

        
    }
}