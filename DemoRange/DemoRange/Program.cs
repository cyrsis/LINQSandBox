using System;
using System.Linq;

namespace DemoRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //°_©l­¶½X
            int istart = 18;

            //µ²§ô­¶½X
            int iend = 26;

            var pages = Enumerable.Range(istart, iend - istart + 1);

            Console.WriteLine("¿é¥X­¶½X");
            foreach (var n in pages)
                Console.Write(string.Format("[{0}] ", n));

            Console.ReadKey();
        }
    }
}
