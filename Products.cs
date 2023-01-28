using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task2
{
    internal class Products //task2e
    {
        public static void Main()
        {
            string[][] prod1 = new string[3][];
            prod1[0] = new string[3] { "A", "Buiscuits", "There are 4 items" };
            prod1[1] = new string[3] { "B", "Chocolates", "There are 5 items" };
            prod1[2] = new string[3] { "C", "Drinks", "There are 6 items" };
            for (int i = 0; i < prod1.Length; i++)
            {
                for (int j = 0; j < prod1[i].Length; j++)
                {
                    Console.Write(prod1[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
