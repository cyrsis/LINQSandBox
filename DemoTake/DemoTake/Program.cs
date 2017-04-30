using System;
using System.Linq;
using System.Collections.Generic;

namespace DemoTake
{
    class Program
    {
        static void Main(string[] args)
        {
            //�w�q�Ʋ�
            string[] nemes = { "�L�ߺa", "����", "������", "�̽�", "�w�Ѧp" };

            Console.WriteLine("Take��k������X�e3�Ӥ���");
            //��Take��k������X�e3�Ӥ���
            foreach (string s in nemes.Take(3))
                Console.WriteLine(s);

            var query = from n in nemes
                        where n.Length == 2
                        select n;

            Console.WriteLine("\n��Take��k��X�d�ߵ��G���e1�Ӥ���");

            //��Take��k��X�d�ߵ��G���e1�Ӥ���
            foreach (string s in query.Take(1))
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
