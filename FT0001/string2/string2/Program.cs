using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1, rev = "";
            int Length;
            Console.WriteLine("Enter a string");
            string1 = Console.ReadLine();
            if (string1.Length == 10)
            {
                Length = string1.Length - 1;
                while (Length >= 0)
                {
                    rev = rev + string1[Length];
                    Length--;
                }
                Console.WriteLine("reversed text {0}", rev);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter minimum of 10 letters of the text");
            }
            if(string1==rev)
            {
                Console.WriteLine("Yes same");
            }
            else
            {
                Console.WriteLine("Not same");
            }
        }
    }
}
