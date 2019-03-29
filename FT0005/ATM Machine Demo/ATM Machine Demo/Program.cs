using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM_Machine_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            String Cardnumber, pin;
            long amount = 1000, deposit, withdraw;
            int option; 
            Sam:
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
                    Console.WriteLine("Please Choose your language is English");
                    goto Sam;
                   
            }
            Start:
            print:
            Console.WriteLine("Enter Your  Card Number");
            Cardnumber = Console.ReadLine();
            if (Cardnumber.Length == 14)
            {
                label:
                Console.WriteLine("Enter your pin Number");
                pin = Console.ReadLine();
                if (pin.Length == 4)
                {
                    while (true)
                    {

                        Console.WriteLine("SEE YOUR OPTION");
                        Console.WriteLine("1.Withdraw");
                        Console.WriteLine("2.Change the pin");
                        Console.WriteLine("3.Deposit");
                        Console.WriteLine("4.Check balance");
                        Console.WriteLine("Select Your option");
                        option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("ENTER THE AMOUNT TO WITHDRAW ");
                                withdraw = int.Parse(Console.ReadLine());
                                if (withdraw % 100 != 0)
                                {
                                    Console.WriteLine(" PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100:\n");
                                }

                                else if (withdraw > (amount - 500))
                                {
                                    Console.WriteLine("INSUFFICENT BALANCE:\n");
                                }

                                else
                                {
                                    amount = amount - withdraw;
                                    Console.WriteLine("PLEASE COLLECT CASH ");
                                    Console.WriteLine("YOUR CURRENT BALANCE IS {0}:", amount);
                                }
                                break;
                            case 2:
                                Console.WriteLine("Enter the new pin number ");
                                String pin1 = Console.ReadLine();
                                if (pin != pin1 && pin1.Length==4)
                                {
                                    pin = pin1;
                                }
                                break;
                            case 3:
                                Console.WriteLine("ENTER THE AMOUNT TO Deposit: ");
                                deposit = int.Parse(Console.ReadLine());
                                if (deposit % 100 != 0)
                                {
                                    Console.WriteLine("PLEASE DEPOSIT IN MULTIPLES OF 100");

                                }
                                else
                                {
                                    amount = amount + deposit;
                                    Console.WriteLine("YOUR BALANCE IS {0}", amount);


                                }
                                break;
                            case 4:
                                Console.WriteLine("check balance is " + amount);

                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("This is invalid pin Number");
                    goto label;
                }
            }
            else
            {
                Console.WriteLine("This is invalid Card Number");
                goto print;
            }
        }
    }
}
