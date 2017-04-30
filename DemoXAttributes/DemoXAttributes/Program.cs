using System;
using System.Xml.Linq;

namespace DemoXAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<根節點>
                                  <子節點1 內容1='1' 內容2='測試' />
                                  <子節點2 />
                                  <子節點3 />
                                  <子節點4 />
                            </根節點>";

            XElement el = XElement.Parse(sxml);

            foreach( var a in el.Element("子節點1").Attributes())
                Console.WriteLine(a);

            Console.ReadKey();

        }
    }
}
