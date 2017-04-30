using System;
using System.Linq;

namespace DemoSum
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

            int i1 = ilst.Sum();
            int? i2 = ilst2.Sum();
            int i3 = lst3.Sum(item => Convert.ToInt32(item.ToCharArray()[0]));


            Console.WriteLine("ilst之和：{0}", i1);
            Console.WriteLine("ilst2之和：{0}", i2);
            Console.WriteLine("lst3之和：{0}", i3);
            Console.ReadKey();
        }
    }
}
