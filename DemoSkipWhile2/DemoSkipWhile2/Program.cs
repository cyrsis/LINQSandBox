using System;
using System.Linq;

namespace DemoSkipWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            //�w�q�Ʋ�
            string[] nemes = { "�L�ߺa", "����", "������", "�X�����D", "�̽�", "�w�Ѧp" };


            //���L�����r�Ƥp��4�åB���ޤp��5������
            var takenames = nemes.SkipWhile((n, i) => n.Length < 4 && i < 5);
            foreach (string s in takenames)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}

