using System;
using System.Linq;

namespace DemoFirst1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            var item = lst.First();

            Console.WriteLine(string.Format("�Ʋժ��Ĥ@�Ӥ����G{0}", item));

            Console.ReadKey();
        }
    }
}
