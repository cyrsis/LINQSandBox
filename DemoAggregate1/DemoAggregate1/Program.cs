using System;
using System.Linq;

namespace DemoAggregate1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            string str = lst.Aggregate((s1, s2) =>
                                string.Format("{0}、{1}", s1, s2));

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
