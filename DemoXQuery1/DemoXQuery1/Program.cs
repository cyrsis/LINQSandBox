using System;
using System.Linq;
using System.Xml.Linq;

namespace DemoXQuery1
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
                            </�q�T��>";

            XElement root = XElement.Parse(sxml);

            //�z��~�֤��e�j��18���Ȥ�
            var query = from item in root.Elements("�Ȥ�")
                        where (from att in item.Attributes()
                               where att.Name.LocalName == "�~��"
                               select att).Any(age=>(int)age>18)
                        select item;

            foreach (var el in query)
                Console.WriteLine(el);
           
            Console.ReadKey();
                                              
        }
    }
}
