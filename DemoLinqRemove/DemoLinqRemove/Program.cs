using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoLinqRemove
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

            //剔除訂單總價等於0的客戶
            (from item in root.Elements("客戶")
             let cc = (from l in item.Elements("訂貨單")
                       let c = Convert.ToDouble(l.Element("單價").Value) * (double)l.Element("數量")
                       select c).Sum()
             where cc == 0
             select item).Remove();

            //剔除XML樹中的訂單
            (from item in root.Elements("客戶")
               from l in item.Elements("訂貨單")   
             select l).Remove();

            Console.WriteLine(root);
          
            Console.ReadKey();
        }
    }
}
