using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tasks.Task1
{
    internal class TravelCheck //Task1b
    {
        public static void Main()
        {
            string out1, out2, out3;
            Console.WriteLine("Do you have travel history?");
            out1 = Console.ReadLine();
            if (out1 == "yes")
            {
                Console.WriteLine("Do you have Temperature");
                out2 = Console.ReadLine();
                if (out2 == "yes")
                {
                    Console.WriteLine("Do you have cough or sneeze?");
                    out3 = Console.ReadLine();
                    if (out3 == "yes")
                    {
                        Console.WriteLine("Swab test");
                    }
                    else
                    {
                        Console.WriteLine("Quarantine, Fever Medicine");
                    }
                }
                else
                {
                    Console.WriteLine("Home Quarantine for 28 days");
                }
            }
            else
            {
                Console.WriteLine("Safe. Not Covid");
            }
        }
    }
}
