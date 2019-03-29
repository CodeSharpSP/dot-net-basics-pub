using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            char res;
            do
            {
                Console.WriteLine("This is sample statement 1");
                Console.WriteLine("This is sample statement 2");
                Console.WriteLine("This is sample statement 3");
                Console.WriteLine("Press Y to continue N to exit");
                res = Char.Parse(Console.ReadLine());
                if(res.Equals('n'))
                {
                    Console.WriteLine("End");
                }
            } while (res.Equals('y'));
            
            Console.ReadLine();

        }
    }
}
