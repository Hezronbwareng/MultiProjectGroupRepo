using System;

class Program
{
    static void Main(string[] args)
    {
        double income = GetUserInput("Enter monthly income: ");
        double allowances = GetUserInput("Enter total allowances: ");
        double deductions = GetUserInput("Enter total deductions: ");

        double taxableIncome = CalculateTaxableIncome(income, allowances, deductions);
        double paye = CalculatePAYE(taxableIncome);

        // Display the results
        Console.WriteLine($"Monthly Income: {income:C}");
        Console.WriteLine($"Total Allowances: {allowances:C}");
        Console.WriteLine($"Total Deductions: {deductions:C}");
        Console.WriteLine($"Taxable Income: {taxableIncome:C}");
        Console.WriteLine($"PAYE Tax Amount: Taxable Income * Tax Rate");
        Console.WriteLine($"PAYE Tax Amount: {paye:C}");
    }

    static double GetUserInput(string prompt)
    {
        double input;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }

    static double CalculateTaxableIncome(double income, double allowances, double deductions)
    {
        return Math.Max(0, income - allowances - deductions);
    }

    static double CalculatePAYE(double taxableIncome)
    {
        double paye = 0;

        if (taxableIncome <= 24000)
        {
            paye = taxableIncome * 0.10;
        }
        else if (taxableIncome <= 40000)
        {
            paye = 2400 + (taxableIncome - 24000) * 0.15;
        }
        else if (taxableIncome <= 60000)
        {
            paye = 6000 + (taxableIncome - 40000) * 0.20;
        }
        else if (taxableIncome <= 100000)
        {
            paye = 10000 + (taxableIncome - 60000) * 0.25;
        }
        else if (taxableIncome <= 150000)
        {
            paye = 17500 + (taxableIncome - 100000) * 0.30;
        }
        else if (taxableIncome <= 250000)
        {
            paye = 40000 + (taxableIncome - 150000) * 0.35;
        }
        else
        {
            paye = 82500 + (taxableIncome - 250000) * 0.40;
        }

        return paye;
    }
}
