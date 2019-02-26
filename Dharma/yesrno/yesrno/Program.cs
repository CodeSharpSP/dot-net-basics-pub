using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yesrno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st num:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd num:");
            int n = int.Parse(Console.ReadLine());
            int o=m+n;
            Start:
            Console.WriteLine("Do you want print again yes or no:");
            String choice = Console.ReadLine();
            switch(choice)
            {
                case "yes":
                    Console.WriteLine("This is statement 1 : {0}", o);
                    Console.WriteLine("This is statement 2 : {0}", o);
                    Console.WriteLine("This is statement 3 : {0}", o);
                    goto Start;
                case "no":
                    break;  
                default:
                    Console.WriteLine("your choice {0} is invalid.Please Try Again...",choice);
                    goto Start;
            }
            Console.ReadLine();
        }
    }
}


