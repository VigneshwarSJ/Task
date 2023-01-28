using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task2
{
    internal class AgenDisp  //task2a
    {
        public static void Main()
        {
            string name1;
            int age1 = 0;
            Console.WriteLine("Enter your name and age");
            name1 = Console.ReadLine();
            age1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < age1; i++)
                Console.WriteLine("Your name is {0}", name1);
        }
    }
}
