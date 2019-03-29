using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleATMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ulong cardno = 23232345678927;
            int pinno = 1234;
            int givenpin;
            int choice;
            int newpin;
            int amount = 1000;
            int reqamt;
            Console.WriteLine("Enter your 14 digit card number and then press enter");
            ulong givencardno = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Enter your pin number");
            givenpin = int.Parse(Console.ReadLine());
            if (givenpin == pinno)
            {
                Console.WriteLine("select your language \n 1. Tamil \n 2. English");
                Console.WriteLine("Insert you option and press enter");
                int option = int.Parse(Console.ReadLine());
                if (option == 2)
                {
                    Console.WriteLine("1.withdraw\n2.change password\n3.check balance");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine("Enter amount to withdraw in 100 Multiples");
                            reqamt = int.Parse(Console.ReadLine());
                            if (reqamt > amount)
                            {
                                Console.WriteLine("Your account balance is too low to withdraw");
                            }
                            else
                            {
                                if (reqamt % 100 == 0)
                                {
                                    Console.WriteLine("Collect your cash");
                                }
                                amount = amount - reqamt;
                            }
                            
                            break;

                        case 2:
                            Console.WriteLine("Enter your new pin");
                            newpin = int.Parse(Console.ReadLine());
                            Console.WriteLine("Confirm your new pin");
                            int confrmpin = int.Parse(Console.ReadLine());
                            if (confrmpin == newpin)
                            {
                                Console.WriteLine("Your password changed succesfully");
                            }
                            else
                            {
                                Console.WriteLine("Password does not match");
                            }
                           
                            break;

                        case 3:
                            Console.WriteLine("Your account balance is {0}", amount);
                            break;
                    }
                    Console.WriteLine("Thanks for you transaction");
                }
            }
            Console.ReadLine();

        }
    }
}
