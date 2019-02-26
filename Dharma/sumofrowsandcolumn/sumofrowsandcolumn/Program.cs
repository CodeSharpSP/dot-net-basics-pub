using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumofrowsandcolumn
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, n;
            Console.WriteLine("enter the row size:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the column size:");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            int[] sum_of_rows = new int[m];
            int[] sum_of_columns = new int[n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("enter the input [{0}],[{1}]:", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < n; i++)
            {
                sum_of_rows[i] = 0;
                for (j = 0; j < n; j++)
                    sum_of_rows[i] = sum_of_rows[i] + a[i, j];
            }
            for (i = 0; i < n; i++)
            {
                sum_of_columns[i] = 0;
                for (j = 0; j < n; j++)
                {
                    sum_of_columns[i] = sum_of_columns[i] + a[j, i];
                }
            }
            Console.WriteLine("The given matrix is:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}  ", a[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Sum of rows :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}  ", sum_of_rows[i]);
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Sum of column:");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}  ", sum_of_columns[j]);
                }
                Console.ReadLine();
            }
        }
    }
}



