using System;
using System.Linq;

namespace DemoMin
{
    class Program
    {
        static void Main(string[] args)
        {
            //int 逼
            int[] ilst = { 100, 200, 300, 400, 500, 600 };
            //摸int逼
            int?[] ilst2 = { 100, 200, null, 400, 500, 600 };
            //才﹃逼
            string[] lst3 = { "冻そ", "ォㄠ", "拷產﹋", "繭籲そ" };

            int i1 = ilst.Min();
            int? i2 = ilst2.Min();
            int i3 = lst3.Min(item => Convert.ToInt32(item.ToCharArray()[0]));
            string smin = lst3.Min();
            string smin2 = lst3.Min(item => item.Substring(1, 1));

            Console.WriteLine("ilst程{0}", i1);
            Console.WriteLine("ilst2程{0}", i2);
            Console.WriteLine("lst3程1{0}", i3);
            Console.WriteLine("lst3才﹃程{0}", smin);
            Console.WriteLine("lst3材2程3{0}", smin2);
            Console.ReadKey();
        }
    }
}
