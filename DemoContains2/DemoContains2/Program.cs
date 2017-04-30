using System;
using System.Linq;
using DemoDistinct2;

namespace DemoContains2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主", "蕭玉霜" };

            bool p = lst.Contains("蕭玉霜", new MyEqualityComparer<string>());

            Console.WriteLine(string.Format("是否有包含「蕭玉霜」這個元素：{0}", p));
            Console.ReadKey();
        }
    }
}
