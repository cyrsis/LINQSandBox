using System;
using System.Xml.Linq;

namespace DemoXRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement el = new XElement("�ڸ`�I");

            el.Add(new XElement("�l�`�I1"),
                new XElement("�l�`�I2"),
                new XElement("�l�`�I3"),
                new XElement("�l�`�I4")
                );

            el.Element("�l�`�I3").Remove();

            Console.WriteLine(el);

            el.RemoveAll();

            Console.WriteLine("\n��ڸ`�I����RemoveAll��k��");
            Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
