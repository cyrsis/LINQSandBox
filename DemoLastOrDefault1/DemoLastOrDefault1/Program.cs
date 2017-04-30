using System;
using System.Linq;

namespace DemoLastOrDefault1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };
            int[] lst2 = { };

            var item = lst.LastOrDefault();
            var item2 = lst2.LastOrDefault();

            Console.WriteLine(string.Format("lst數組的最終一個元素：{0}", item));
            Console.WriteLine(string.Format("lst2數組的最終一個元素：{0}", item2));

            Console.ReadKey();
        }
    }
}
