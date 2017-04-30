using System;
using System.Xml.Linq;

namespace DemoXSetAttributeValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�ڸ`�I>
                                  <�l�`�I1 ���e1='����'/>
                                  <�l�`�I2 />
                                  <�l�`�I3 />
                                  <�l�`�I4 />
                            </�ڸ`�I>";

            XElement el = XElement.Parse(sxml);

            //�������e1
            el.Element("�l�`�I1").SetAttributeValue("���e1", null);

            //�W�[���eTest
            el.Element("�l�`�I1").SetAttributeValue("���eTest", "���խ�");

            Console.WriteLine(el.Element("�l�`�I1"));

            //�ק鷺�eTest
            el.Element("�l�`�I1").SetAttributeValue("���eTest", "�ק��");

            Console.WriteLine(el.Element("�l�`�I1"));

            Console.ReadKey();
        }
    }
}
