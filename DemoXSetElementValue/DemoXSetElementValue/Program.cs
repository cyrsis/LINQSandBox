using System;
using System.Xml.Linq;

namespace DemoXSetElementValue
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

            //移除第3級子元素
            el.Element("子節點1").SetElementValue("第3級", null);

            //新增加子元素
            el.Element("子節點1").SetElementValue("新增加子元素", "測試值");

            Console.WriteLine(el.Element("子節點1"));

            //修改新增加子元素
            el.Element("子節點1").SetElementValue("新增加子元素", "修改值");

            Console.WriteLine(el.Element("子節點1"));

            Console.ReadKey();
        }
    }
}
