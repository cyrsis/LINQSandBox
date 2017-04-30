using System;
using System.Linq;
using System.Collections.Generic;

namespace DemoTake
{
    class Program
    {
        static void Main(string[] args)
        {
            //定義數組
            string[] nemes = { "林晚榮", "洛凝", "董巧巧", "依蓮", "安碧如" };

            Console.WriteLine("Take方法直接輸出前3個元素");
            //用Take方法直接輸出前3個元素
            foreach (string s in nemes.Take(3))
                Console.WriteLine(s);

            var query = from n in nemes
                        where n.Length == 2
                        select n;

            Console.WriteLine("\n用Take方法輸出查詢結果的前1個元素");

            //用Take方法輸出查詢結果的前1個元素
            foreach (string s in query.Take(1))
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
