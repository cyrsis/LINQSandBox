using System;
using System.Linq;

namespace DemoSingle1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�ĥ��H��" };
            string[] lst2 = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            var item = lst.Single();

            try
            {
                var itme2 = lst2.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("lst2����Single��k�X���G{0}", e.Message));
            }

            Console.WriteLine(string.Format("\nlst�Ʋժ��ߤ@�����G{0}", item));

            Console.ReadKey();
        }
    }
}
