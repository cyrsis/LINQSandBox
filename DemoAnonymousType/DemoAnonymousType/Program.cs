using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoAnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            ///�إ߰ΦW����
            var anonymous1 = new { Name = "�w�Ѧp", Title = "�]�ڸt�h", Age = 36 };
            var anonymous2 = new { Name = "��B��", Title = "�t�{�P�l", Age = 37 };

            List<string> lst = new List<string> { "���R���D", "�j�حx�v", "�O�n���D" };

            Console.WriteLine(string.Format("anonymous1�������G{0}", anonymous1.GetType().Name));
            Console.WriteLine(string.Format("{0} {1} {2}", anonymous1.Name, anonymous1.Title, anonymous1.Age));

            Console.WriteLine(string.Format("anonymous2�������G{0}", anonymous2.GetType().Name));
            Console.WriteLine(string.Format("{0} {1} {2}", anonymous2.Name, anonymous2.Title, anonymous2.Age));

            Console.WriteLine("\n*******************************************\n");

            //LINQ select �l�y���إ߰ΦW����
            var query = from n in lst
                        where n.IndexOf("���D") > -1
                        select new { Name = "�d�ߤ���", Title = n };

            foreach (var item in query)
            {
                Console.WriteLine(string.Format("�����������G{0}", item.GetType().Name));
                Console.WriteLine(string.Format("{0} {1}", item.Name, item.Title));
            }

            Console.ReadKey();
        }
    }
}
