using System;
using System.Xml.Linq;

namespace DemoXReplaceAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<根節點>
                                  <子節點1 內容1='測試'/>
                                  <子節點2 />
                                  <子節點3 />
                                  <子節點4 />
                            </根節點>";

            XElement el = XElement.Parse(sxml);

            el.Element("子節點1").ReplaceAttributes(new XAttribute("原型一替換",0));
            Console.WriteLine("應用ReplaceAttributes原型一之後");
            Console.WriteLine(el.Element("子節點1"));

            el.Element("子節點1").ReplaceAttributes(new XAttribute("原型二替換",0), new XAttribute("原型二增加",0));
            Console.WriteLine("\n應用ReplaceAttributes原型二之後");
            Console.WriteLine(el.Element("子節點1"));

            Console.ReadKey();
        }
    }
}
