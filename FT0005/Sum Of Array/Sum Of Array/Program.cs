using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum_Of_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of element in array \n");
            n = int.Parse(Console.ReadLine());
            int[] Array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the Array Element \n");
                Array[i] = Convert.ToInt16(Console.ReadLine());
            }
            int Sum = 0;
            for (int i = 0; i < n; i++)
            {
                Sum += Array[i];
            }
            Console.Write("The Sum of Array \n" + Sum);
            Console.Write("\n");
            int Avg;
            Avg = Sum / n;
            Console.Write("The Average of Array \n" + Avg);
            Console.Write("\n"); 
            int max = Array[0];
            for(int i=1;i<n;i++)
            {
                
                    if(max<Array[i])
                    {
                        max=Array[i];
                    }
                }
                Console.Write("The maximun number of Array \n"+max);
                Console.Write("\n");
                int min = Array[0];
                for (int i = 1; i < n; i++)
                {

                    if (min > Array[i])
                    {
                        min = Array[i];
                    }
                }
                Console.Write("The minimun number of Array \n" + min);

            Console.ReadLine();
        }
    }
}
