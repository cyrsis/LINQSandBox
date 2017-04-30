using System;
using System.Xml.Linq;

namespace DemoXNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            XNamespace sp = "http://www.tiyor.com";

            XElement root = new XElement(sp + "�ڤ���",
              new XAttribute("���e", "0")
              );

            XDocument doc = new XDocument(
                new XProcessingInstruction("xml-stylesheet", "type='text/xsl' href='test.xsl'"),
                new XDocumentType("���w�W", "Test Name", "�M�μлx��", "�����l��"),
                new XComment("�o�O��󪺵������e"), root);


            root.Add(new XElement(sp + "�l����"),
                new XElement(sp + "�l����")
                );

            root.Add(new XCData("�o�̬O�ڤ�����CDATA�`�I"));

            Console.WriteLine(doc);

            Console.ReadKey();
           
        }
    }
}
