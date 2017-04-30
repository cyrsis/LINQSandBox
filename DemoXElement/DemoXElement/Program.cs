using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DemoXElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //�ϥέ쫬�@�c��
            XElement el1 = new XElement("�쫬1�ڸ`�I");
            Console.WriteLine(el1);

            Console.WriteLine("***********************************");

            //�ϥέ쫬2�c��
            XElement el2 = new XElement(el1);
            el2.Name = "�쫬2�ڸ`�I";
            Console.WriteLine(el2);

            Console.WriteLine("***********************************");

            //�ϥέ쫬3�c��
            XElement el3 = new XElement(
                                new XStreamingElement("�쫬3�ڸ`�I",
                                                        from el in el1.Elements()
                                                        select el
                                                      )
                                        );
            Console.WriteLine(el3);

            Console.WriteLine("***********************************");

            //�ϥέ쫬4�c��
            XElement el4 = new XElement("�쫬4�ڸ`�I",new XElement("�쫬4���l�`�I"));
            Console.WriteLine(el4);

            Console.WriteLine("***********************************");


            //�ϥέ쫬5�c��
            XElement el5 = new XElement("�쫬5�ڸ`�I", 
                new XElement("�쫬5���l�`�I",1),
                new XElement("�쫬5���l�`�I",2),
                new XElement("�쫬5���l�`�I",3)
            );
            Console.WriteLine(el5);

            Console.ReadKey();

        }
    }
}
