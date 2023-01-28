using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal class SimpleCalc  //Task3a
    {
        public void Add1(int a, int b)
        {
            Console.WriteLine("Addition is " + (a + b));
        }
        public void Sub1(int a, int b)
        {
            Console.WriteLine("Subtraction is " + (a - b));
        }
    }
    class SimpleCalc1 : SimpleCalc
    {
        public void Mul1(int a, int b)
        {
            Console.WriteLine("Multiplication is " + a * b);
        }
        public void Div1(int a, int b)
        {
            Console.WriteLine("Division is " + a / b);
        }
        public static void Main()
        {
            int choice;

            SimpleCalc1 obj = new SimpleCalc1();
            Console.WriteLine("Enter 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" For addition press 1\n For Subtraction press 2\n For Multiply press 3\n For Division press 4\n To serve all the 4 operations press 5");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.Add1(a, b);
                    break;
                case 2:
                    obj.Sub1(a, b);
                    break;
                case 3:
                    obj.Mul1(a, b);
                    break;
                case 4:
                    obj.Div1(a, b);
                    break;
                case 5:
                    obj.Add1(a, b);
                    obj.Sub1(a, b);
                    obj.Mul1(a, b);
                    obj.Div1(a, b);
                    break;
                default:
                    Console.WriteLine("choose between 1 to 4");
                    break;

            }

        }
    }
}
