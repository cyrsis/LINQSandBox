using System;
using System.Linq;

namespace DemoTakeWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            //�w�q�Ʋ�
            string[] nemes = { "�̽�", "������","����", "�w�Ѧp" };

            var takenames = nemes.TakeWhile(n => n.Length == 2);

            //��X�r�ƬO2�Ӫ��W�r
            foreach (var s in takenames)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
