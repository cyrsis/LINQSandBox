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

                Console.WriteLine("按照正常的順序輸出記錄");
                foreach (var n in rows)
                    Console.WriteLine(n.ab_name);


                Console.WriteLine("\n按照反向順序輸出記錄");

                try
                {
                    foreach (var n in rows.Reverse())
                        Console.WriteLine(n.ab_name);
                }
                catch (Exception e)
                {

                    Console.WriteLine(string.Format("在IQueryable類型上使用Reverse方法出錯\n出錯資訊:{0}",e.Message));

                    Console.WriteLine("\n轉換為IEnumerable類型反向順序輸出");

                    IEnumerable<TabAddressBook> rows2 = rows.AsEnumerable();

                    foreach (var n in rows2.Reverse())
                        Console.WriteLine(n.ab_name);
                }
            }

            Console.ReadKey();
        }
    }
}
