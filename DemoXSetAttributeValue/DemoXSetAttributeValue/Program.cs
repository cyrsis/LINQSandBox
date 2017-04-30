using System;
using System.Xml.Linq;

namespace DemoXSetAttributeValue
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

            //移除內容1
            el.Element("子節點1").SetAttributeValue("內容1", null);

            //增加內容Test
            el.Element("子節點1").SetAttributeValue("內容Test", "測試值");

            Console.WriteLine(el.Element("子節點1"));

            //修改內容Test
            el.Element("子節點1").SetAttributeValue("內容Test", "修改值");

            Console.WriteLine(el.Element("子節點1"));

            Console.ReadKey();
        }
    }
}
