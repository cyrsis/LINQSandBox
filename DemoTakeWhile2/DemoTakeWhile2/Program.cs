using System;
using System.Linq;

namespace DemoTakeWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            //定義數組
            string[] nemes = { "林晚榮", "洛凝", "董巧巧","出雲公主", "依蓮", "安碧如" };


            //返回元素字數小於4並且索引小於5的元素
            var takenames = nemes.TakeWhile((n, i) => n.Length < 4 && i < 5);
            foreach (string s in takenames)
                Console.WriteLine(s);


            Console.ReadKey();
        }
    }
}


