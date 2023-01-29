using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Day4
{

    abstract class Calc
    {
        public abstract void add(int n1, int n2);
        public abstract void sub(int n1, int n2);
        public abstract void mul(int n1, int n2);
        public abstract void div(int n1, int n2);
    }

    class ArithOper : Calc
    {
        public override void add(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("num 1 + num 2 is : {0} ", res);
        }
        public override void sub(int n1, int n2)
        {
            int res = n1 - n2;
            Console.WriteLine("num 1 - num 2 is : {0} ", res);
        }
        public override void mul(int n1, int n2)
        {
            int res = n1 * n2;
            Console.WriteLine("num 1 * num 2 is : {0} ", res);
        }
        public override void div(int n1, int n2)
        {
            int res = n1 / n2;
            Console.WriteLine("num 1 / num 2 is : {0} ", res);
        }
        internal class AbsCalc4b
        {
            public static void Main(string[] args)
            {
                ArithOper obj = new ArithOper();
                Console.WriteLine("Enter n1:");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter n2:");
                int n2 = Convert.ToInt32(Console.ReadLine());
                obj.add(n1, n2);
                obj.sub(n1, n2);
                obj.mul(n1, n2);
                obj.div(n1, n2);

            }
        }
    }
}
