using System;
using System.Linq;

namespace DemoSequenceEqual1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst1 = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };
            string[] lst2 = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };
            string[] lst3 = { "乖巧人兒", "出雲公主", "蕭家二小姐", "霓裳公主" };

            Console.WriteLine(string.Format("lst1 和 lst2 對比結果：{0}", lst1.SequenceEqual(lst2)));

            Console.WriteLine(string.Format("lst1 和 lst3 對比結果：{0}", lst1.SequenceEqual(lst3)));

            Console.ReadKey();
        }
    }
}
