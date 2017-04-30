using System;
using DemoEntity;

namespace DemoExecuteQuery1
{
    class Program
    {

        static void Main(string[] args)
        {
            AddressBookDataContext dc = new AddressBookDataContext();

            var rows = dc.ExecuteQuery<TabAddressBookEntity>("select * from TabAddressBook where ab_age>{0}", 17);

            foreach (var r in rows)
                Console.WriteLine("{0} 的 電話為：{1}", r.Name, r.TelphoneNumber);

            Console.ReadKey();
        }
    }
}
