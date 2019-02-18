
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_char
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Swarnalakshmi";
            char[] chararray = sentence.ToCharArray();
            foreach(char c in chararray)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();

               
        }
    }
}
