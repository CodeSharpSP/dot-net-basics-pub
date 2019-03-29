using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public static int amount = 12345;
        static string password = "Photon@123";
        public static void Userdetails()
        {
       X:   Console.Write("Enter your 12 digit card Number and press Enter : ");
            long AccNum = long.Parse(Console.ReadLine());
            if (AccNum.ToString().Length == 12)
            {
                SelectLanguage();
            }
            else
            {
                Console.WriteLine("Please enter the valid card number");
                goto X;
            }
        }
        public static void SelectLanguage()
        {
            int i = 1;
            Console.WriteLine("\n");
            Console.WriteLine("Languages");
            string[] lang = new string[] { "Tamil", "English" };
            foreach (string s in lang)
            {
                Console.WriteLine(i + "-" + s);
                i++;
            }
            Console.Write("Please select Yourlanguage and press enter : ");
            int choice = int.Parse(Console.ReadLine());           
            Console.WriteLine("You choosed " + lang[choice-1] + " language");
            Menudetails();
        }
        public static void Menudetails()
        {
            Console.WriteLine("\n");
            Console.WriteLine("choose the service you want");
            string[] menu = new string[] {"1-Withdraw","2-checkbalance","3-Change password" };
            foreach (string s in menu)
            {
                Console.WriteLine(s);
            }
            Console.Write("please select option and press enter :");
            int service = int.Parse(Console.ReadLine());
            switch (service)
            {
                case 1: withdraw();
                    break;
                case 2: checkbalance();
                    break;
                case 3: changepassword();
                    break;
            }
        }
        public static void withdraw()
        {           
            Console.WriteLine("\n");
            Console.Write("Please enter the amount : ");
            int WithdrawAmt = int.Parse(Console.ReadLine());
            if (WithdrawAmt > amount)
            {
                Console.WriteLine("Insufficient Amount");
            }
            else
            {
                amount = amount - WithdrawAmt;
                Console.WriteLine("Your current Amount : "+amount);
            }
        }

        public static void checkbalance()
        {
            Console.WriteLine("Available balance : "+amount);
        }

        public static void changepassword()
        {
            Console.WriteLine("Enter your old password : ");
            string oldpassword = Console.ReadLine();
            if (oldpassword == password)
            {
                Console.Write("Please enter your new password : ");
                string Newpassword = Console.ReadLine();
                password = Newpassword;
                Console.Write("password changed successfully");
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
        }
        static void Main(string[] args)
        {
            Userdetails();
            Console.Write("Do you want to continue (Y/N)");
            string key=(Console.ReadLine());
            if (key == "y")
                Menudetails();
            else
                Console.WriteLine("Thank you");
            Console.ReadKey();
        }
    }
}