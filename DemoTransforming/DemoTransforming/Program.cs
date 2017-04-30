using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoTransforming
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�q�T��>
                              <�Ȥ� �m�W='�v�C�x' �~��='21'>
                                 <¾��>�X�����D</¾��>
                                 <�q��>017*-876543**</�q��>
                                 <�q�f��>
                                     <�~�W>6�J���p�ۧ٫�</�~�W>
                                     <���>120,000</���>
                                     <�ƶq>3</�ƶq>
                                 </�q�f��>
                                 <�q�f��>
                                     <�~�W>�u���X�T</�~�W>
                                     <���>3,600</���>
                                     <�ƶq>2</�ƶq>
                                 </�q�f��>
                              </�Ȥ�>
                              <�Ȥ� �m�W='������' �~��='19'>
                                 <¾��>�ĥ��H��</¾��>
                                 <�q��>029*-981256**</�q��>
                                 <�q�f��>
                                     <�~�W>�����s��</�~�W>
                                     <���>2,500,000</���>
                                     <�ƶq>1</�ƶq>
                                 </�q�f��>
                                 <�q�f��>
                                     <�~�W>���}TT</�~�W>
                                     <���>650,000</���>
                                     <�ƶq>1</�ƶq>
                                 </�q�f��>
                              </�Ȥ�>
                              <�Ȥ� �m�W='������' �~��='17'>
                                 <¾��>���a�G�p�j</¾��>
                                 <�q��>053*-985690**</�q��>
                              </�Ȥ�>
                              <�Ȥ� �m�W='���P��' �~��='20'>
                                 <¾��>�O�n���D</¾��>
                                 <�q��>023*-338987**</�q��>
                                 <�q�f��>
                                     <�~�W>�W���|�X�|</�~�W>
                                     <���>12,000,000</���>
                                     <�ƶq>1</�ƶq>
                                 </�q�f��>
                              </�Ȥ�>
                              <�Ȥ� �m�W='���ɭY' �~��='21'>
                                 <¾��>���a�j�p�j</¾��>
                                 <�q��>035*-120967**</�q��>
                              </�Ȥ�>
                              <�Ȥ� �m�W='����' �~��='19'>
                                 <¾��>�����~�k</¾��>
                                 <�q��>033*-985690**</�q��>
                              </�Ȥ�>
                            </�q�T��>";

            XElement root = XElement.Parse(sxml);

            //�έp���G
            var count = from item in root.Elements("�Ȥ�")
                        let cc = (from l in item.Elements("�q�f��") let c = Convert.ToDouble(l.Element("���").Value) * (double)l.Element("�ƶq") select c).Sum()
                        where cc > 0
                        select new { Count = cc, Node = item };

            ///�ܳy�s��XML��
            XElement newroot = new XElement
                (
                "�Ȥ�q���",
                new XElement("�q���`��", count.Sum(item => item.Count).ToString("c")),
                new XElement("�q���`��", count.Count()),
                new XElement("����",
                                    (from i in count
                                     select new XElement(i.Node.Name, i.Node.Attribute("�m�W"),
                                                         new XAttribute("�q��", i.Node.Element("�q��").Value),
                                                         new XAttribute("�p�p", i.Count.ToString("c")),
                                                         (from p in i.Node.Elements("�q�f��") select new XElement("�q�f", from l in p.Elements() select new XAttribute(l.Name, l.Value)))))
                              )
                );

            Console.WriteLine(newroot);

            Console.ReadKey();
        }
    }
}
