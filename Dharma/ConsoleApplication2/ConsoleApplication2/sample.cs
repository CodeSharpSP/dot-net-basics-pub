using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class sample
    {
        public static void Main(String[] args)
        {
            Console.Write("enter the row count:{0}\n");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the column count:{0}\n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a=new int[m,n];
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.Write("Enter the value of {0}{0}:\n", i, j);
                }
            }



           


        }


    }
}
