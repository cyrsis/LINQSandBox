using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ///�w�qList
            List<string> lst = new List<string>{ "�X�����D", "�ĥ��H��", "���a�G�p�j", "�O�n���D" };

            var query = from t in lst
                        where t.IndexOf("���D") > -1
                        select t;

            string[] strarray = query.ToArray();

            Console.WriteLine(string.Format("lst �����G{0}", lst.GetType().Name));
            Console.WriteLine(string.Format("query �����G{0}", query.GetType().Name));
            Console.WriteLine(string.Format("strarray �����G{0}", strarray.GetType().Name));
            
            Console.Write("\nstrarray ���e�G");
            foreach (string s in strarray)
                Console.Write(string.Format(" {0}", s));

            Console.ReadKey();
        }
    }
}
