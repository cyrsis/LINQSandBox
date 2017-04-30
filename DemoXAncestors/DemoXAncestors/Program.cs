using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoXAncestors
{
    class Program
    {
        static void Main(string[] args)
        {

            string sxml = @"<�ڸ`�I>
                                  <�l�`�I1>
                                        <��3�Ÿ`�I />
                                  </�l�`�I1>
                                  <�l�`�I2 />
                                  <�l�`�I3 />
                                  <�l�`�I4 />
                            </�ڸ`�I>";

            XElement el = XElement.Parse(sxml);

            XElement el2 = el.Descendants("��3�Ÿ`�I").First();

            Console.WriteLine("����Ancestors��k��^���������X");
            foreach(XElement e in el2.Ancestors())
                Console.WriteLine(e.Name.LocalName);

            Console.WriteLine("\n����AncestorsAndSelf��k��^���������X");
            foreach (XElement e in el2.AncestorsAndSelf())
                Console.WriteLine(e.Name.LocalName);


            Console.ReadKey();
        }
    }
}
