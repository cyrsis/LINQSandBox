using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text;

namespace DemoXDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = new XElement("根元素",
                new XAttribute("內容", "0"));

            XDocument doc = new XDocument(new XComment("這是文件的註釋內容"), root);

            doc.Declaration = new XDeclaration("1.0", "utf-16", "yes");

            doc.Root.Add(new XElement("子元素"),
                new XElement("子元素")
                );

            StringWriter sw = new StringWriter();
            doc.Save(sw, SaveOptions.None);
            sw.Close();

            Console.WriteLine(sw.ToString());

            Console.ReadKey();
        }
    }
}
