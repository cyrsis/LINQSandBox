using System;
using System.Linq;

namespace DemoSingle2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�ĥ��H��", "�O�n���D", "���a�G�p�j", "�X�����D" };

            var item = lst.Single(str => str.IndexOf("�p�j") > -1);

            try
            {
                var item2 = lst.Single(str => str.IndexOf("���D") > -1);
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("����Single��k�X���G{0}", e.Message));
            }

            Console.WriteLine(string.Format("\n�Ʋհߤ@�ŦX���󪺤����G{0}", item));

            Console.ReadKey();
        }
    }
}
