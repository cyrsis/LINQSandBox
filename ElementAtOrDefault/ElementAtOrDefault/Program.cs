using System;
using System.Linq;

namespace ElementAtOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };
            int[] lst2 = { 10, 100, 1000, 1000 };

            var item = lst.ElementAtOrDefault(2);
            var itme2 = lst2.ElementAtOrDefault(4);


            Console.WriteLine(string.Format("���ެ�2�������G{0}", item));
            Console.WriteLine(string.Format("\n��^lst2�������w�]�ȡG{0}", itme2));

            Console.ReadKey();
        }
    }
}
