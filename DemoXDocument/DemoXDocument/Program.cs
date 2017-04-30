using System;
using System.Xml.Linq;

namespace DemoXDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            //�qURI�[�� XML ���ͦ� XDocument ����
            XDocument doc = XDocument.Load("http://rss.sina.com.cn/news/marquee/ddt.xml");

            //���F��K�˵��A�ٲ��@�Ǥl�`�I
            doc.Descendants("item").Remove();

            //���F��K�˵��A�ٲ��������@�Ǥ��e
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
