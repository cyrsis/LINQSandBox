using System;
using System.Linq;
using DemoEntity;

namespace DemoSubmitChange
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            var query = from row in abdc.TabAddressBook
                        where row.Name == "肖青漩"
                        select row;

            if (query.Count() == 1)
            {
                TabAddressBookEntity t = query.First();
                Console.WriteLine("{0} 的 電話為：{1}", t.Name, t.TelphoneNumber);

                Console.WriteLine("\n現在開始修改電話號碼為：137010877**");

                //修改電話號碼
                t.TelphoneNumber = "137010877**";

                //應用修改
                abdc.SubmitChanges();
            }

            Console.WriteLine("\n輸出全部的記錄，檢視修改結果。");
            foreach (var r in abdc.TabAddressBook)
                Console.WriteLine("{0} 的 電話為：{1}", r.Name, r.TelphoneNumber);


            Console.ReadKey();
        }
    }
}
