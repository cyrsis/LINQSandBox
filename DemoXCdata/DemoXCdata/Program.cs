using System;
using System.Xml.Linq;

namespace DemoXCdata
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = new XElement("�ڤ���",
           new XAttribute("���e", "0")
           );

            XDocument doc = new XDocument(
                new XProcessingInstruction("xml-stylesheet", "type='text/xsl' href='test.xsl'"),
                new XDocumentType("���w�W", "Test Name", "�M�μлx��", "�����l��"),
                new XComment("�o�O��󪺵������e"), root);


            root.Add(new XElement("�l����"),
                new XElement("�l����")
                );

            root.Add(new XCData("�o�̬O�ڤ�����CDATA�`�I"));

            Console.WriteLine(doc);

            Console.ReadKey();
        }
    }
}
