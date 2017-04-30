using System;
using System.Xml.Linq;

namespace DemoXAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement el = new XElement("根節點");

            el.Add(new XElement("Add增加的子節點"));

            el.Add(new XElement("Add增加的子節點"),
                new XElement("Add增加的子節點")
                );

            el.AddFirst(new XElement("AddFirst增加的子節點"));

            el.Element("AddFirst增加的子節點").AddAfterSelf(new XElement("AddAfterSelf增加的節點"));

            el.Element("AddFirst增加的子節點").AddBeforeSelf(new XElement("AddBeforeSelf增加的節點"));

            Console.WriteLine(el);

            Console.ReadKey();
        }
    }
}
