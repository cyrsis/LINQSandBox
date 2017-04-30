using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoAsEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FirstLinqToSqlDataContext contex = new FirstLinqToSqlDataContext(Properties.Settings.Default.DbAddressBookConnectionString))
            {
                IQueryable<TabAddressBook> rows = from r in contex.TabAddressBook
                           select r;

                Console.WriteLine("���ӥ��`�����ǿ�X�O��");
                foreach (var n in rows)
                    Console.WriteLine(n.ab_name);


                Console.WriteLine("\n���ӤϦV���ǿ�X�O��");

                try
                {
                    foreach (var n in rows.Reverse())
                        Console.WriteLine(n.ab_name);
                }
                catch (Exception e)
                {

                    Console.WriteLine(string.Format("�bIQueryable�����W�ϥ�Reverse��k�X��\n�X����T:{0}",e.Message));

                    Console.WriteLine("\n�ഫ��IEnumerable�����ϦV���ǿ�X");

                    IEnumerable<TabAddressBook> rows2 = rows.AsEnumerable();

                    foreach (var n in rows2.Reverse())
                        Console.WriteLine(n.ab_name);
                }
            }

            Console.ReadKey();
        }
    }
}
