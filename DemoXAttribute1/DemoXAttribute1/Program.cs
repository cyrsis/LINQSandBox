using System;
using System.Xml.Linq;

namespace DemoXAttribute1
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = new XElement("�ڤ���",
                new XAttribute("���e1", "��"),
                new XAttribute("���e2", "0"));

            XElement child = new XElement("�l����1");
            child.Add(new XAttribute("�l�`�I�W�����e", "**"));

            XDocument doc = new XDocument(root);

            doc.Root.Add(child,
                new XElement("�l����2", "������"),
                new XElement("�l����3")
                );


            Console.WriteLine(doc);
            Console.ReadKey();
        }
    }
}