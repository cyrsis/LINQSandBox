using System;
using System.Linq;

namespace DemoAll
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "冻そ", "ォㄠ", "拷產﹋", "繭籲そ" };

            bool p = lst.All(s => s.GetTypeCode() == TypeCode.String);
            bool p2 = lst.All(s => s.IndexOf("そ")>-1);

            Console.WriteLine(string.Format("场じ琌常琌String摸{0}", p));
            Console.WriteLine(string.Format("\n场じ琌常そ硂迭{0}", p2));
            Console.ReadKey();
        }
    }
}
