using System;
using System.Linq;

namespace DemoAggregate3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };
            int[] ilst = { 10, 20, 30, 40, 50 };

            string str = lst.Aggregate("林晚榮的客戶有：", (s1, s2) =>
                                       string.Format("{0}、{1}", s1, s2),
                                       s => s.Remove(s.IndexOf("、"), 1));

            string istr = ilst.Aggregate(50,
                                        (i1, i2) => i1 + i2,
                                        ii => string.Format("累加值：{0}", ii));

            Console.WriteLine(str);
            Console.WriteLine(istr);
            Console.ReadKey();
        }
    }
}
