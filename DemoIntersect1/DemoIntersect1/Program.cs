using System;
using System.Linq;

namespace DemoIntersect1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///�w�q�Ʋ�
            string[] girls1 = { "���ɭY", "����", "������", "���P��" };
            string[] girls2 = { "�����", "���P��", "����", "������" };

            var girls = girls1.Intersect(girls2);

            Console.WriteLine("�b2�ӼƲդ����s�b�������Ƨ�");
            foreach (var g in girls)
                Console.Write(string.Format("{0} ", g));

            Console.ReadKey();
        }
    }
}

