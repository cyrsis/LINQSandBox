using System;
using System.Linq;

namespace DemoFirstOrDefault2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 10,20,30,40,50,100 };

            var item = lst.FirstOrDefault(i => i==66);

            Console.WriteLine(string.Format("數組的第一個符合條件的元素：{0}", item));

            Console.ReadKey();
        }
    }
}
