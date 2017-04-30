using System;
using System.Linq;

namespace DemoMin
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

            int i1 = ilst.Min();
            int? i2 = ilst2.Min();
            int i3 = lst3.Min(item => Convert.ToInt32(item.ToCharArray()[0]));
            string smin = lst3.Min();
            string smin2 = lst3.Min(item => item.Substring(1, 1));

            Console.WriteLine("ilst�̤p�ȡG{0}", i1);
            Console.WriteLine("ilst2�̤p�ȡG{0}", i2);
            Console.WriteLine("lst3�̤p��1�G{0}", i3);
            Console.WriteLine("lst3�r�Ŧ�̤p�ȡG{0}", smin);
            Console.WriteLine("lst3��2�Ӧr���̤p��3�G{0}", smin2);
            Console.ReadKey();
        }
    }
}
