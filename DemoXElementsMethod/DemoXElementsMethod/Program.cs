using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DemoXElementsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�ڸ`�I>
                                  <�l�`�I1 /> 
                                  <�l�`�I2 />
                                  <Test�l�`�I />
                                  <�l�`�I4 />
                                  <�l�`�I5 />
                                  <�l�`�I6 />
                            </�ڸ`�I>";


            XElement el = XElement.Parse(sxml);

            IEnumerable<XElement> els = el.Element("Test�l�`�I").ElementsAfterSelf();
            Console.WriteLine("����ElementsAfterSelf��k��^���������X");
            foreach (XElement e in els)
                Console.WriteLine(e);

            IEnumerable<XElement> els2 = el.Element("Test�l�`�I").ElementsBeforeSelf();
            Console.WriteLine("����ElementsBeforeSelf��k��^���������X");
            foreach (XElement e in els2)
                Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}
