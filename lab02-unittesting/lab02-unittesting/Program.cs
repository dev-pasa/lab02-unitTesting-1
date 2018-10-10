using System;

namespace lab02_unittesting
{
    class Program
    {
        public static double balance = 3000;

        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
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
                        Console.WriteLine(Withdraw(moneyOut));
                        break;
                    case 3:
                        Console.WriteLine("Enter the amount of your deposit: ");
                        double moneyIn;
                        Double.TryParse(Console.ReadLine(), out moneyIn);
                        Console.WriteLine(Deposit(moneyIn));
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("Please select from the following options:");
                Console.WriteLine("     1 -- Go to Main Menu");
                Console.WriteLine("     4 -- Exit");
                int selection = Int32.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    selection = userSelect;
                   
                } else if (selection == 4)
                {
                    Environment.Exit(0);
                }
            }
            
        }

        static string Withdraw(double moneyOut)
        {
            if (moneyOut > balance)
            {
                return "Insufficent funds.";
            }

            balance += moneyOut;
            return $"New balance is ${balance}";
        }

        static string Deposit(double moneyIn)
        {
            if (moneyIn < 0)
            {
                return "Insufficient deposit amount.";
            }

            balance += moneyIn;
            return $"New balance is ${balance}";
        }


    }
}
