using System;
using System.Linq;

namespace DemoAggregate2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };
            int[] ilst = { 10, 20, 30, 40, 50 };
    
            string str = lst.Aggregate("�L�ߺa���Ȥᦳ�G",(s1, s2) =>
                                string.Format("{0}�B{1}", s1, s2));

            int i = ilst.Aggregate(50, (i1, i2) => i1 + i2);

            Console.WriteLine(str);
            Console.WriteLine("ilst�֥[�ȡG{0}",i);
            Console.ReadKey();

        }
    }
}
