using System;
using System.Xml.Linq;

namespace DemoXAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�ڸ`�I>
                                  <�l�`�I1 ���e1='1' ���e2='����' />
                                  <�l�`�I2 />
                                  <�l�`�I3 />
                                  <�l�`�I4 />
                            </�ڸ`�I>";

            XElement el = XElement.Parse(sxml);

            Console.WriteLine(el.Element("�l�`�I1").Attribute("���e2"));

            Console.WriteLine(el.Element("�l�`�I1").Attribute("���e3") == null ? "���e3�ä��s�b" : el.Element("�l�`�I1").Attribute("���e3").ToString());

            Console.ReadKey();
        }
    }
}
