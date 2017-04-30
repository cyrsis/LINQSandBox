using System;
using System.Linq;

namespace DemoAverage
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

            double i1 = ilst.Average();
            double? i2 = ilst2.Average();
            double i3 = lst3.Average(item => Convert.ToInt32(item.ToCharArray()[0]));


            Console.WriteLine("ilst�����ȡG{0}", i1);
            Console.WriteLine("ilst2�����ȡG{0}", i2);
            Console.WriteLine("lst3�����ȡG{0}", i3);
            Console.ReadKey();
        }
    }
}
