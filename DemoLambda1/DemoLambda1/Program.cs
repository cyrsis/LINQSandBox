using System;
using System.Linq.Expressions;

namespace DemoLambda1
{
    class Program
    {
        delegate string MyDelegate(string title, string name);

        //delegate T MyDelegate2<T>(T a, T b);

        static void Main(string[] args)
        {
            //�w�qLambda��F��
            MyDelegate dele = (title, name) => string.Format("{0} {1}", title, name);

            Console.WriteLine("�I�sLambda��F��\n");
            //�I�sLambda��F��
            Console.WriteLine(dele("�X�����D", "�v�C�x"));
            Console.WriteLine(dele("�ĥ��H��", "������"));
            Console.WriteLine(dele("���a�G�p�j", "������"));

            Console.WriteLine("\n*******************\n");

            string tmp = "�ڬOLambda�y�y�~���ܶq";

            //�w�qLambda�y�y
            MyDelegate dele2 = (title, name) =>
            {
                Console.WriteLine("�qLambda�y�y�餤��X");
                Console.WriteLine(string.Format("��X�~���ܶqtmp�G{0}", tmp));
                string s;
                s = string.Format("{0} {1} �p�j", title, name);

                return s;
            };

            Console.WriteLine("�I�sLambda�y�y\n");
            //�I�sLambda��F��
            Console.WriteLine(dele2("�O�n���D", "���P��"));

         
            Console.ReadKey();
        }
    }
}
