using System;
using System.Linq;

namespace DemoLastOrDefault2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 10, 20, 30, 40, 50, 100 };

            var item = lst.LastOrDefault(i => i == 66);

            Console.WriteLine(string.Format("數組的最終一個符合條件的元素：{0}", item));

            Console.ReadKey();
        }
    }
}
