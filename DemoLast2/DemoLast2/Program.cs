using System;
using System.Linq;

namespace DemoLast2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�ĥ��H��", "�O�n���D", "���a�G�p�j", "�X�����D" };

            var item = lst.Last(str => str.IndexOf("���D") > -1);

            Console.WriteLine(string.Format("�Ʋժ��̲פ@�ӲŦX���󪺤����G{0}", item));

            Console.ReadKey();
        }
    }
}
