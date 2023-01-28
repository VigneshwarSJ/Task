using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task2
{
    internal class Tables2b //task2b
    {
        public static void Main()
        {
            int N;
            Console.WriteLine("Enter The number");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {

                Console.WriteLine(N + "*" + i + "=" + N * i);
            }


        }
    }
}
