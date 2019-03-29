using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleCarParking
{

    class Program
    {
      
        public static void CarinOut()
        {
            string[] Rever = new string[] { };
            int LineCount = 1;
            Console.Write("\n"+"Enter Number of Cars :  ");
            int Input = int.Parse(Console.ReadLine());
            
            ArrayList Carinput = new ArrayList();
            for (int i = 0; i <= Input-1; i++)
            {
                i += 1;
                Console.Write(i+" Enter Car num : ");
                Carinput.Add(Console.ReadLine());
                i -= 1;
                for (int j = i; j <= i; j++)
                {
                    Console.Write("Driver Name : ");
                    Carinput.Add(Console.ReadLine());
                }
            }
            
            Queue Cars = new Queue();
            for(int k=0;k<Carinput.Count;k++)
            {
                Cars.Enqueue(Carinput[k]);
            }

            int a = Cars.Count;

            Console.WriteLine("\n" + " Car Parking First To Last "+"\n");
           
            for (int i = 1; i <= a; i++)
            {
                Console.Write("   " + Cars.Dequeue());
                if (LineCount == 2)
                {
                    Console.WriteLine("\n");
                    LineCount = 0;
                }
                LineCount++;
            }

            Stack SecondOut = new Stack();
            
            for(int l=0;l<Carinput.Count;l++)
            {
                SecondOut.Push(Carinput[l]);
                
            }
       

            int Sw = SecondOut.Count;
            Console.WriteLine("\n"+"Second output"+"\n");
            for(int j=1;j<=Sw;j++)
            {
                Console.Write(" "+SecondOut.Pop());
                if (LineCount == 2)
                {
                    Console.WriteLine("\n");
                    LineCount = 0;
                }
                LineCount++;

            }
        }

        static void Main(string[] args)
        {
             CarinOut(); 
             Console.Read();
        }
    }
}
