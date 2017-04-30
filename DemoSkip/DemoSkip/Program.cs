using System;
using System.Linq;

namespace DemoSkip
{
    class Program
    {
        static void Main(string[] args)
        {
            //定義數組
            string[] nemes = { "林晚榮", "洛凝", "董巧巧", "依蓮", "安碧如" };

            Console.WriteLine("用Skip方法跳過前3個元素後輸出");
            //用Skip方法跳過前3個元素後輸出
            foreach (string s in nemes.Skip(3))
                Console.WriteLine(s);

            var query = from n in nemes
                        where n.Length == 3
                        select n;

            Console.WriteLine("\n用Skip方法跳過第一個查詢結果後輸出");

            //用Skip方法跳過第一個查詢結果後輸出
            foreach (string s in query.Skip(1))
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}

