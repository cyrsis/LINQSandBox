using System;
using System.Linq;

namespace DemoReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Reverse��k�A�Ω����ƧǤ����������ǡC";

            Console.WriteLine(str);

            Console.WriteLine("\n����r�Ŧ�\n");

            var strrev = str.ToCharArray().Reverse();
            
            foreach (var c in strrev)
                Console.Write(c);

            Console.ReadKey();
        }
    }
}

