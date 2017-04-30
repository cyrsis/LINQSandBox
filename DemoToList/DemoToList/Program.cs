using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoToList
{
    class Program
    {
        static void Main(string[] args)
        {
            ///�w�q�Ʋ�
            string[] strarray = { "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            var query = from t in strarray
                        where t.IndexOf("���D") > -1
                        select t;

            List<string> lst = query.ToList();

            Console.WriteLine(string.Format("strarray �����G{0}", strarray.GetType().Name));
            Console.WriteLine(string.Format("query �����G{0}", query.GetType().Name));
            Console.WriteLine(string.Format("lst �����G{0}", lst.GetType().Name));

            Console.Write("\nlst ���e�G");
            foreach (string s in lst)
                Console.Write(string.Format(" {0}", s));

            Console.ReadKey();
        }
    }
}
