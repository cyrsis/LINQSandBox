using System;
using System.Linq;

namespace DemoSingleOrDefault1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lst = { "�ĥ��H��" };
            int[] lst2 = { };
            string[] lst3 = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            var item = lst.SingleOrDefault();
            var item2 = lst2.SingleOrDefault();

            Console.WriteLine(string.Format("lst�Ʋժ��Ĥ@�Ӥ����G{0}", item));
            Console.WriteLine(string.Format("lst2�Ʋժ��Ĥ@�Ӥ����G{0}", item2));

            try
            {
                var itme3 = lst3.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("\nlst3����SingleOrDefault��k�X���G{0}", e.Message));
            }


            Console.ReadKey();
        }
    }
}
