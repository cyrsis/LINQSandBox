using System;
using System.Linq;

namespace DemoConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            ///�w�q�Ʋ�
            string[] girls1 = { "���ɭY", "����", "������", "���P��" };
            string[] girls2 = { "�����", "���P��", "����", "������" };

            var girls = girls1.Concat(girls2);

            Console.WriteLine("�X�᪺֫�Ƨ�");
            foreach (var g in girls)
                Console.Write(string.Format("{0} ", g));

            Console.ReadKey();
        }
    }
}

