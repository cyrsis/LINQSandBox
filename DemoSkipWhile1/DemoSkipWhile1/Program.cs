using System;
using System.Linq;

namespace DemoSkipWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            //�w�q�Ʋ�
            string[] nemes = { "�̽�", "������", "����", "�w�Ѧp" };

            var takenames = nemes.SkipWhile(n => n.Length == 2);

            //���L�r�ƬO2�Ӫ��W�r���X
            foreach (var s in takenames)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}


