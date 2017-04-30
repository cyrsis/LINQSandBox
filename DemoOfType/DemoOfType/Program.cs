using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DemoOfType
{
    class Program
    {
        static void Main(string[] args)
        {
            //©w¸qArrayList
            ArrayList nemes = new ArrayList();
            nemes.Add("ªL±ßºa");
            nemes.Add("¬¥¾®");
            nemes.Add(100);
            nemes.Add(new Stack());
            nemes.Add("¸³¥©¥©");

            IEnumerable<string> newnames = nemes.OfType<string>();

            foreach (string s in newnames)
                Console.Write(string.Format("{0} ", s));

            Console.ReadKey();
        }
    }
}
