using System;
using System.Linq;

namespace DemoAll
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            bool p = lst.All(s => s.GetTypeCode() == TypeCode.String);
            bool p2 = lst.All(s => s.IndexOf("���D")>-1);

            Console.WriteLine(string.Format("���������O�_���OString�����G{0}", p));
            Console.WriteLine(string.Format("\n���������O�_���]�t�u���D�v�o�ӵ��G{0}", p2));
            Console.ReadKey();
        }
    }
}
