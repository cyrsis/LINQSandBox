using System;
using System.Linq;

namespace DemoRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            ///定義一個匿名類型
            var orange = new {Color="橘色",Name="桔子"};

            var oranges = Enumerable.Repeat(orange,5);

            Console.WriteLine("包含5個匿名類型的元素");
            foreach (var n in oranges)
                Console.WriteLine(string.Format("{0}的{1} ", n.Color, n.Name));

            Console.ReadKey();
        }
    }
}

