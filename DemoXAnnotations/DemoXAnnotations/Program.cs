using System;
using System.Xml.Linq;

namespace DemoXAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�ڸ`�I>
                                  <�l�`�I1 />
                                  <�l�`�I2 />
                                  <�l�`�I3 />
                                  <�l�`�I4 />
                            </�ڸ`�I>";


            XElement el = XElement.Parse(sxml);
            el.Element("�l�`�I1").AddAnnotation("��`1");
            el.Element("�l�`�I1").AddAnnotation("��`2");
            el.Element("�l�`�I1").AddAnnotation("��`3");
            Console.WriteLine("�l�`�I1����`����");

            //�s����`���󶰦X
            foreach (string s in el.Element("�l�`�I1").Annotations<string>())
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
