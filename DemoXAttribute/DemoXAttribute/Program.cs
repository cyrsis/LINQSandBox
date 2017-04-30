using System;
using System.Xml.Linq;

namespace DemoXAttribute
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

            Console.WriteLine(el.Element("子節點1").Attribute("內容2"));

            Console.WriteLine(el.Element("子節點1").Attribute("內容3") == null ? "內容3並不存在" : el.Element("子節點1").Attribute("內容3").ToString());

            Console.ReadKey();
        }
    }
}
