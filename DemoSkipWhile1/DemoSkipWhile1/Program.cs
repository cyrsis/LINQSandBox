using System;
using System.Linq;

namespace DemoSkipWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            //定義數組
            string[] nemes = { "依蓮", "董巧巧", "洛凝", "安碧如" };

            var takenames = nemes.SkipWhile(n => n.Length == 2);

            //跳過字數是2個的名字後輸出
            foreach (var s in takenames)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}


