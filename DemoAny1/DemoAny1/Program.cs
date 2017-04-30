using System;
using System.Linq;

namespace DemoAny1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };
            string[] lst2 = {};

            bool p = lst.Any();
            bool p2 = lst2.Any();

            Console.WriteLine(string.Format("lst是否包含元素：{0}", p));
            Console.WriteLine(string.Format("\nlst2是否包含元素：{0}", p2));
            Console.ReadKey();

        }
    }
}
