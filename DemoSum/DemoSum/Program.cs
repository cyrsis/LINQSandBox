using System;
using System.Linq;

namespace DemoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int �Ƨ�
            int[] ilst = { 100, 200, 300, 400, 500, 600 };
            //�i��������int�Ƨ�
            int?[] ilst2 = { 100, 200, null, 400, 500, 600 };
            //�r�Ŧ�Ƨ�
            string[] lst3 = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            int i1 = ilst.Sum();
            int? i2 = ilst2.Sum();
            int i3 = lst3.Sum(item => Convert.ToInt32(item.ToCharArray()[0]));


            Console.WriteLine("ilst���M�G{0}", i1);
            Console.WriteLine("ilst2���M�G{0}", i2);
            Console.WriteLine("lst3���M�G{0}", i3);
            Console.ReadKey();
        }
    }
}
