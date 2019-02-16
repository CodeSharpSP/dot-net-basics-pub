using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[100];
            int n;
            Console.Write("enter the size of the array :\n");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter value of index{0} ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum=0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.Write("sum of the array :{0}\n", sum);
            int avg = sum / n;
            Console.Write("average element of array:{0}\n", avg);
            int min=a[0];
            int mx=a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min= a[i];
                }
                if (a[i] > mx)
                {
                    mx = a[i];
                }
            }
            Console.Write("Minimum element is :{0}\n", min);
            Console.Write("Maximum element is :{0}\n", mx);
            Console.ReadKey();
  }	
    }
}
