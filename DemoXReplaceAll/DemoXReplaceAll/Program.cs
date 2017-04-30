using System;
using System.Xml.Linq;

namespace DemoXReplaceAll
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<根節點>
                                  <子節點1 />
                                  <子節點2 />
                                  <子節點3 />
                                  <子節點4 />
                            </根節點>";

            XElement el = XElement.Parse(sxml);

            el.Element("子節點2").ReplaceAll(new XElement("ReplaceAll原型一"));
            Console.WriteLine("應用ReplaceAll原型一之後");
            Console.WriteLine(el);

            el.Element("子節點3").ReplaceAll(new XElement("ReplaceAll原型二"), new XElement("ReplaceAll原型二"));
            Console.WriteLine("\n應用ReplaceAll原型二之後");
            Console.WriteLine(el);

            Console.ReadKey();
        }
    }
}
