using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoXQuery1
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
                            </通訊錄>";

            XElement root = XElement.Parse(sxml);

            //篩選年齡內容大於18的客戶
            var query = from item in root.Elements("客戶")
                        where (from att in item.Attributes()
                               where att.Name.LocalName == "年齡"
                               select att).Any(age=>(int)age>18)
                        select item;

            foreach (var el in query)
                Console.WriteLine(el);
           
            Console.ReadKey();
                                              
        }
    }
}
