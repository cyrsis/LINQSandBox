using System;
using System.Linq;

namespace DemoExcept1
{
    class Program
    {
        static void Main(string[] args)
        {
             ///�w�q�Ʋ�
            string[] girls1 = { "���ɭY", "����", "������", "���P��" };
            string[] girls2 = { "�����", "���P��", "����", "������" };

            var girls = girls1.Except(girls2);

            Console.WriteLine("2�ӼƲդ����P����");
            foreach (var g in girls)
                Console.Write(string.Format("{0} ", g));

            Console.ReadKey();
        }
    }
}
