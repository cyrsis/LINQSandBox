using System;
using System.Linq;

namespace DemoLongCount2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            long lcount = lst.LongCount(str => str.IndexOf("���D") > -1);

            Console.WriteLine("�ƧǤ������ƶq���G {0} ", lcount);

            Console.ReadKey();
        }
    }
}
