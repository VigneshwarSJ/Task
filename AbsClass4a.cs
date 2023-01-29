using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Day4
{
    abstract class member
    {
        public abstract void goldPack();
        public abstract void silverPack();

        public abstract void platinumPack();
    }

    class impPack : member
    {
        public override void goldPack()
        {
            Console.WriteLine("Gold pack contains five days accomodation at resort & two dinners on the house");

        }
        public override void silverPack()
        {
            Console.WriteLine("Silver pack contains three days accomodation at resort ");

        }
        public override void platinumPack()
        {
            Console.WriteLine("Platinum pack contains seven days accomodation at resort & five dinners on the house");

        }


    }
    internal class AbsClass4a
    {
        public static void Main(string[] args)
        {
            impPack obj = new();
           
            Console.WriteLine("Choose your package:\n1.Gold 2.Silver 3.Platinum");
            int pack = Convert.ToInt32(Console.ReadLine());
                switch (pack)
            {
                case 1:
                    obj.goldPack();
                    break;
                case 2:
                    obj.silverPack();
                    break;
                case 3:
                    obj.platinumPack();
                    break;
                default:
                    Console.WriteLine("Select between 1 to 3");
                    break;
            }
        }
    }
}
