using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array value :");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            Console.Write("Enter the size of an array :");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter value of index{0} ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("sum of the array :{0}", sum);
            int avg = sum / n;
            Console.WriteLine("average element of array:{0}", avg);
            int min = a[0];
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Minimum element is :{0}", min);
            Console.WriteLine("Maximum element is :{0}", max);
            Console.ReadLine();
        }
    }
}
