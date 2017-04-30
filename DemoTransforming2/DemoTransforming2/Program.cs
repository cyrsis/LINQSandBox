using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoTransforming2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<���>
                                <�r>�A �� �� �� �� �� �] �� �� �f �� �Z �_ �� �R</�r>
                                <��>2 3 4 5 6 7</��>
                                <�C��>�� �� �� ��</�C��>
                                <��L>�J�| ���� ��A</��L>
                            </���>";

            XElement root = XElement.Parse(sxml);

            ///�ܳy�s��XML��
            XElement newroot = new XElement
                (
                new XElement("�ڪ��_��",
                    new XElement("�m�W",
                        string.Format("{0}{1}{2}",
                        root.Element("�r").Value.Split(' ').ElementAt(5),
                        root.Element("�r").Value.Split(' ').ElementAt(9),
                        root.Element("�r").Value.Split(' ').ElementAt(13))),
                     new XElement("�ŦW",
                         string.Format("{0}{1}",
                        root.Element("�r").Value.Split(' ').ElementAt(2),
                        root.Element("�r").Value.Split(' ').ElementAt(2))),
                     new XElement("�~��",
                         string.Format("{0}��",
                        root.Element("��").Value.Split(' ').ElementAt(1))),
                    new XElement("���w���C��",
                         string.Format("{0}��",
                        root.Element("�C��").Value.Split(' ').First())),
                     new XElement("���w������",
                         root.Element("��L").Value.Split(' ').First()),
                     new XElement("�̳��w���H",
                         root.Element("��L").Value.Split(' ').ElementAt(1)),
                     new XElement("�g�`������", 
                         string.Format("{0}{1}{2}{3}",
                         root.Element("��L").Value.Split(' ').ElementAt(1),
                         root.Element("�r").Value.Split(' ').ElementAt(10),
                         root.Element("�r").Value.Split(' ').Last(),
                         root.Element("�r").Value.Split(' ').First())),
                      new XElement("���ʪ�", 
                         string.Format("{0}{1}",
                         root.Element("��L").Value.Split(' ').ElementAt(1),
                         root.Element("��L").Value.Split(' ').Last()))
                     )
                   );


            Console.WriteLine(newroot);

            Console.ReadKey();

        }
    }
}
