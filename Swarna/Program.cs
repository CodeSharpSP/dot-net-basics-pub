using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ulong password = 12345678912345;
            ulong givenpwd;
            int amount = 5000;
            Console.WriteLine("Enter your digit card number and then press enter");
            givenpwd = ulong.Parse(Console.ReadLine());
            if(givenpwd==password)
            {

                Console.WriteLine("Select your language");
                Console.WriteLine("1.Tamil");
                Console.WriteLine("2.English");
                Console.WriteLine("Input your option and press enter");
                int choice=int.Parse(Console.ReadLine());
                if(choice==2)
                {
                    Console.WriteLine("1.withdraw \n 2. change password 3.Check balance");
                    Console.WriteLine("Insert your option and press enter");
                    int option=int.Parse(Console.ReadLine());
                    if(option==1)
                    {
                        Console.WriteLine("Emter amount to withdraw");
                        int givenamt = int.Parse(Console.ReadLine());
                        if(givenamt>=5000)
                        {

                            Console.WriteLine("Your account balance too low to withdraw");
                        }
                        else
                        {
                            amount = amount - givenamt;
                            Console.WriteLine("Please collect cash");
                        }
                    }
                    if(option==2)
                    {
                        Console.WriteLine("Change password");
                        ulong newpwd = ulong.Parse(Console.ReadLine());
                        Console.WriteLine("Password changed succesfully");
                    }
                    
                    if(option==3)
                    {
                        Console.WriteLine("Check balance in your account{0}",amount);
                    }

                }
            }
            else
            {
                Console.WriteLine("Please enter correct digit card number");
            }

            Console.ReadLine();
        }
    }
}
