using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_clollection_values
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("No of values going to enter : ");
                int count = 0;
                int max = int.Parse(Console.ReadLine());
                List<int> intList = new List<int>();
                Console.WriteLine("Please enter the integer values");

                for (int i = 0; i < max; i++)
                {
                    int input = int.Parse(Console.ReadLine());
                    intList.Add(input);
                }
                Console.WriteLine("Processing inputs");

                for (int i = 0; i < intList.Count; i++)
                {
                    for (int j = 0; j < intList.Count; j++)
                    {
                        int add = intList[i] + intList[j];
                        if (intList.Exists(p => p.Equals(add)))
                        {
                            Console.WriteLine(intList[i] + " + " + intList[j] + " = " + add);
                            count++;
                        }
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("No Results found");
                }
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
