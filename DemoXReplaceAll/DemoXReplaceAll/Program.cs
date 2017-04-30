using System;
using System.Xml.Linq;

namespace DemoXReplaceAll
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

            el.Element("�l�`�I2").ReplaceAll(new XElement("ReplaceAll�쫬�@"));
            Console.WriteLine("����ReplaceAll�쫬�@����");
            Console.WriteLine(el);

            el.Element("�l�`�I3").ReplaceAll(new XElement("ReplaceAll�쫬�G"), new XElement("ReplaceAll�쫬�G"));
            Console.WriteLine("\n����ReplaceAll�쫬�G����");
            Console.WriteLine(el);

            Console.ReadKey();
        }
    }
}
