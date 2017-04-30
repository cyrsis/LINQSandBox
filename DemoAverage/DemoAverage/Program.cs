using System;
using System.Linq;

namespace DemoAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //int 排序
            int[] ilst = { 100, 200, 300, 400, 500, 600 };
            //可空類型的int排序
            int?[] ilst2 = { 100, 200, null, 400, 500, 600 };
            //字符串排序
            string[] lst3 = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            double i1 = ilst.Average();
            double? i2 = ilst2.Average();
            double i3 = lst3.Average(item => Convert.ToInt32(item.ToCharArray()[0]));


            Console.WriteLine("ilst平均值：{0}", i1);
            Console.WriteLine("ilst2平均值：{0}", i2);
            Console.WriteLine("lst3平均值：{0}", i3);
            Console.ReadKey();
        }
    }
}
