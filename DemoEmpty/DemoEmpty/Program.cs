using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoEmpty
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<string> empty = Enumerable.Empty<string>();

            Console.WriteLine(string.Format("±Æ§Ç¤¸¯À¼Æ¡G{0}",empty.Count()));
            
            Console.ReadKey();
        }
    }
}
