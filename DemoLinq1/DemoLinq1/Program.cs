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
            string[] values = { "����", "���|", "�L�T��", "����" };

            var value = from v in values where v.Length > 2 select v;

            foreach (var n in value)
                Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
