using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DemoXElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�ڸ`�I>
                                  <�l�`�I>
                                        <��3��>1</��3��>
                                        <��3��>2</��3��>
                                   </�l�`�I>
                                  <�l�`�I>2</�l�`�I>
                                  <�l�`�I>3</�l�`�I>
                                  <�l�`�I>4</�l�`�I>
                                  <�l�`�I>5</�l�`�I>
                                  <�l�`�I>6</�l�`�I>
                            </�ڸ`�I>";

            XElement el = XElement.Parse(sxml);

            Console.WriteLine("����Elements��k��^���l�������X");
            IEnumerable<XElement> elChilds = el.Elements();
            foreach (XElement e in elChilds)
                Console.WriteLine(e.Name.LocalName);

            Console.WriteLine("\n����Descendants��k��^���l�������X");
            IEnumerable<XElement> elChilds2 = el.Descendants();
            foreach (XElement e in elChilds2)
                Console.WriteLine(e.Name.LocalName);

            Console.ReadKey();
        }
    }
}
