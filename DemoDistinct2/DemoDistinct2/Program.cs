using System;
using System.Linq;

namespace DemoDistinct2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///定義一個有重複元素的數組
            string[] girls = { "蕭玉若", "洛凝", "蕭玉霜", "秦仙兒",
                               "月牙兒", "蕭玉霜","秦仙兒", "洛凝", "蕭玉霜"};

            Console.WriteLine("含有重複元素的數組");
            foreach (var g in girls)
                Console.Write(string.Format("{0} ", g));

            var q = girls.Distinct(new MyEqualityComparer<string>());

            Console.WriteLine("\n\n去除重複元素的排序");
            foreach (var g in q)
                Console.Write(string.Format("{0} ", g));

            Console.ReadKey();
        }
    }
}
