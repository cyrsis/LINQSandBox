using System;
using System.Linq;

namespace DemoFirstOrDefault1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };
            int[] lst2 = { };

            var item = lst.FirstOrDefault();
            var item2 = lst2.FirstOrDefault();

            Console.WriteLine(string.Format("lst�Ʋժ��Ĥ@�Ӥ����G{0}", item));
            Console.WriteLine(string.Format("lst2�Ʋժ��Ĥ@�Ӥ����G{0}", item2));

            Console.ReadKey();
        }
    }
}
