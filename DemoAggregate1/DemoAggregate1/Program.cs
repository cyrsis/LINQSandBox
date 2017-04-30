using System;
using System.Linq;

namespace DemoAggregate1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            string str = lst.Aggregate((s1, s2) =>
                                string.Format("{0}�B{1}", s1, s2));

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
