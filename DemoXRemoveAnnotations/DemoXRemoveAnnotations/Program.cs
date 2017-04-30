using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DemoXRemoveAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<根節點>
                                  <子節點1>
                                    <第3級 />
                                  </子節點1>
                                  <子節點2 />
                                  <子節點3 />
                                  <子節點4 />
                            </根節點>";


            XElement el = XElement.Parse(sxml);
            el.Element("子節點1").AddAnnotation("批注1");
            el.Element("子節點1").AddAnnotation("批注2");
            el.Element("子節點1").AddAnnotation("批注3");
            el.Element("子節點1").AddAnnotation(new StringBuilder());
            el.Element("子節點1").AddAnnotation(new StringBuilder());

            
            el.Element("子節點1").Element("第3級").AddAnnotation("第3級批注");

            el.Element("子節點1").RemoveAnnotations<string>();
            Console.WriteLine("子節點1的string批注物件數：{0}", el.Element("子節點1").Annotations<string>().Count());
            Console.WriteLine("子節點1的StringBuilder批注物件數：{0}", el.Element("子節點1").Annotations<StringBuilder>().Count());

            Console.WriteLine("第3級的string批注物件數：{0}", el.Element("子節點1").Element("第3級").Annotations<string>().Count());
         
            Console.ReadKey();
        }
    }
}
