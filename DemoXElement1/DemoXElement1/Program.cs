using System;
using System.Xml.Linq;

namespace DemoXElement1
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = new XDocument(new XElement("根元素"));

            doc.Root.Add(new XElement("子元素1"),
                new XElement("子元素2","元素值"),
                new XElement("子元素3")
                );

            Console.WriteLine(doc);
            Console.ReadKey();
        }
    }
}
