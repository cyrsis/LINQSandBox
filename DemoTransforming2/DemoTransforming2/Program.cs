using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoTransforming2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<資料>
                                <字>你 趙 月 錢 李 王 孫 喜 晨 曦 我 凡 寶 悅 愛</字>
                                <數>2 3 4 5 6 7</數>
                                <顏色>粉 綠 黃 蘭</顏色>
                                <其他>蛋糕 媽媽 衣服</其他>
                            </資料>";

            XElement root = XElement.Parse(sxml);

            ///變造新的XML樹
            XElement newroot = new XElement
                (
                new XElement("我的寶貝",
                    new XElement("姓名",
                        string.Format("{0}{1}{2}",
                        root.Element("字").Value.Split(' ').ElementAt(5),
                        root.Element("字").Value.Split(' ').ElementAt(9),
                        root.Element("字").Value.Split(' ').ElementAt(13))),
                     new XElement("乳名",
                         string.Format("{0}{1}",
                        root.Element("字").Value.Split(' ').ElementAt(2),
                        root.Element("字").Value.Split(' ').ElementAt(2))),
                     new XElement("年齡",
                         string.Format("{0}歲",
                        root.Element("數").Value.Split(' ').ElementAt(1))),
                    new XElement("喜歡的顏色",
                         string.Format("{0}色",
                        root.Element("顏色").Value.Split(' ').First())),
                     new XElement("喜歡的食物",
                         root.Element("其他").Value.Split(' ').First()),
                     new XElement("最喜歡的人",
                         root.Element("其他").Value.Split(' ').ElementAt(1)),
                     new XElement("經常說的話", 
                         string.Format("{0}{1}{2}{3}",
                         root.Element("其他").Value.Split(' ').ElementAt(1),
                         root.Element("字").Value.Split(' ').ElementAt(10),
                         root.Element("字").Value.Split(' ').Last(),
                         root.Element("字").Value.Split(' ').First())),
                      new XElement("依戀物", 
                         string.Format("{0}{1}",
                         root.Element("其他").Value.Split(' ').ElementAt(1),
                         root.Element("其他").Value.Split(' ').Last()))
                     )
                   );


            Console.WriteLine(newroot);

            Console.ReadKey();

        }
    }
}
