using System;

namespace DemoDelegate1
{
    /// <summary>
    /// �w�q�@�ӨS����^�������e�U
    /// </summary>
    delegate void myDelgage(string s);
    
    /// <summary>
    /// �w�q�@�Ӧ���^�������e�U
    /// </summary>
    delegate string myDelgageString(string s, bool man);

    class Program
    {
        /// <summary>
        /// �S����^����k
        /// </summary>
        static void Show1(string s)
        {
            Console.WriteLine(string.Format("  �A�n, {0}!", s));
        }
        static void Show2(string s)
        {
            Console.WriteLine(string.Format("  ���W�n, {0}!", s));
        }
        static void Show3(string s)
        {
            Console.WriteLine(string.Format("  �ߤW�n, {0}!", s));
        }

        /// <summary>
        /// ��^�r�Ŧꪺ��k
        /// </summary>
        static string AddTitle(string s, bool man)
        {
            if (man)
                return string.Format("  �A�n, {0} ����", s);
            else
                return string.Format("  �A�n, {0} �k�h", s);
        }

        static void Main(string[] args)
        {
            string name = "�L�ߺa";
            string name2 = "�}�鴸";

            //.NET 1.1 ���e�U��Ҥ�
            myDelgage del1 = new myDelgage(Show1);
            Console.WriteLine("  .NET 1.1 ���e�U�I�s");
            del1(name);
            Console.WriteLine("***********************************");

            //.NET 2.0 �H�W���e�U��Ҥ�
            myDelgage del2 = Show1;
            Console.WriteLine("  .NET 2.0 �H�W���e�U�I�s");
            del2(name);
            Console.WriteLine("***********************************");

            //�h���e�U�j�w
            Console.WriteLine("  �h���e�U�j�w�I�s");
            del2 += Show2;
            del2 += Show3;
            del2(name);
            Console.WriteLine("\n  �X�ֱ�Show1�e�U�I�s");
            del2 -= Show1;
            del2(name);
            Console.WriteLine("***********************************");

            //��^�������e�U
            myDelgageString del3 = AddTitle;

            Console.WriteLine("  ��^�������e�U�I�s");
            Console.WriteLine(del3(name, true));
            Console.WriteLine(del3(name2, false));

            Console.ReadKey();
        }

        public event myDelgage myEvet;
    }
}
