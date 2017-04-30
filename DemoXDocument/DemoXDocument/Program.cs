using System;
using System.Xml.Linq;

namespace DemoXDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            //從URI加載 XML 文件生成 XDocument 物件
            XDocument doc = XDocument.Load("http://rss.sina.com.cn/news/marquee/ddt.xml");

            //為了方便檢視，省略一些子節點
            doc.Descendants("item").Remove();

            //為了方便檢視，省略註釋的一些內容
            foreach (var n in doc.Nodes())
            {
                XComment comm = n as XComment;
                if (comm != null)
                    comm.Value = string.Format("{0} ...... ",comm.Value.Substring(0, 30));
            }
            
            Console.WriteLine(doc);
            Console.ReadKey();
        }
    }
}
