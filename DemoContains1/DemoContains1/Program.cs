using System;
using System.Linq;

namespace DemoContains1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            bool p = lst.Contains("�ĥ��H��");
            bool p2 = lst.Contains("���R���D");

            Console.WriteLine(string.Format("�O�_���]�t�u�ĥ��H��v�o�Ӥ����G{0}", p));
            Console.WriteLine(string.Format("\n�O�_���]�t�u���R���D�v�o�Ӥ����G{0}", p2));
            Console.ReadKey();

        }
    }
}
