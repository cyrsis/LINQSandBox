using System;
using System.Xml.Linq;

namespace DemoXRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement el = new XElement("根節點");

            el.Add(new XElement("子節點1"),
                new XElement("子節點2"),
                new XElement("子節點3"),
                new XElement("子節點4")
                );

            el.Element("子節點3").Remove();

            Console.WriteLine(el);

            el.RemoveAll();

            Console.WriteLine("\n對根節點應用RemoveAll方法後");
            Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
