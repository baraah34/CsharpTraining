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


        }
    }
    }
