using System;
using System.Linq;
using DemoDistinct2;

namespace DemoExcept2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///�w�q�Ʋ�
            string[] girls1 = { "���ɭY", "����", "������", "���P��" };
            string[] girls2 = { "�����", "���P��", "����", "������" };

            var girls = girls1.Except(girls2, new MyEqualityComparer<string>());

            Console.WriteLine("2�ӼƲդ����P����");
            foreach (var g in girls)
                Console.Write(string.Format("{0} ", g));

            Console.ReadKey();
        }
    }
}
