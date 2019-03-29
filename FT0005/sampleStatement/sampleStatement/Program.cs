using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Print:
            Console.Write("The Sample Statement is 1 \n");
            Console.Write("The Sample Statement is 2 \n");
            Console.Write("The Sample Statement is 3 \n");
            Console.Write("Enter Y ro N \n");
            char option = char.Parse(Console.ReadLine());
           if(option=='y')
            {
                goto Print;
            }
           else
            {
                Console.Write("Press any key to exit \n");
            }
            Console.ReadLine();

        }
    }
}








