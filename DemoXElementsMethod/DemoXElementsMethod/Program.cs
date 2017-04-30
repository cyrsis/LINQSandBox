using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DemoXElementsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<根節點>
                                  <子節點1 /> 
                                  <子節點2 />
                                  <Test子節點 />
                                  <子節點4 />
                                  <子節點5 />
                                  <子節點6 />
                            </根節點>";


            XElement el = XElement.Parse(sxml);

            IEnumerable<XElement> els = el.Element("Test子節點").ElementsAfterSelf();
            Console.WriteLine("應用ElementsAfterSelf方法返回的元素集合");
            foreach (XElement e in els)
                Console.WriteLine(e);

            IEnumerable<XElement> els2 = el.Element("Test子節點").ElementsBeforeSelf();
            Console.WriteLine("應用ElementsBeforeSelf方法返回的元素集合");
            foreach (XElement e in els2)
                Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}
