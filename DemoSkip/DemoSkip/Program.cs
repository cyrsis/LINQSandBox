using System;
using System.Linq;

namespace DemoSkip
{
    class Program
    {
        static void Main(string[] args)
        {
            //�w�q�Ʋ�
            string[] nemes = { "�L�ߺa", "����", "������", "�̽�", "�w�Ѧp" };

            Console.WriteLine("��Skip��k���L�e3�Ӥ������X");
            //��Skip��k���L�e3�Ӥ������X
            foreach (string s in nemes.Skip(3))
                Console.WriteLine(s);

            var query = from n in nemes
                        where n.Length == 3
                        select n;

            Console.WriteLine("\n��Skip��k���L�Ĥ@�Ӭd�ߵ��G���X");

            //��Skip��k���L�Ĥ@�Ӭd�ߵ��G���X
            foreach (string s in query.Skip(1))
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}

