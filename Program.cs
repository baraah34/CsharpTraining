using System;

namespace CsharpTraining
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //declare all variable
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

            // setup menu numbered 1–13

            Console.WriteLine("1) Account Number : ");
            Console.WriteLine("2) Holder Name : ");
            Console.WriteLine("3) Balance :   OMR");
            Console.WriteLine("4) Account Active? :   [enter 1=yes / 0=no]");
            Console.WriteLine("5) Account Type : [enter S / C / F]");
            Console.WriteLine("--- Customer Profile ---");
            Console.WriteLine("6) Employed? : [enter 1=yes / 0=no]");
            Console.WriteLine("7) Monthly Salary :  OMR");
            Console.WriteLine("8) Credit Score  : ");
            Console.WriteLine("9) Age  : ");
            Console.WriteLine("--- Transaction Data ---");
            Console.WriteLine("10) Last Deposit Amount :  OMR");
            Console.WriteLine("11) Last Withdrawal : ");
            Console.WriteLine("12) Annual Interest Rate : ");
            Console.WriteLine("13) Avg Monthly Balance :  OMR");
            Console.WriteLine("0) Setup complete — launch Main Menu");

            //MAIN SETUP LOOP
            bool ii = true;
            while (ii)
            {
                Console.Write("  Select option: ");



                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":

                        Console.Write(" Enter account number: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Account number set to: " + accountNumber);
                        break;

                    case "2":

                        Console.Write(" Enter holder name: ");
                        holderName = Console.ReadLine();
                        Console.WriteLine(" Holder name set to: " + holderName);
                        break;

                    case "3":

                        Console.Write(" Enter balance (OMR): ");
                        balance = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Balance set to: " + balance + " OMR");
                        break;

                    case "4":

                        Console.Write(" Enter status (1 for yes / 0 for no): ");
                        isActive = Console.ReadLine() == "1";
                        Console.WriteLine(" Status set to: " + isActive);
                        break;

                    case "5":

                        Console.Write(" Enter account type (S/C/F): ");
                        accountType = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine(" Account type set to: " + accountType);
                        break;

                    case "6":

                        Console.Write(" Enter 1 if employed / 0 if not: ");
                        isEmployed = Console.ReadLine() == "1";
                        Console.WriteLine(" Employment status set to: " + isEmployed);
                        break;

                    case "7":

                        Console.Write(" Enter monthly salary: ");
                        salary = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Salary set to: " + salary + " OMR");
                        break;

                    case "8":


                        Console.Write(" Enter credit score: ");
                        creditScore = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Credit score set to: " + creditScore);
                        break;

                    case "9":

                        Console.Write(" Enter age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Age set to: " + age);
                        break;

                    case "10":


                        Console.Write(" Enter last deposit amount: ");
                        deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Deposit set to: " + deposit+ " OMR");
                        break;

                    case "11":


                        Console.Write(" Enter last withdrawal amount: ");
                        withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Withdrawal set to: " + withdrawal + " OMR");
                        break;

                    case "12":


                        Console.Write(" Enter annual interest rate : ");
                        annualRate = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Interest rate set to: " + annualRate);
                        break;

                    case "13":

                        Console.Write(" Enter avg monthly balance: ");
                        avgBalance = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Avg balance set to: " + avgBalance + " OMR");
                        break;

                    case "0":

                        Console.WriteLine(" Setup complete. Launching Main Menu...");
                        ii = false;//to stop loop
                        break;
                        
                    default:
                        Console.WriteLine("Invalid option. Please choose 1-13 or 0 to finish.");
                        break;
                }
            }
        }
    }
}

   
