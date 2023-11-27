namespace COMPLEX_CALCULATOR;
class Program
{
    static void Main(string[] args)
    {
        Options();
    }

    static void Options()
    {
        Console.WriteLine("THIS IS A SIMPLE CALCULATOR");
        Console.WriteLine("1. Addition\n" +
            "2. Subtraction \n" +
            "3. Multiplication\n" +
            "4. Division\n" +
            "5. SquareRoot\n" );

        Console.WriteLine("Enter Your Choice");
        Operation();
    }
    static void Operation()
    {
        try
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            double results;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter number 1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    results = num1 + num2;
                    Console.WriteLine(results);
                    break;
                case 2:
                    Console.Write("Enter number 1: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    results = num1 - num2;
                    Console.WriteLine(results);
                    break;
                case 3:
                    Console.Write("Enter number 1: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    results = num1 * num2;
                    Console.WriteLine(results);
                    break;
                case 4:
                    Console.Write("Enter number 1: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                            if (num2 == 0)
                                 {
                                   Console.WriteLine("A number cant be divided by zero");
                            break;
                                }
                    results = num1 / num2;
                    Console.WriteLine(results);
                    break;
                case 5:
                    Console.Write("Enter the Number to squareRoot: ");
                    double tester = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The sqrt is: " + Math.Sqrt(tester));
                    break;
                default:
                    Console.WriteLine("Invalid Option entered");
                    Options();
                    break;
            }
        }
        
      /*  catch (DivideByZeroException )
        {
            Console.WriteLine("A number cant be divided by zero");
        }*/
        catch (Exception)
        {
            Console.WriteLine("Enter a valid Option");
            Console.WriteLine();
            Options();
        }
    }
}