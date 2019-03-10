using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionListCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your collection size");
            int size = int.Parse(Console.ReadLine());
            int[] a=new int[size];
            Console.WriteLine("Enter your collection one by one:");
               for (int i = 0; i < size; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());  
                }
              Console.WriteLine("These are the CollectionLists");
             List<int> checkList = new List<int>(a);
             foreach (var num in checkList)
            {
                Console.WriteLine(num);
            }
             int sum = 0;
             for (int i = 0; i < size; i++)
             {
                 for (int j = i+1; j < size; j++)
                 {
                     sum = a[i] + a[j];
                     Console.WriteLine(checkList.Contains(sum));
                 }
             }
                  Console.ReadLine();
            }
       }
}


