using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DemoXRemoveAnnotations
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
            el.Element("�l�`�I1").AddAnnotation("��`1");
            el.Element("�l�`�I1").AddAnnotation("��`2");
            el.Element("�l�`�I1").AddAnnotation("��`3");
            el.Element("�l�`�I1").AddAnnotation(new StringBuilder());
            el.Element("�l�`�I1").AddAnnotation(new StringBuilder());

            
            el.Element("�l�`�I1").Element("��3��").AddAnnotation("��3�ŧ�`");

            el.Element("�l�`�I1").RemoveAnnotations<string>();
            Console.WriteLine("�l�`�I1��string��`����ơG{0}", el.Element("�l�`�I1").Annotations<string>().Count());
            Console.WriteLine("�l�`�I1��StringBuilder��`����ơG{0}", el.Element("�l�`�I1").Annotations<StringBuilder>().Count());

            Console.WriteLine("��3�Ū�string��`����ơG{0}", el.Element("�l�`�I1").Element("��3��").Annotations<string>().Count());
         
            Console.ReadKey();
        }
    }
}
