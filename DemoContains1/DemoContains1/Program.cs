using System;
using System.Linq;

namespace DemoContains1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            bool p = lst.Contains("乖巧人兒");
            bool p2 = lst.Contains("高麗公主");

            Console.WriteLine(string.Format("是否有包含「乖巧人兒」這個元素：{0}", p));
            Console.WriteLine(string.Format("\n是否有包含「高麗公主」這個元素：{0}", p2));
            Console.ReadKey();

        }
    }
}
