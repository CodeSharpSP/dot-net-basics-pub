 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppConsole
{
    class AccNum
    {
        public static int InitialAmount = 50000;
        public static string Password="Welcome@123" ;
        
        public static int EnterNumber()
        {
            
            Console.WriteLine("\n"+"Enter  14 Digits Number");
            long AccNumber = long.Parse(Console.ReadLine());
            string LengthofAccNum = AccNumber.ToString();
            int TotalLength = LengthofAccNum.Length;
            return TotalLength;
        }

        public static void SelectLanguage()
        {

            string[] Langauge = new string[] {"TAMIL","ENGLISH"};
            Console.WriteLine("\n"+"Please Select the LANGUAGE");
            foreach(var a in Langauge)
            {
                Console.WriteLine("\n"+a);
               
            }  
        x:
            Console.WriteLine("\n"+"input is your option and Enter");
            int Value = int.Parse(Console.ReadLine());
            if (Value == 1)
            {
                Console.WriteLine("\n" + "Your Langauge is " + Langauge[0]);
                VerifyPassword();
            }
            if (Value == 2)
            {
                Console.WriteLine("\n"+"Your Langauge is "+Langauge[1]);
                VerifyPassword();
            }
       
            else
            {
                Console.WriteLine("\n"+"Enter Valid Language");
                goto x;
            }
        }

        public static void VerifyPassword()
        {
        
            Console.WriteLine("\n"+"Enter Password");
            Y:
                string Pass = Console.ReadLine();
           
                if (Password==Pass)
                {
                    MenuDetials();
                }
                else
                {
                    Console.WriteLine("\n"+"Please Enter Correct Password");
                    goto Y;
                }
           
        }
        
       
        public static void MenuDetials()
        {
            string[] Menu = new string[] {"1.WithDraw","2.ChangePassword","3.check Balance"};
            foreach(var c in Menu)
            {
                Console.WriteLine("\n"+c);
            }
            
            Console.WriteLine("\n"+"input is your option and Enter");
            for(int i=0;i<=2;i++)
            {
                int Input = int.Parse(Console.ReadLine());
                if (Input == 1)
                {
                    Console.WriteLine("\n"+"Enter amount");
                    withDraw();
                    Console.WriteLine("\n" + "Press any Key to exit");
                    break;
                }
                if (Input == 2)
                {
                    Console.WriteLine("\n"+"Change Password");
                    ChangePassword();
                    Console.WriteLine("\n" + "Press any Key to exit");
                    break;
                }
                if (Input == 3)
                {
                    CheckBalance(InitialAmount);
                    Console.WriteLine("\n" + "Press any Key to exit");
                    break;
                }
                else
                {
                    Console.WriteLine("\n"+"Enter Valid Option");
                }
            }
        }
        public static void ChangePassword()
        {
            Console.WriteLine("\n"+"Enter old password");
            x:
            string VerKey = Console.ReadLine();
            if(Password==VerKey)
            {
                Console.WriteLine("\n"+"Enter new passWord");
                string Pass = Console.ReadLine();
                Password = Pass;
                Console.WriteLine("\n"+"Successfully Changed.");
                VerifyPassword();
              
            }
            else
            {
                Console.WriteLine("\n"+"Please enter Valid Password");
                goto x;
            }
        }
        public static int withDraw()
        {
            int WithDrawAmount = int.Parse(Console.ReadLine());
            InitialAmount = InitialAmount - WithDrawAmount;
            Console.WriteLine("\n"+"Successfully Debited");
            return InitialAmount;
        }
        public static void CheckBalance(int IAmount)
        {
            Console.WriteLine("\n"+"Your Account Balance is "+"\n"+IAmount);
        }

        static void Main(string[] args)
        {
            x:
            int a=EnterNumber();
            if(a==14)
            {
                SelectLanguage();
            }
            else
            {
                Console.WriteLine("\n"+"Your Entered "+a+" digits this Is Not Vaild");
                Console.WriteLine("\n"+"Please Enter Valid Number");
                goto x;
            }
           
            //MenuDetials();
            //Console.WriteLine(withDraw());
            Console.Read();
        }
    }
}
    



          