using System;
using System.Xml.Linq;

namespace DemoXRemoveAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<根節點>
                                  <子節點1 內容1='測試' 內容2='0'>
                                         <第3級 內容='1'/>
                                   </子節點1>
                                  <子節點2 />
                            </根節點>";

            XElement el = XElement.Parse(sxml);

            Console.WriteLine("應用RemoveAttributes之後");

            el.Element("子節點1").RemoveAttributes();

            Console.WriteLine(el);

            el.Element("子節點1").RemoveAll();

            Console.WriteLine("\n應用RemoveAll之後");
            Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
