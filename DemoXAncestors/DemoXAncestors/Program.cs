using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoXAncestors
{
    class Program
    {
        static void Main(string[] args)
        {

            string sxml = @"<根節點>
                                  <子節點1>
                                        <第3級節點 />
                                  </子節點1>
                                  <子節點2 />
                                  <子節點3 />
                                  <子節點4 />
                            </根節點>";

            XElement el = XElement.Parse(sxml);

            XElement el2 = el.Descendants("第3級節點").First();

            Console.WriteLine("應用Ancestors方法返回父元素集合");
            foreach(XElement e in el2.Ancestors())
                Console.WriteLine(e.Name.LocalName);

            Console.WriteLine("\n應用AncestorsAndSelf方法返回父元素集合");
            foreach (XElement e in el2.AncestorsAndSelf())
                Console.WriteLine(e.Name.LocalName);


            Console.ReadKey();
        }
    }
}
