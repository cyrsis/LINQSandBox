using System;
using System.Xml.Linq;

namespace DemoXComment
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = new XElement("�ڤ���",
                new XComment("�o�O�ڸ`�I���������e"),
                new XAttribute("���e", "0"));

            XDocument doc = new XDocument(new XComment("�o�O��󪺵������e"),root);

            doc.Root.Add(new XElement("�l����", "������"),
                new XElement("�l����")
                );


            Console.WriteLine(doc);
            Console.ReadKey();
        }
    }
}