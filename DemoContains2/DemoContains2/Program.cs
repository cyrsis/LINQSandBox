using System;
using System.Linq;
using DemoDistinct2;

namespace DemoContains2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D", "������" };

            bool p = lst.Contains("������", new MyEqualityComparer<string>());

            Console.WriteLine(string.Format("�O�_���]�t�u�������v�o�Ӥ����G{0}", p));
            Console.ReadKey();
        }
    }
}
