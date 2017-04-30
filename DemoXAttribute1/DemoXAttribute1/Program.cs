using System;
using System.Xml.Linq;

namespace DemoXAttribute1
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = new XElement("根元素",
                new XAttribute("內容1", "值"),
                new XAttribute("內容2", "0"));

            XElement child = new XElement("子元素1");
            child.Add(new XAttribute("子節點上的內容", "**"));

            XDocument doc = new XDocument(root);

            doc.Root.Add(child,
                new XElement("子元素2", "元素值"),
                new XElement("子元素3")
                );


            Console.WriteLine(doc);
            Console.ReadKey();
        }
    }
}