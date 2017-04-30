using System;
using System.Xml.Linq;

namespace DemoXSetElementValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�ڸ`�I>
                                  <�l�`�I1>
                                       <��3�� />
                                   </�l�`�I1>
                                  <�l�`�I2 />
                                  <�l�`�I3 />
                                  <�l�`�I4 />
                            </�ڸ`�I>";

            XElement el = XElement.Parse(sxml);

            //������3�Ťl����
            el.Element("�l�`�I1").SetElementValue("��3��", null);

            //�s�W�[�l����
            el.Element("�l�`�I1").SetElementValue("�s�W�[�l����", "���խ�");

            Console.WriteLine(el.Element("�l�`�I1"));

            //�ק�s�W�[�l����
            el.Element("�l�`�I1").SetElementValue("�s�W�[�l����", "�ק��");

            Console.WriteLine(el.Element("�l�`�I1"));

            Console.ReadKey();
        }
    }
}
