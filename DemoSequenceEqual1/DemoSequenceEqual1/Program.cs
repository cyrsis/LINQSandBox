using System;
using System.Linq;

namespace DemoSequenceEqual1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst1 = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };
            string[] lst2 = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };
            string[] lst3 = { "�ĥ��H��", "�X�����D", "���a�G�p�j", "�O�n���D" };

            Console.WriteLine(string.Format("lst1 �M lst2 ��񵲪G�G{0}", lst1.SequenceEqual(lst2)));

            Console.WriteLine(string.Format("lst1 �M lst3 ��񵲪G�G{0}", lst1.SequenceEqual(lst3)));

            Console.ReadKey();
        }
    }
}
