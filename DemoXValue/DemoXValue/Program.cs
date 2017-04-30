using System;
using System.Xml.Linq;

namespace DemoXValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<�ڸ`�I>
                                  <�l�`�I>1</�l�`�I>
                                    <�l�`�I>
                                        <��3��>1</��3��>
                                        <��3��>2</��3��>
                                    </�l�`�I>
                                  <�l�`�I2>2</�l�`�I2>
                                  <�l�`�I3>�r�Ŧ��</�l�`�I3>
                                  <�l�`�I>4</�l�`�I>
                            </�ڸ`�I>";

            XElement el = XElement.Parse(sxml);

            Console.WriteLine("�Ĥ@�Ӥl�`�I���ȡG{0}", el.Element("�l�`�I").Value);

            string svalue = (string)el.Element("�l�`�I3");
            Console.WriteLine("�j���ഫ�o��l�`�I3���ȡG{0}", svalue);

            int? ivalue = (int?)el.Element("���s�b���`�I");
            Console.WriteLine("�i���������j���ഫ�G{0}", ivalue == null ? "�Ȭ�null" : ivalue.ToString());

            int ivalue2 = (int)el.Element("�l�`�I2");
            Console.WriteLine("�j���ഫ�o��l�`�I2���ȡG{0}", ivalue2);

            el.Element("�l�`�I2").Value = "�r�Ŧ��";
            Console.WriteLine("�l�`�I2��Value�G{0}", el.Element("�l�`�I2").Value);

            el.Element("�l�`�I2").SetValue(12345);
            Console.WriteLine("�l�`�I2��Value�G{0}", el.Element("�l�`�I2").Value);

            Console.ReadKey();
        }
    }
}
