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
            XElement root = new XElement("�ڤ���",
                new XAttribute("���e", "0"));

            XDocument doc = new XDocument(new XComment("�o�O��󪺵������e"), root);

            doc.Declaration = new XDeclaration("1.0", "utf-16", "yes");

            doc.Root.Add(new XElement("�l����"),
                new XElement("�l����")
                );

            StringWriter sw = new StringWriter();
            doc.Save(sw, SaveOptions.None);
            sw.Close();

            Console.WriteLine(sw.ToString());

            Console.ReadKey();
        }
    }
}
