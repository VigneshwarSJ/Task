using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task2
{
    internal class StudentArr  //Task2d
    {
        public static void Main()
        {
            int[] marks1 = new int[5];
            float sum = 0;
            float per = 0;
            Console.WriteLine("Enter 5 subjects marks:");
            for (int i = 0; i < 5; i++)
                marks1[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++)
                sum += marks1[i];
            Console.WriteLine("Total is:" + sum);
            per = sum / 5;
            Console.WriteLine("Percentage is:" + per);

        }
    }
}
