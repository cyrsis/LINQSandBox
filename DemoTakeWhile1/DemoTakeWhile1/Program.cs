using System;
using System.Linq;

namespace DemoTakeWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            //定義數組
            string[] nemes = { "依蓮", "董巧巧","洛凝", "安碧如" };

            var takenames = nemes.TakeWhile(n => n.Length == 2);

            //輸出字數是2個的名字
            foreach (var s in takenames)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
