using System;
using System.Linq;

namespace DemoLastOrDefault1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };
            int[] lst2 = { };

            var item = lst.LastOrDefault();
            var item2 = lst2.LastOrDefault();

            Console.WriteLine(string.Format("lst�Ʋժ��̲פ@�Ӥ����G{0}", item));
            Console.WriteLine(string.Format("lst2�Ʋժ��̲פ@�Ӥ����G{0}", item2));

            Console.ReadKey();
        }
    }
}
