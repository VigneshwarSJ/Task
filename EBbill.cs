using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task1
{
    internal class EBbill   //Task 1a
    {
        public static int Calc(int Units)
        {
            if (Units <= 200)
            {
                return Units * 2;
            }
            else if (Units <= 350)
            {
                return 200 * 2 + (Units - 200) * 3;
            }
            else if (Units <= 500)
            {
                return 200 * 2 + 150 * 3 + (Units - 350) * 5;
            }
            else if (Units > 500)
            {
                return 200 * 2 + 150 * 3 + 150 * 5 + (Units - 500) * 7;
            }
            return 0;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Units:");
            int Units = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your current consumption is {0} units and {1} Rs is your current bill", Units, Calc(Units));

        }
    }
}
