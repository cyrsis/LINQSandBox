using System;
using System.Linq;

namespace DemoElementAt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            var item = lst.ElementAt(2);

            Console.WriteLine(string.Format("���ެ�2�������G{0}", item));

            try
            {
                var itme2 = lst.ElementAt(4);
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("\n����ElementAt��k�X���G\n{0}", e.Message));
            }

            Console.ReadKey();
        }
    }
}
