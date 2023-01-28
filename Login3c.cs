using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal class Login3c
    {
        string eMail = "vignesh@gmail.com";
        string passWord = "Vinsmoke@24";
        string memID = "sj24";
        int memPin = 1083;
        long mobNo = 9585495973;
        int mobPin = 1083;
        public void UserCheck(string s1, string s2)
        {
            if (s1 == eMail && s2 == passWord)
            {
                Console.WriteLine("Welcome " + eMail);
            }
            else
            {
                Console.WriteLine("Invalid email or password");
            }
        }
        public void UserCheck(string s1, int i1)
        {
            if (s1 == memID && i1 == memPin)
            {
                Console.WriteLine("Welcome " + memID);
            }
            else
            {
                Console.WriteLine("Invalid Membership ID or Mpin");
            }

        }
        public void UserCheck(long l1, int i1)
        {
            if (l1 == mobNo && i1 == mobPin)
            {
                Console.WriteLine("Welcome " + mobNo);
            }
            else
            {
                Console.WriteLine("Invalid mobile number or mpin");
            }
        }
        public static void Main()
        {
            Login3c obj = new();
            Console.WriteLine("Press 1 to login with Email and password");
            Console.WriteLine("Press 2 to login with Membership ID and Mpin");
            Console.WriteLine("Press 3 to login with Mobile No and Mpin");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1:
                    Console.WriteLine("Enter Email");
                    string eMail = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    string passWord = Console.ReadLine();
                    obj.UserCheck(eMail, passWord);
                    break;
                case 2:
                    Console.WriteLine("Enter Membership ID");
                    string memID = Console.ReadLine();
                    Console.WriteLine("Enter Mpin");
                    int mpin = Convert.ToInt32(Console.ReadLine());
                    obj.UserCheck(memID, mpin);
                    break;
                case 3:
                    Console.WriteLine("Enter Mobile number");
                    long mNo = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter Mpin");
                    int mPIN = Convert.ToInt32(Console.ReadLine());
                    obj.UserCheck(mNo, mPIN);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;


            }

        }
    }
}
