using System;
using System.Linq;

namespace DemoDistinct2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///�w�q�@�Ӧ����Ƥ������Ʋ�
            string[] girls = { "���ɭY", "����", "������", "���P��",
                               "�����", "������","���P��", "����", "������"};

            Console.WriteLine("�t�����Ƥ������Ʋ�");
            foreach (var g in girls)
                Console.Write(string.Format("{0} ", g));

            var q = girls.Distinct(new MyEqualityComparer<string>());

            Console.WriteLine("\n\n�h�����Ƥ������Ƨ�");
            foreach (var g in q)
                Console.Write(string.Format("{0} ", g));

            Console.ReadKey();
        }
    }
}
