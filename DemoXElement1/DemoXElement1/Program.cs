using System;
using System.Xml.Linq;

namespace DemoXElement1
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = new XDocument(new XElement("�ڤ���"));

            doc.Root.Add(new XElement("�l����1"),
                new XElement("�l����2","������"),
                new XElement("�l����3")
                );

            Console.WriteLine(doc);
            Console.ReadKey();
        }
    }
}
