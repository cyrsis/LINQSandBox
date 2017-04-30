using System;
using System.Xml.Linq;

namespace DemoXAnnotations
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
            el.Element("子節點1").AddAnnotation("批注1");
            el.Element("子節點1").AddAnnotation("批注2");
            el.Element("子節點1").AddAnnotation("批注3");
            Console.WriteLine("子節點1的批注物件");

            //存取批注物件集合
            foreach (string s in el.Element("子節點1").Annotations<string>())
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
