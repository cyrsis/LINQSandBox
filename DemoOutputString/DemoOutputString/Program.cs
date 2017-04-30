using System;
using System.IO;
using System.Xml.Linq;

namespace DemoOutputString
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
                new XDeclaration("1.0","utf-16","yes"),
                new XProcessingInstruction("xml-stylesheet", "type='text/xsl' href='test.xsl'"),
                new XDocumentType("���w�W", "Test Name", "�M�μлx��", "�����l��"),
                new XComment("�o�O��󪺵������e"), root);


            root.Add(new XElement(sp + "�l����"),
                new XElement(sp + "�l����")
                );

            root.Add(new XCData("�o�̬O�ڤ�����CDATA�`�I"));

            StringWriter strw = new StringWriter();
            doc.Save(strw, SaveOptions.None);
            strw.Close();

            string strxml = strw.ToString();

            Console.WriteLine(strxml);

            Console.ReadKey();
        }
    }
}
