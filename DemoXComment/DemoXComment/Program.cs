using System;
using System.Xml.Linq;

namespace DemoXComment
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = new XElement("根元素",
                new XComment("這是根節點的註釋內容"),
                new XAttribute("內容", "0"));

            XDocument doc = new XDocument(new XComment("這是文件的註釋內容"),root);

            doc.Root.Add(new XElement("子元素", "元素值"),
                new XElement("子元素")
                );


            Console.WriteLine(doc);
            Console.ReadKey();
        }
    }
}