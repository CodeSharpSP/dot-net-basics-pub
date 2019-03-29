using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            int[,]  Array=new int[10,10];
            int[] Rowsum = new int[10];
            int[] Columnsum = new int[10];
            Console.Write("Enter the Size of Row \n");
            int Row = int.Parse(Console.ReadLine());
            Console.Write("Enter the Size of Column \n");
            int Column = int.Parse(Console.ReadLine());
            for( i=0;i<Row;i++)
            {
                for (j = 0; j < Column; j++)
                {
                    Console.Write("Enter the Array element - [{0}],[{1}] : ", i, j);
                    Array[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n Matrix Format is");
            for (i = 0; i < Row; i++)
            {
                for (j = 0; j < Column; j++)

                    Console.Write("{0} ", Array[i, j]);
                    Console.Write("\n");
            }
            for (i = 0; i < Row; i++)
            {
                Rowsum[i] = 0;
                for (j = 0; j < Row; j++)
                    Rowsum[i] = Rowsum[i] + Array[i, j];
            }


            for (i = 0; i < Column; i++)
            {
                Columnsum[i] = 0;
                for (j = 0; j < Column; j++)
                    Columnsum[i] = Columnsum[i] + Array[j, i];
            }

            Console.Write("The sum or rows and columns of the matrix is :\n");
            for (i = 0; i < Row; i++)
            {
                for (j = 0; j < Column; j++)
                    Console.Write("{0}    ", Array[i, j]);
                Console.Write("{0}    ", Rowsum[i]);
                Console.Write("\n");
            }
            Console.Write("\n");
            for (j = 0; j < Column; j++)
            {
                Console.Write("{0}   ", Columnsum[j]);
            }     
                
            
            Console.ReadLine();
        }
    }
}
