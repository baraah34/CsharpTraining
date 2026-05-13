using System;

namespace CsharpTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare all variables
            int accountNumber = 0;
            string holderName = "";
            double balance = 0.000;
            bool isActive = false;
            char accountType = '-';
            bool isEmployed = false;
            double salary = 0.000;
            int creditScore = 0;
            int age = 0;
            double deposit = 0.000;
            double withdrawal = 0.000;
            double annualRate = 0.000;
            double avgBalance = 0.000;

            // Setup Menu
            Console.WriteLine("1) Account Number");
            Console.WriteLine("2) Holder Name");
            Console.WriteLine("3) Balance");
            Console.WriteLine("4) Account Active?");
            Console.WriteLine("5) Account Type");
            Console.WriteLine("--- Customer Profile ---");
            Console.WriteLine("6) Employed?");
            Console.WriteLine("7) Monthly Salary");
            Console.WriteLine("8) Credit Score");
            Console.WriteLine("9) Age");
            Console.WriteLine("--- Transaction Data ---");
            Console.WriteLine("10) Last Deposit Amount");
            Console.WriteLine("11) Last Withdrawal");
            Console.WriteLine("12) Annual Interest Rate");
            Console.WriteLine("13) Avg Monthly Balance");
            Console.WriteLine("0) Setup Complete");

            // Setup Loop
            bool ii = true;

            while (ii)
            {
                Console.Write("\nSelect option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter account number: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Account number set to: " + accountNumber);
                        break;

                    case "2":
                        Console.Write("Enter holder name: ");
                        holderName = Console.ReadLine();
                        Console.WriteLine("Holder name set to: " + holderName);
                        break;

                    case "3":
                        Console.Write("Enter balance: ");
                        balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance set to: " + balance + " OMR");
                        break;

                    case "4":
                        Console.Write("Enter status (1=yes / 0=no): ");
                        isActive = Console.ReadLine() == "1";
                        Console.WriteLine("Status set to: " + isActive);
                        break;

                    case "5":
                        Console.Write("Enter account type (S/C/F): ");
                        accountType = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Account type set to: " + accountType);
                        break;

                    case "6":
                        Console.Write("Enter employment status (1=yes / 0=no): ");
                        isEmployed = Console.ReadLine() == "1";
                        Console.WriteLine("Employment status set to: " + isEmployed);
                        break;

                    case "7":
                        Console.Write("Enter salary: ");
                        salary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Salary set to: " + salary + " OMR");
                        break;

                    case "8":
                        Console.Write("Enter credit score: ");
                        creditScore = int.Parse(Console.ReadLine());
                        Console.WriteLine("Credit score set to: " + creditScore);
                        break;

                    case "9":
                        Console.Write("Enter age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Age set to: " + age);
                        break;

                    case "10":
                        Console.Write("Enter deposit amount: ");
                        deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("Deposit set to: " + deposit + " OMR");
                        break;

                    case "11":
                        Console.Write("Enter withdrawal amount: ");
                        withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Withdrawal set to: " + withdrawal + " OMR");
                        break;

                    case "12":
                        Console.Write("Enter annual interest rate: ");
                        annualRate = double.Parse(Console.ReadLine());
                        Console.WriteLine("Interest rate set to: " + annualRate);
                        break;

                    case "13":
                        Console.Write("Enter average monthly balance: ");
                        avgBalance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Avg balance set to: " + avgBalance + " OMR");
                        break;

                    case "0":
                        Console.WriteLine("Setup complete. Launching Main Menu...");
                        ii = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

            // MAIN MENU LOOP
            bool mainMenu = true;

            while (mainMenu)
            {
                Console.WriteLine("\nNATIONAL BANK OF OMAN — Unified Banking System");
                Console.WriteLine("MAIN MENU");

                Console.WriteLine("1) ATM Services");
                Console.WriteLine("2) Account Management");
                Console.WriteLine("3) Loan Services");
                Console.WriteLine("4) Currency Exchange");
                Console.WriteLine("5) Credit Card Portal");
                Console.WriteLine("6) Branch Services");
                Console.WriteLine("7) Reports & Admin");
                Console.WriteLine("0) Exit");

                Console.Write("\nSelect Module: ");
                int c2 = int.Parse(Console.ReadLine());

                switch (c2)
                {
                    // ATM SERVICES
                    case 1:

                        bool atmMenu = true;

                        while (atmMenu)
                        {
                            Console.WriteLine("\n=== ATM SERVICES ===");

                            Console.WriteLine("1) Bank Info");
                            Console.WriteLine("2) View Account Data");
                            Console.WriteLine("3) PIN Validation");
                            Console.WriteLine("4) Receipt Printer");
                            Console.WriteLine("0) Back");

                            Console.Write("Select: ");
                            int AtmChoices = int.Parse(Console.ReadLine());

                            switch (AtmChoices)
                            {
                                // Bank Info
                                case 1:

                                    Console.WriteLine("=== ATM SERVICES === ");
                                    Console.WriteLine("1) Bank Info");
                                    Console.WriteLine("2) Branch Info");
                                    Console.WriteLine("3) Opening Hours");
                                    Console.WriteLine("0) Back To Main Menu");
                                    Console.Write("Select: ");
                                    int atmChoice1 = int.Parse(Console.ReadLine());
                                    switch (atmChoice1)
                                    {

                                        case 1:// Bank Information
                                            Console.WriteLine("National Bank Of Oman");
                                            Console.WriteLine("Your Trusted Banking Partner");
                                            Console.WriteLine(" Founding Year: 1973");
                                            break;
                                        case 2:// Branch Information
                                            Console.WriteLine("Muscat branch name ");
                                            Console.WriteLine(" city: Muscat");
                                            Console.WriteLine(" address: 18 Novmber Street");
                                            break;
                                        case 3:// Opening Hours
                                            Console.WriteLine("Weekdays: 8 AM - 2 PM");

                                            Console.WriteLine("Weekend: Closed");
                                            break;

                                        case 0:// Back To Main Menu
                                            Console.WriteLine("Returning to Main Menu...");
                                            break;
                                        default:
                                            Console.WriteLine("'Invalid selection. Please try again.");
                                            break;
                                    }

                                    break;

                                // View Account Data
                                case 2:

                                    Console.WriteLine("\n=== VIEW ACCOUNT DATA ===");

                                    Console.WriteLine("Account Number : " + accountNumber);
                                    Console.WriteLine("Holder Name    : " + holderName);
                                    Console.WriteLine("Balance        : " + balance.ToString("F3") + " OMR");
                                    Console.WriteLine("Status         : " + isActive);
                                    Console.WriteLine("Account Type   : " + accountType);

                                    break;

                                // PIN Validation
                                case 3:

                                    bool pinMenu = true;

                                    while (pinMenu)
                                    {
                                        Console.WriteLine("\n=== AUTHENTICATION ===");

                                        const int CORRECT_PIN = 4821;

                                        Console.WriteLine("1) Enter PIN");
                                        Console.WriteLine("2) Forgot PIN");
                                        Console.WriteLine("0) Back");

                                        Console.Write("Select: ");
                                        int PINS = int.Parse(Console.ReadLine());

                                        switch (PINS)
                                        {
                                            case 1:

                                                Console.Write("Enter PIN: ");
                                                string input = Console.ReadLine();

                                                if (input.Length != 4)
                                                {
                                                    Console.WriteLine("Invalid PIN format.");
                                                }
                                                else
                                                {
                                                    int enteredPin = int.Parse(input);

                                                    if (enteredPin == CORRECT_PIN)
                                                    {
                                                        Console.WriteLine("Access granted. Welcome " + holderName);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Incorrect PIN.");
                                                    }
                                                }

                                                break;

                                            case 2:

                                                Console.WriteLine("Please visit nearest branch with National ID.");
                                                break;

                                            case 0:

                                                Console.WriteLine("Returning to ATM Services...");
                                                pinMenu = false;
                                                break;

                                            default:

                                                Console.WriteLine("Invalid selection.");
                                                break;
                                        }
                                    }

                                    break;

                                // Receipt Printer
                                case 4:

                                    bool receiptMenu = true;

                                    while (receiptMenu)
                                    {
                                        Console.WriteLine("\n--- PRINT RECEIPT ---");

                                        Console.WriteLine("1) Short Receipt");
                                        Console.WriteLine("2) Detailed Receipt");
                                        Console.WriteLine("3) Balance Only");
                                        Console.WriteLine("0) Back");

                                        Console.Write("Select format: ");
                                        int receiptChoice = int.Parse(Console.ReadLine());

                                        switch (receiptChoice)
                                        {
                                            // Short Receipt
                                            case 1:

                                                string accountText = accountNumber.ToString();

                                                string maskedAccount =
                                                    accountText.Substring(0, 4) + "****";

                                                Console.WriteLine("\n--- SHORT RECEIPT ---");
                                                Console.WriteLine("Account : " + maskedAccount);
                                                Console.WriteLine("Holder  : " + holderName);
                                                Console.WriteLine("Balance : " + balance + " OMR");

                                                break;

                                            // Detailed Receipt
                                            case 2:

                                                Console.WriteLine("\n--- DETAILED RECEIPT ---");
                                                Console.WriteLine("Account Number : " + accountNumber);
                                                Console.WriteLine("Holder Name    : " + holderName);
                                                Console.WriteLine("Balance        : " + balance + " OMR");
                                                Console.WriteLine("Account Type   : " + accountType);
                                                Console.WriteLine("Account Active : " + isActive);

                                                break;

                                            // Balance Only
                                            case 3:

                                                Console.WriteLine("\n--- BALANCE ONLY ---");
                                                Console.WriteLine("Balance : " + balance + " OMR");

                                                break;

                                            // Back
                                            case 0:

                                                Console.WriteLine("Returning to ATM Services...");
                                                receiptMenu = false;
                                                break;

                                            default:

                                                Console.WriteLine("Invalid receipt format.");
                                                break;
                                        }
                                    }

                                    break;

                                // Back
                                case 0:

                                    Console.WriteLine("Returning to Main Menu...");
                                    atmMenu = false;
                                    break;

                                default:

                                    Console.WriteLine("Invalid ATM selection.");
                                    break;
                            }
                        }

                        break;

                    // Account Management
                    case 2:

                        Console.WriteLine("Account Management");
                        break;

                    // Loan Services
                    case 3:

                        Console.WriteLine("Loan Services");
                        break;

                    // Currency Exchange
                    case 4:

                        Console.WriteLine("Currency Exchange");
                        break;

                    // Credit Card Portal
                    case 5:

                        Console.WriteLine("Credit Card Portal");
                        break;

                    // Branch Services
                    case 6:

                        Console.WriteLine("Branch Services");
                        break;

                    // Reports & Admin
                    case 7:

                        Console.WriteLine("Reports & Admin");
                        break;

                    // Exit
                    case 0:

                        Console.WriteLine("Thank you for using National Bank Of Oman.");
                        mainMenu = false;
                        break;

                    default:

                        Console.WriteLine("Invalid Number");
                        break;
                }
            }
        }
    }
}