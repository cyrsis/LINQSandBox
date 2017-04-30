using System;
using System.Linq;
using DemoDistinct2;

namespace DemoExcept2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///定義數組
            string[] girls1 = { "蕭玉若", "洛凝", "蕭玉霜", "秦仙兒" };
            string[] girls2 = { "月牙兒", "秦仙兒", "洛凝", "蕭玉霜" };

            var girls = girls1.Except(girls2, new MyEqualityComparer<string>());

            Console.WriteLine("2個數組中不同元素");
            foreach (var g in girls)
                Console.Write(string.Format("{0} ", g));

            Console.ReadKey();
        }
    }
}
