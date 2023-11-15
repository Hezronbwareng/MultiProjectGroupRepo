using System;

class PowerBillCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Power Bill Calculator!");

        try
        {
            // Get user input for power consumption
            Console.Write("Enter your power consumption in KWh: ");
            double powerConsumption = Convert.ToDouble(Console.ReadLine());

            // Get user input for usage type
            Console.Write("Enter your usage type (residential, commercial, or industrial): ");
            string usageType = Console.ReadLine().ToLower(); // Convert to lowercase for case-insensitive comparison

            // Validate usage type
            if (usageType != "residential" && usageType != "commercial" && usageType != "industrial")
            {
                throw new ArgumentException("Invalid usage type. Please choose residential, commercial, or industrial.");
            }

            // Calculate the power bill
            double tariffRate = GetTariffRate(usageType);
            double powerBill = CalculatePowerBill(powerConsumption, tariffRate);

            // Display the result with a breakdown
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
        // Define the tariff rates
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
