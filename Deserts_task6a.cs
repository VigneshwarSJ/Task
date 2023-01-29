using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task6
{
    internal class Deserts_task6a
    {
        public void WriteInFile()
        {

        }
        public static void Main(string[] args)
        {
            List<string> list2 = new List<string>();
            list2.Add("Vannila");
            list2.Add("Strawberry");
            list2.Add("Butterscotch");

            FileStream fs = new FileStream(@"D:\Training\Day 4\Sample34.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            foreach (string o in list2)
            {
                Console.WriteLine(o);
                bw.Write(o);
            }

            bw.Flush();
            bw.Close();
            fs.Close();
            FileInfo info = new FileInfo("D:\\Training\\Day 4\\Sample34.txt");
            Console.WriteLine("Size {0}", info.Length);
            Console.WriteLine("Created ON {0}", info.CreationTime);
        }
    }
}

