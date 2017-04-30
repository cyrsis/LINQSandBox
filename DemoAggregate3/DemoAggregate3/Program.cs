using System;
using System.Linq;

namespace DemoAggregate3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };
            int[] ilst = { 10, 20, 30, 40, 50 };

            string str = lst.Aggregate("�L�ߺa���Ȥᦳ�G", (s1, s2) =>
                                       string.Format("{0}�B{1}", s1, s2),
                                       s => s.Remove(s.IndexOf("�B"), 1));

            string istr = ilst.Aggregate(50,
                                        (i1, i2) => i1 + i2,
                                        ii => string.Format("�֥[�ȡG{0}", ii));

            Console.WriteLine(str);
            Console.WriteLine(istr);
            Console.ReadKey();
        }
    }
}
