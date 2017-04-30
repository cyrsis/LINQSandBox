using System;
using System.Xml.Linq;

namespace DemoXValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<根節點>
                                  <子節點>1</子節點>
                                    <子節點>
                                        <第3級>1</第3級>
                                        <第3級>2</第3級>
                                    </子節點>
                                  <子節點2>2</子節點2>
                                  <子節點3>字符串值</子節點3>
                                  <子節點>4</子節點>
                            </根節點>";

            XElement el = XElement.Parse(sxml);

            Console.WriteLine("第一個子節點的值：{0}", el.Element("子節點").Value);

            string svalue = (string)el.Element("子節點3");
            Console.WriteLine("強制轉換得到子節點3的值：{0}", svalue);

            int? ivalue = (int?)el.Element("不存在的節點");
            Console.WriteLine("可空類型的強制轉換：{0}", ivalue == null ? "值為null" : ivalue.ToString());

            int ivalue2 = (int)el.Element("子節點2");
            Console.WriteLine("強制轉換得到子節點2的值：{0}", ivalue2);

            el.Element("子節點2").Value = "字符串值";
            Console.WriteLine("子節點2的Value：{0}", el.Element("子節點2").Value);

            el.Element("子節點2").SetValue(12345);
            Console.WriteLine("子節點2的Value：{0}", el.Element("子節點2").Value);

            Console.ReadKey();
        }
    }
}
