using System;
using System.Xml.Linq;

namespace DemoXDocumentType
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = new XElement("�ڤ���",
               new XAttribute("���e", "0"));

            XDocument doc = new XDocument(
                new XDocumentType("���w�W","Test Name","�M�μлx��","�����l��"),
                new XComment("�o�O��󪺵������e"), root);


            doc.Root.Add(new XElement("�l����"),
                new XElement("�l����")
                );

            Console.WriteLine(doc);

            Console.ReadKey();
        }
    }
}
