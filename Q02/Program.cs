using System;

namespace Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            decimal accountBalance;
            decimal withdrawalAmount;

            Console.WriteLine(">> WELCOME TO THE CTU SIMPLE ATM SYSTEM <<");
            Console.WriteLine();

            // Name validation 
            do
            {
                Console.Write("Hi! What is your name? ");
                userName = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(userName))
                {
                    Console.WriteLine("Name cannot be empty!");
                }

            } while (string.IsNullOrWhiteSpace(userName));

            Console.WriteLine();
            Console.WriteLine("WELCOME " + userName.ToUpper());
            Console.WriteLine();

            // PIN Authentication 
            int correctPin = 1234;
            Console.Write("Enter your PIN: ");
            int enteredPin;

            while (!int.TryParse(Console.ReadLine(), out enteredPin) || enteredPin != correctPin)
            {
                Console.Write("Incorrect PIN. Try again: ");
            }

            Console.WriteLine("Access Granted!");
            Console.WriteLine();

            // Account balance validation
            Console.Write("Please enter your current account balance: ");
            while (!decimal.TryParse(Console.ReadLine(), out accountBalance) || accountBalance < 0)
            {
                Console.Write("Invalid input! Enter a valid balance: ");
            }

            // Withdrawal validation
            Console.Write("Please enter the amount you wish to withdraw: ");
            while (!decimal.TryParse(Console.ReadLine(), out withdrawalAmount) ||
                   withdrawalAmount <= 0 ||
                   withdrawalAmount > accountBalance)
            {
                Console.Write("Insufficient amount, Please try again: ");
            }

            // Balance calculation after withdrawal
            decimal newBalance = accountBalance - withdrawalAmount;

            Console.WriteLine();
            Console.WriteLine("Withdrawal successful!");

            // Receipt Output
            Console.WriteLine("======= TRANSACTION RECEIPT =======");
            Console.WriteLine("Name: " + userName);
            Console.WriteLine("Transaction: Withdrawal");
            Console.WriteLine("Amount Withdrawn: " + withdrawalAmount.ToString("0.00"));
            Console.WriteLine("Updated Balance: " + newBalance.ToString("0.00"));
            Console.WriteLine("Date: " + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"));

            Console.WriteLine("===================================");
            Console.WriteLine("Thank you for using the CTU Simple ATM System!");
        }
    }
}