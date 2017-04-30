using System;
using System.Xml.Linq;

namespace DemoXElementMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�ڸ`�I>
                                  <�l�`�I>1</�l�`�I>
                                  <�l�`�I>2</�l�`�I>
                                  <�l�`�I>3</�l�`�I>
                                  <�l�`�I>4</�l�`�I>
                                  <�l�`�I>5</�l�`�I>
                                  <�l�`�I>6</�l�`�I>
                            </�ڸ`�I>";


            XElement el = XElement.Parse(sxml);

            XElement elChild = el.Element("�l�`�I");

            Console.WriteLine(elChild);

            Console.ReadKey();
        }
    }
}
