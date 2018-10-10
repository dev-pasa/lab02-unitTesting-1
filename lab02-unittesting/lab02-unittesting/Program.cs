using System;

namespace lab02_unittesting
{
    class Program
    {
        public static double balance = 3000;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Beck's Best Bank!");
            Console.WriteLine("Please select from the following options:");
            Console.WriteLine("     1 -- View Balance");
            Console.WriteLine("     2 -- Withdraw");
            Console.WriteLine("     3 -- Deposit");
            Console.WriteLine("     4 -- Exit");
            Console.Write("Enter your selection [1,2,3,4]: ");
            int userSelect = Int32.Parse(Console.ReadLine());

            switch (userSelect)
            {
                case 1:
                    Console.WriteLine("Your account balance is ${0}", balance);
                    break;
                case 2:
                    Console.WriteLine("Enter the amount of your withdrawal: ");
                    double moneyOut;
                    Double.TryParse(Console.ReadLine(), out moneyOut);
                    Console.WriteLine("Your new balance is ${0}", Withdraw(moneyOut));
                    break;
                case 3:
                    Console.WriteLine("Enter the amount of your deposit: ");
                    double moneyIn;
                    Double.TryParse(Console.ReadLine(), out moneyIn);
                    Console.WriteLine("Your new balance is ${0}", Deposit(moneyIn));
                    break;

            }
        }

        static double Withdraw(double moneyOut)
        {
            return balance -= moneyOut;
        }

        static double Deposit(double moneyIn)
        {
            return balance += moneyIn;
        }


    }
}
