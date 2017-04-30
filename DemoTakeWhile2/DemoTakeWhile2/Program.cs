using System;
using System.Linq;

namespace DemoTakeWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            //�w�q�Ʋ�
            string[] nemes = { "�L�ߺa", "����", "������","�X�����D", "�̽�", "�w�Ѧp" };


            //��^�����r�Ƥp��4�åB���ޤp��5������
            var takenames = nemes.TakeWhile((n, i) => n.Length < 4 && i < 5);
            foreach (string s in takenames)
                Console.WriteLine(s);


            Console.ReadKey();
        }
    }
}


