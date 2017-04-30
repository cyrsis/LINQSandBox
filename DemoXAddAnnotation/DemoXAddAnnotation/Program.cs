using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DemoXAddAnnotation
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

            //�إߤ@�ӧ�`����
            List<string> tag = new List<string>{"���դ��e1","���դ��e2"};

            XElement el = XElement.Parse(sxml);

            //���l�`�I1�W�[��`����
            el.Element("�l�`�I1").AddAnnotation(tag);

            Console.WriteLine("�l�`�I1����`����");
            //�s����`����
            foreach(string s in el.Element("�l�`�I1").Annotation<List<string>>())
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
