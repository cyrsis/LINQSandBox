using System;
using System.Linq;

namespace DemoCount1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            try
            {
                
                int icount = lst.Count();

                Console.WriteLine("�ƧǤ������ƶq���G {0} ",icount);

            }
            catch (OverflowException)
            {
                Console.WriteLine("�ƧǤ������ƶq�W�LInt32�������̤j�ȡC");
            }


            Console.ReadKey();

        }
    }
}
