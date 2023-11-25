 PAYE Tax Calculator
This C# program calculates the PAYE (Pay As You Earn) tax based on the given monthly income, total allowances, and total deductions.

Table of Contents
Introduction
Usage
Running the Program
Sample Output
Introduction
The program Program.cs contains C# code to calculate PAYE tax based on income, allowances, and deductions. It utilizes functions to obtain user input, calculate taxable income, and determine the PAYE tax amount based on defined income brackets.

Usage
To use this program, follow these steps:

Ensure You Have Appropriate Tools:

Have the .NET SDK installed on your system.
Use an IDE like Visual Studio Code with appropriate C# extensions.
Understanding the Code:

The Main method prompts the user to input their monthly income, total allowances, and total deductions.
Functions GetUserInput, CalculateTaxableIncome, and CalculatePAYE handle user input and calculate the PAYE tax based on predefined tax brackets.
Running the Program
To run the program in Visual Studio Code:

Open the terminal in Visual Studio Code.

Navigate to the directory containing Program.cs.

Execute the command:

bash
Copy code
dotnet run Program.cs
Follow the prompts to input the monthly income, total allowances, and total deductions when prompted.

Sample Output
Example of expected output after entering inputs:

yaml
Copy code
Enter monthly income: 30000
Enter total allowances: 5000
Enter total deductions: 2000

Monthly Income: $30,000.00
Total Allowances: $5,000.00
Total Deductions: $2,000.00
Taxable Income: $23,000.00
PAYE Tax Amount: Taxable Income * Tax Rate
PAYE Tax Amount: $3,400.00