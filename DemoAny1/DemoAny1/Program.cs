using System;
using System.Linq;

namespace DemoAny1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };
            string[] lst2 = {};

            bool p = lst.Any();
            bool p2 = lst2.Any();

            Console.WriteLine(string.Format("lst�O�_�]�t�����G{0}", p));
            Console.WriteLine(string.Format("\nlst2�O�_�]�t�����G{0}", p2));
            Console.ReadKey();

        }
    }
}
