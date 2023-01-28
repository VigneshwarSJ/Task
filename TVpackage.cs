using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task2
{
    internal class TVpackage  //Task2c
    {
        public static void Main()
        {
            Console.WriteLine("Choose your package from A,B,C");
            string package1 = Console.ReadLine();
            switch (package1)
            {
                case "A":
                    Console.WriteLine("You have chosen Package A costs 250 Rs, channels including");
                    Console.WriteLine("South Special");
                    Console.WriteLine("Children's Club");
                    Console.WriteLine("Movies ");
                    break;

                case "B":
                    Console.WriteLine("You have chosen Package B costs 450 Rs, channels including");
                    Console.WriteLine("News");
                    Console.WriteLine("Sports");
                    Console.WriteLine("Movies ");
                    Console.WriteLine("Regional -2 ");
                    break;
                case "C":
                    Console.WriteLine("You have chosen Package C costs 350 Rs, channels including");
                    Console.WriteLine("News");
                    Console.WriteLine("History");
                    Console.WriteLine("National");
                    break;
                default:
                    Console.WriteLine("Choose between A,B and C");
                    break;
            }
        }
    }
}
