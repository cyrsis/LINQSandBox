using System;
using System.Linq;

namespace DemoLast1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            var item = lst.Last();

            Console.WriteLine(string.Format("�Ʋժ��̲פ@�Ӥ����G{0}", item));

            Console.ReadKey();
        }
    }
}
