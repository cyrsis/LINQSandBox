using System;
using System.Xml.Linq;

namespace DemoXDocumentType
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = new XElement("根元素",
               new XAttribute("內容", "0"));

            XDocument doc = new XDocument(
                new XDocumentType("限定名","Test Name","專用標誌符","內部子集"),
                new XComment("這是文件的註釋內容"), root);


            doc.Root.Add(new XElement("子元素"),
                new XElement("子元素")
                );

            Console.WriteLine(doc);

            Console.ReadKey();
        }
    }
}
