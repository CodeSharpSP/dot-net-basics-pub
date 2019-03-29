using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 5000;
            int deposit = 0;
            Console.WriteLine("1.English");
            Console.WriteLine("2.Tamil");
            Console.WriteLine("Select your language ");
            int language = int.Parse(Console.ReadLine());
            switch (language)
            {
                case 1:
                    Console.WriteLine("Please Welcome");
                    Console.WriteLine();
                    goto Start;
                case 2:
                    Console.WriteLine("Please Welcome");
                    Console.WriteLine();
                    break;
            }
        Start:
            Console.WriteLine("Enter your ATM Pin Number");
            int pin_no = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("1.deposit_amount");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Check_balance");
                Console.WriteLine();
                Console.WriteLine("These are the Available services");
                int choice =int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("please enter the amount");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("deposited amount is {0}", amount);
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount:");
                        int Withdraw = int.Parse(Console.ReadLine());
                        if (Withdraw < amount)
                        {
                            amount = amount - Withdraw;
                            Console.WriteLine("current balance is {0}:", amount);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Widthdraw amount must lesser than already available amount");
                        }
                        break;
                    case 3:
                        Console.WriteLine("your balance is {0}:", amount);
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}
