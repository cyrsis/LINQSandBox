using System;
using System.Linq;

namespace DemoAny2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            bool p = lst.Any(s => s.IndexOf("���D") > -1);
            bool p2 = lst.Any(s => s.IndexOf("�P�l") > -1);

            Console.WriteLine(string.Format("�O�_���]�t�u���D�v�o�ӵ��������G{0}", p));
            Console.WriteLine(string.Format("\n�O�_���]�t�u�P�l�v�o�ӵ��������G{0}", p2));
            Console.ReadKey();
        }
    }
}
