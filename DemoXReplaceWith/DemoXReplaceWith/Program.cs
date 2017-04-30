using System;
using System.Xml.Linq;

namespace DemoXReplaceWith
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

            el.Element("子節點2").ReplaceWith(new XElement("原型一替換的"));
            Console.WriteLine("應用ReplaceWith原型一之後");
            Console.WriteLine(el);

            el.Element("子節點3").ReplaceWith(new XElement("替換3"), new XElement("新加入"));
            Console.WriteLine("\n應用ReplaceWith原型二之後");
            Console.WriteLine(el);

            Console.ReadKey();
        }
    }
}
