using System;
using System.Linq;

namespace DefaultIfEmpty2
{
    class Program
    {
        static void Main(string[] args)
        {
            //空的int類型排序
            var intempty = Enumerable.Empty<int>();

            Console.Write("int 類型預設值：");
            foreach (var i in intempty.DefaultIfEmpty())
                Console.Write(i);

            Console.Write("\nint 類型自定義預設值：");
            foreach (var i in intempty.DefaultIfEmpty(-100))
                Console.Write(i);

            Console.ReadKey();
        }
    }
}
