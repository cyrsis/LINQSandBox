using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoTransforming
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<通訊錄>
                              <客戶 姓名='肖青漩' 年齡='21'>
                                 <職務>出雲公主</職務>
                                 <電話>017*-876543**</電話>
                                 <訂貨單>
                                     <品名>6克拉鑽石戒指</品名>
                                     <單價>120,000</單價>
                                     <數量>3</數量>
                                 </訂貨單>
                                 <訂貨單>
                                     <品名>真絲旗袍</品名>
                                     <單價>3,600</單價>
                                     <數量>2</數量>
                                 </訂貨單>
                              </客戶>
                              <客戶 姓名='董巧巧' 年齡='19'>
                                 <職務>乖巧人兒</職務>
                                 <電話>029*-981256**</電話>
                                 <訂貨單>
                                     <品名>旺角酒樓</品名>
                                     <單價>2,500,000</單價>
                                     <數量>1</數量>
                                 </訂貨單>
                                 <訂貨單>
                                     <品名>奧迪TT</品名>
                                     <單價>650,000</單價>
                                     <數量>1</數量>
                                 </訂貨單>
                              </客戶>
                              <客戶 姓名='蕭玉霜' 年齡='17'>
                                 <職務>蕭家二小姐</職務>
                                 <電話>053*-985690**</電話>
                              </客戶>
                              <客戶 姓名='秦仙兒' 年齡='20'>
                                 <職務>霓裳公主</職務>
                                 <電話>023*-338987**</電話>
                                 <訂貨單>
                                     <品名>獨門四合院</品名>
                                     <單價>12,000,000</單價>
                                     <數量>1</數量>
                                 </訂貨單>
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

            //統計結果
            var count = from item in root.Elements("客戶")
                        let cc = (from l in item.Elements("訂貨單") let c = Convert.ToDouble(l.Element("單價").Value) * (double)l.Element("數量") select c).Sum()
                        where cc > 0
                        select new { Count = cc, Node = item };

            ///變造新的XML樹
            XElement newroot = new XElement
                (
                "客戶訂單表",
                new XElement("訂單總價", count.Sum(item => item.Count).ToString("c")),
                new XElement("訂戶總數", count.Count()),
                new XElement("明細",
                                    (from i in count
                                     select new XElement(i.Node.Name, i.Node.Attribute("姓名"),
                                                         new XAttribute("電話", i.Node.Element("電話").Value),
                                                         new XAttribute("小計", i.Count.ToString("c")),
                                                         (from p in i.Node.Elements("訂貨單") select new XElement("訂貨", from l in p.Elements() select new XAttribute(l.Name, l.Value)))))
                              )
                );

            Console.WriteLine(newroot);

            Console.ReadKey();
        }
    }
}
