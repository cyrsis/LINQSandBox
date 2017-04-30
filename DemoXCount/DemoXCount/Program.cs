using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoXCount
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

            var query = from item in root.Elements("�Ȥ�")
                        let cc = (from l in item.Elements("�q�f��")
                                  let c = Convert.ToDouble(l.Element("���").Value) * (double)l.Element("�ƶq")
                                  select c).Sum()
                        orderby cc descending
                        select new { Guest = item, Count = cc };

            foreach (var item in query)
            {
                Console.WriteLine("�m�W�G{0} �q���`���G{1}", item.Guest.Attribute("�m�W").Value, item.Count.ToString("C"));
                foreach (var p in item.Guest.Elements("�q�f��"))
                    Console.WriteLine("{0} {1} {2}", p.Element("�~�W").Value, p.Element("���").Value, p.Element("�ƶq").Value);
                Console.WriteLine("----------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
