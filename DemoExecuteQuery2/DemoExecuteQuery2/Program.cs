using System;
using DemoEntity;

namespace DemoExecuteQuery2
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext dc = new AddressBookDataContext();

            var rows = dc.ExecuteQuery(Type.GetType("DemoEntity.TabAddressBookEntity"), "select * from TabAddressBook where ab_age<{0}", 20);

            foreach (var r in rows)
            {
                TabAddressBookEntity t = r as TabAddressBookEntity;

                Console.WriteLine("{0} 的 電話為：{1}", t.Name, t.TelphoneNumber);
            }

            Console.ReadKey();
        }
    }
}
