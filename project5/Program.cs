using System;

class PowerBillCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Power Bill Calculator!");
        Console.WriteLine("We are glad to have you use our software");

        try
        {
            // POWER CONSUMPTION USER INPUT
            Console.Write("Enter your power consumption in KWh: ");
            double powerConsumption = Convert.ToDouble(Console.ReadLine());

            // USER INPUT FOR USAGE TYPE
            Console.Write("Enter your usage type (residential, commercial, or industrial): ");
            string usageType = Console.ReadLine().ToLower(); // Convert to lowercase for case-insensitive comparison

            // VALIDATING USAGE TYPE
            if (usageType != "residential" && usageType != "commercial" && usageType != "industrial")
            {
                throw new ArgumentException("Invalid usage type. Please choose residential, commercial, or industrial.");
            }

            // CALCULATING POWER BILL
            double tariffRate = GetTariffRate(usageType);
            double powerBill = CalculatePowerBill(powerConsumption, tariffRate);

            // DISPLAY THE RESULT
            Console.WriteLine($"\nYour monthly power bill breakdown:");
            Console.WriteLine($"Power Consumption: {powerConsumption} KWh");
            Console.WriteLine($"Tariff Rate: ${tariffRate:F2} per KWh");
            Console.WriteLine($"Total Power Bill: ${powerBill:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric value for power consumption.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static double GetTariffRate(string usageType)
    {
        // TARIFF RATES
        switch (usageType)
        {
            case "residential":
                return 12.50;
            case "commercial":
                return 15.75;
            case "industrial":
                return 18.90;
            default:
                throw new ArgumentException("Invalid usage type.");
        }
    }

    static double CalculatePowerBill(double powerConsumption, double tariffRate)
    {
        return powerConsumption * tariffRate;
    }
}
