using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] SerialNo=new int[20];
            String[]  VehicleNo=new String[20];
            String[] DriverName = new String[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Enter the SerialNumber of vehicle \n");
                SerialNo[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the vehicle Number\n");
                VehicleNo[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Enter the DriverName \n");
                DriverName[i] = Convert.ToString(Console.ReadLine());
            }
            Console.Write("INCOMIG VEHICLE PARKING  \n");
                for(int i = 0; i < 20; i++)
                {
                    Console.Write(SerialNo[i] + "\t" + VehicleNo[i] + "\t" + DriverName[i]+"\n");
                  }
                Console.Write("OUT COMING DRIVER ORDER\n");
                foreach (string Driver in DriverName)
                {
                    Console.WriteLine(Driver);
                }
                Console.Write("VEHICLE PARKING ORDER \n");
                Array.Reverse(VehicleNo);
                foreach (string Number in VehicleNo)
                {
                    Console.WriteLine(Number);
                }

                Console.Read();
             
        }
    }
}
