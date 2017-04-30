using System;
using System.Xml.Linq;

namespace DemoXRemoveAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�ڸ`�I>
                                  <�l�`�I1 ���e1='����' ���e2='0'>
                                         <��3�� ���e='1'/>
                                   </�l�`�I1>
                                  <�l�`�I2 />
                            </�ڸ`�I>";

            XElement el = XElement.Parse(sxml);

            Console.WriteLine("����RemoveAttributes����");

            el.Element("�l�`�I1").RemoveAttributes();

            Console.WriteLine(el);

            el.Element("�l�`�I1").RemoveAll();

            Console.WriteLine("\n����RemoveAll����");
            Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
