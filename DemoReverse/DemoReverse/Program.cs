using System;
using System.Linq;

namespace DemoReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Reverse方法，用於反轉排序中元素的順序。";

            Console.WriteLine(str);

            Console.WriteLine("\n反轉字符串\n");

            var strrev = str.ToCharArray().Reverse();
            
            foreach (var c in strrev)
                Console.Write(c);

            Console.ReadKey();
        }
    }
}

