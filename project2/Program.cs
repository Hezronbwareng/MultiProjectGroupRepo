using System;
using System.Collections.Generic;

class BankAccountManagementSystem
{
    static List<BankAccount> accounts = new List<BankAccount>();

    static void Main()
    {
        Console.WriteLine("Welcome to the Bank Account Management System!");

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Create a new account");
            Console.WriteLine("2. Make a deposit");
            Console.WriteLine("3. Make a withdrawal");
            Console.WriteLine("4. Check account balance");
            Console.WriteLine("5. Manage account");
            Console.WriteLine("6. Exit");

            int choice = GetChoice();

            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    MakeDeposit();
                    break;
                case 3:
                    MakeWithdrawal();
                    break;
                case 4:
                    CheckBalance();
                    break;
                case 5:
                    ManageAccount();
                    break;
                case 6:
                    Console.WriteLine("Exiting the Bank Account Management System. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }

    static int GetChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        return choice;
    }

    static void CreateAccount()
    {
        Console.Write("Enter your name: ");
        string accountHolderName = Console.ReadLine();

        Console.Write("Enter initial balance: $");
        double initialBalance = GetDoubleInput();

        // Generate a unique account number
        int accountNumber = GenerateAccountNumber();

        // Create a new account
        BankAccount newAccount = new BankAccount(accountNumber, accountHolderName, initialBalance);
        accounts.Add(newAccount);

        Console.WriteLine($"Account created successfully. Your account number is: {accountNumber}");
    }

    static void MakeDeposit()
    {
        Console.Write("Enter your account number: ");
        int accountNumber = GetChoice();

        BankAccount account = GetAccountByNumber(accountNumber);

        if (account != null)
        {
            Console.Write("Enter the deposit amount: $");
            double depositAmount = GetDoubleInput();

            account.Deposit(depositAmount);
            Console.WriteLine($"Deposit successful. Updated balance: ${account.Balance:F2}");
        }
    }

    static void MakeWithdrawal()
    {
        Console.Write("Enter your account number: ");
        int accountNumber = GetChoice();

        BankAccount account = GetAccountByNumber(accountNumber);

        if (account != null)
        {
            Console.Write("Enter the withdrawal amount: $");
            double withdrawalAmount = GetDoubleInput();

            if (account.Withdraw(withdrawalAmount))
            {
                Console.WriteLine($"Withdrawal successful. Updated balance: ${account.Balance:F2}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
        }
    }

    static void CheckBalance()
    {
        Console.Write("Enter your account number: ");
        int accountNumber = GetChoice();

        BankAccount account = GetAccountByNumber(accountNumber);

        if (account != null)
        {
            Console.WriteLine($"Your account balance is: ${account.Balance:F2}");
        }
        else{
            Console.WriteLine("The Account number does not exist");
        }
    }

    static void ManageAccount()
    {
        Console.Write("Enter your account number: ");
        int accountNumber = GetChoice();

        BankAccount account = GetAccountByNumber(accountNumber);

        if (account != null)
        {
            Console.WriteLine($"Account Information for Account Number {account.AccountNumber}:");
            Console.WriteLine($"Account Holder: {account.AccountHolderName}");
            Console.WriteLine($"Account Balance: ${account.Balance:F2}");

            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Update account information");
            Console.WriteLine("2. Delete account");
            Console.WriteLine("3. Back to main menu");

            int choice = GetChoice();

            switch (choice)
            {
                case 1:
                    UpdateAccountInformation(account);
                    break;
                case 2:
                    DeleteAccount(account);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Invalid option. Returning to main menu.");
                    break;
            }
        }
    }

    static void UpdateAccountInformation(BankAccount account)
    {
        Console.WriteLine("Update account information (press Enter to keep existing values):");

        Console.Write("Enter your name: ");
        string updatedName = Console.ReadLine();
        if (!string.IsNullOrEmpty(updatedName))
        {
            account.AccountHolderName = updatedName;
        }

        Console.Write("Enter new initial balance: $");
        string updatedBalanceInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(updatedBalanceInput))
        {
            double updatedBalance = Convert.ToDouble(updatedBalanceInput);
            account.Balance = updatedBalance;
        }

        Console.WriteLine("Account information updated successfully.");
    }

    static void DeleteAccount(BankAccount account)
    {
        accounts.Remove(account);
        Console.WriteLine("Account deleted successfully.");
    }

    static double GetDoubleInput()
    {
        double amount;
        while (!double.TryParse(Console.ReadLine(), out amount))
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric value.");
        }
        return amount;
    }

    static int GenerateAccountNumber()
    {
        // A simple method to generate a unique account number
        return accounts.Count + 1;
    }

    static BankAccount GetAccountByNumber(int accountNumber)
    {
        return accounts.Find(account => account.AccountNumber == accountNumber);
    }
}

class BankAccount
{
    public int AccountNumber { get; }
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }

    public BankAccount(int accountNumber, string accountHolderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}
