using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    class baseClass

    {
        public void calculateVAT(double price)
        {
            double VAT = 0.2;
            Console.WriteLine("Price is " + price);
            Console.WriteLine("VAT: " + price * VAT);
            Console.WriteLine("Price with VAT is " + (price + price * VAT));
        }

    }
    class derivedClass : baseClass

    {
        public void calculateGST(double price)
        {
            double GST = 0.12;
            Console.WriteLine("Price is " + price);
            Console.WriteLine("GST: " + price * GST);
            Console.WriteLine("Price with GST is " + (price + price * GST));

        }
    }
    internal class Tax_task3b
    {
        public static void Main()
        {
            Console.WriteLine("Enter Price ");
            double price;
            price = Convert.ToInt32(Console.ReadLine());
            derivedClass dc = new derivedClass();
            //  baseClass bc= new derivedClass();
            dc.calculateVAT(price);
            dc.calculateGST(price);
        }

    }
}
