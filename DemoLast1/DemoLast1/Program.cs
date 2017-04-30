using System;
using System.Linq;

namespace DemoLast1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            var item = lst.Last();

            Console.WriteLine(string.Format("數組的最終一個元素：{0}", item));

            Console.ReadKey();
        }
    }
}
