using System;
using System.Linq;

namespace DemoLongCount1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            long lcount = lst.LongCount();

            Console.WriteLine("�ƧǤ������ƶq���G {0} ", lcount);

            Console.ReadKey();
        }
    }
}
