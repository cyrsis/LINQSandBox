using System;
using System.Xml.Linq;

namespace DemoXNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            XNamespace sp = "http://www.tiyor.com";

            XElement root = new XElement(sp + "根元素",
              new XAttribute("內容", "0")
              );

            XDocument doc = new XDocument(
                new XProcessingInstruction("xml-stylesheet", "type='text/xsl' href='test.xsl'"),
                new XDocumentType("限定名", "Test Name", "專用標誌符", "內部子集"),
                new XComment("這是文件的註釋內容"), root);


            root.Add(new XElement(sp + "子元素"),
                new XElement(sp + "子元素")
                );

            root.Add(new XCData("這裡是根元素的CDATA節點"));

            Console.WriteLine(doc);

            Console.ReadKey();
           
        }
    }
}
