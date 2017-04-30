using System;
using System.Xml.Linq;

namespace DemoXReplaceWith
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

            el.Element("�l�`�I2").ReplaceWith(new XElement("�쫬�@������"));
            Console.WriteLine("����ReplaceWith�쫬�@����");
            Console.WriteLine(el);

            el.Element("�l�`�I3").ReplaceWith(new XElement("����3"), new XElement("�s�[�J"));
            Console.WriteLine("\n����ReplaceWith�쫬�G����");
            Console.WriteLine(el);

            Console.ReadKey();
        }
    }
}
