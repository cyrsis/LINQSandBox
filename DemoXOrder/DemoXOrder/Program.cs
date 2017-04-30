using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoXOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<通訊錄>
                              <客戶 姓名='肖青漩' 年齡='21'>
                                 <職務>出雲公主</職務>
                                 <電話>017*-876543**</電話>
                              </客戶>
                              <客戶 姓名='董巧巧' 年齡='19'>
                                 <職務>乖巧人兒</職務>
                                 <電話>029*-981256**</電話>
                              </客戶>
                              <客戶 姓名='蕭玉霜' 年齡='17'>
                                 <職務>蕭家二小姐</職務>
                                 <電話>053*-985690**</電話>
                              </客戶>
                              <客戶 姓名='秦仙兒' 年齡='20'>
                                 <職務>霓裳公主</職務>
                                 <電話>023*-338987**</電話>
                              </客戶>
                              <客戶 姓名='蕭玉若' 年齡='21'>
                                 <職務>蕭家大小姐</職務>
                                 <電話>035*-120967**</電話>
                              </客戶>
                              <客戶 姓名='洛凝' 年齡='19'>
                                 <職務>金陵才女</職務>
                                 <電話>033*-985690**</電話>
                              </客戶>
                            </通訊錄>";

            XElement root = XElement.Parse(sxml);

            var query = from item in root.Elements("客戶")
                        orderby (int)item.Attribute("年齡"), item.Element("電話").Value
                        select item;

            foreach (var el in query)
                Console.WriteLine(el);

            Console.ReadKey();
        }
    }
}
