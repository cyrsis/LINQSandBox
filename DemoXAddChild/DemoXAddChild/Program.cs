using System;
using System.Xml.Linq;

namespace DemoXAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement el = new XElement("�ڸ`�I");

            el.Add(new XElement("Add�W�[���l�`�I"));

            el.Add(new XElement("Add�W�[���l�`�I"),
                new XElement("Add�W�[���l�`�I")
                );

            el.AddFirst(new XElement("AddFirst�W�[���l�`�I"));

            el.Element("AddFirst�W�[���l�`�I").AddAfterSelf(new XElement("AddAfterSelf�W�[���`�I"));

            el.Element("AddFirst�W�[���l�`�I").AddBeforeSelf(new XElement("AddBeforeSelf�W�[���`�I"));

            Console.WriteLine(el);

            Console.ReadKey();
        }
    }
}
