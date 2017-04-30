using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoXOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�q�T��>
                              <�Ȥ� �m�W='�v�C�x' �~��='21'>
                                 <¾��>�X�����D</¾��>
                                 <�q��>017*-876543**</�q��>
                              </�Ȥ�>
                              <�Ȥ� �m�W='������' �~��='19'>
                                 <¾��>�ĥ��H��</¾��>
                                 <�q��>029*-981256**</�q��>
                              </�Ȥ�>
                              <�Ȥ� �m�W='������' �~��='17'>
                                 <¾��>���a�G�p�j</¾��>
                                 <�q��>053*-985690**</�q��>
                              </�Ȥ�>
                              <�Ȥ� �m�W='���P��' �~��='20'>
                                 <¾��>�O�n���D</¾��>
                                 <�q��>023*-338987**</�q��>
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
                        orderby (int)item.Attribute("�~��"), item.Element("�q��").Value
                        select item;

            foreach (var el in query)
                Console.WriteLine(el);

            Console.ReadKey();
        }
    }
}
