using System;
using System.Linq;

namespace DemoIntersect1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///定義數組
            string[] girls1 = { "蕭玉若", "洛凝", "蕭玉霜", "秦仙兒" };
            string[] girls2 = { "月牙兒", "秦仙兒", "洛凝", "蕭玉霜" };

            var girls = girls1.Intersect(girls2);

            Console.WriteLine("在2個數組中都存在的元素排序");
            foreach (var g in girls)
                Console.Write(string.Format("{0} ", g));

            Console.ReadKey();
        }
    }
}

