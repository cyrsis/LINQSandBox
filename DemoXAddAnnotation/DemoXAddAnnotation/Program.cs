using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DemoXAddAnnotation
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

            //建立一個批注物件
            List<string> tag = new List<string>{"測試內容1","測試內容2"};

            XElement el = XElement.Parse(sxml);

            //給子節點1增加批注物件
            el.Element("子節點1").AddAnnotation(tag);

            Console.WriteLine("子節點1的批注物件");
            //存取批注物件
            foreach(string s in el.Element("子節點1").Annotation<List<string>>())
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
