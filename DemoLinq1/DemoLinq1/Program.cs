using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoLinq1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "巧巧", "李四", "林三哥", "王五" };

            var value = from v in values where v.Length > 2 select v;

            foreach (var n in value)
                Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
