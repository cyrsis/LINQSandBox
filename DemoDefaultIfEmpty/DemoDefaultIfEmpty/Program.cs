using System;
using System.Linq;

namespace DemoDefaultIfEmpty
{
    class Program
    {
        static void Main(string[] args)
        {
            //�w�q�Ʋ�
            string[] nemes = { "�L�ߺa", "����", "������", "�̽�", "�w�Ѧp" };
            //�Ū�int�����Ƨ�
            var intempty = Enumerable.Empty<int>();

            //�S���䪺�������Ƨ�
            var empty = from n in nemes
                        where n == "��B��"
                        select n;

            Console.WriteLine("DefaultIfEmpty ��^�����e���Ƨ�");
            foreach (string s in nemes.DefaultIfEmpty())
                Console.Write(string.Format("{0} ", s));


            Console.WriteLine(string.Format("\nempty �űƧǤ����ơG{0}", intempty.Count()));

            Console.WriteLine(string.Format("empty �űƧ�����DefaultIfEmpty��k�᪺�����ơG{0}", empty.DefaultIfEmpty().Count()));

            Console.Write(string.Format("empty �űƧ�����DefaultIfEmpty��k�᪺�����ȡG"));
            foreach (var s in empty.DefaultIfEmpty())
                if (s == null)
                    Console.Write("null");


            Console.WriteLine("\n\n****************************************\n");

            Console.WriteLine(string.Format("intempty �űƧǤ����ơG{0}", intempty.Count()));

            Console.WriteLine(string.Format("intempty �űƧ�����DefaultIfEmpty��k�᪺�����ơG{0}", intempty.DefaultIfEmpty().Count()));

            Console.Write(string.Format("intempty �űƧ�����DefaultIfEmpty��k�᪺�����ȡG"));
            foreach (var s in intempty.DefaultIfEmpty())
                Console.Write(s);

            Console.ReadKey();
        }
    }
}
