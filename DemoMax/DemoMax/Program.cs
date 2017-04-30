using System;
using System.Linq;

namespace DemoMax
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

            int i1 = ilst.Max();
            int? i2 = ilst2.Max();
            int i3 = lst3.Max(item => Convert.ToInt32(item.ToCharArray()[0]));
            string smax = lst3.Max();
            string smax2 = lst3.Max(item => item.Substring(1, 1));

            Console.WriteLine("ilst�̤j�ȡG{0}", i1);
            Console.WriteLine("ilst2�̤j�ȡG{0}", i2);
            Console.WriteLine("lst3�̤j��1�G{0}", i3);
            Console.WriteLine("lst3�r�Ŧ�̤j�ȡG{0}", smax);
            Console.WriteLine("lst3��2�Ӧr���̤j��3�G{0}", smax2);
            Console.ReadKey();
        }
    }
}
