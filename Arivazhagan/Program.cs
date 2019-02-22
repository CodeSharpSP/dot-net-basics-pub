using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArivuFirstConsoleApp
{
        class Program
        {
            static string a = "";
            static void Main(string[] args)
            {

                for (int i = 0; i <= 2; i++)
                {

                    string[] Sample = { "This is Sample statement 1", "This is Sample statement 2", "This is Sample statement 3" };
                    a = Sample[i];
                    Console.WriteLine(a);

                }
                for (;;)
                {
                    Console.WriteLine("Do you Want print again Yes or No");

                    string Input = Console.ReadLine();

                    if (Input == "yes")
                    {
                        a = "";
                        for (int i = 0; i <= 2; i++)
                        {

                            string[] Sample = { "This is Sample statement 1", "This is Sample statement 2", "This is Sample statement 3" };
                            a = Sample[i];
                            Console.WriteLine(a);

                        }

                    }
                    else
                    {
                        Console.WriteLine("Press Any Key to Exit");
                        break;
                    }

                }

                Console.Read();
            }
        }
    }


