using System;
using System.Xml.Linq;

namespace DemoXReplaceAttributes
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

            el.Element("�l�`�I1").ReplaceAttributes(new XAttribute("�쫬�@����",0));
            Console.WriteLine("����ReplaceAttributes�쫬�@����");
            Console.WriteLine(el.Element("�l�`�I1"));

            el.Element("�l�`�I1").ReplaceAttributes(new XAttribute("�쫬�G����",0), new XAttribute("�쫬�G�W�[",0));
            Console.WriteLine("\n����ReplaceAttributes�쫬�G����");
            Console.WriteLine(el.Element("�l�`�I1"));

            Console.ReadKey();
        }
    }
}
