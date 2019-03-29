using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            print:
            Console.WriteLine("Enter your collection size");
            int size = int.Parse(Console.ReadLine());
            int[] A = new int[size];
            if (size > 5)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter the element one by one{0} \n", i);
                    A[i] = Convert.ToInt32(Console.ReadLine());

                }
            }
            else
            {
                Console.Write("invalid \n");
                goto print;
            }
            Console.WriteLine("Those CollectionLists is");
            List<int> colectionList = new List<int>(A);
            foreach (var num in colectionList)
            {
                Console.WriteLine(num);
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    sum = A[i] + A[j];
                    if (colectionList.Contains(sum))
                    {
                        Console.WriteLine("Pair with given sum " +
                                      sum + " is (" + A[i] +
                                           ", " + A[j] + ")");
                    }
                }
            }
            Console.ReadLine();
        } 
    }
}
