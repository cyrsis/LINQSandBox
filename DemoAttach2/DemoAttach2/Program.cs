using System;
using System.Linq;
using DemoEntity;

namespace DemoAttach2
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立一個實體，準備更新資料庫
            TabAddressBookEntity tn = new TabAddressBookEntity { ID = 1, Name = "肖_附加", Age = 21, Duty = "出雲公主", Sex = "女", TelphoneNumber = "017*-876543**" };

            //建立一個實體，這個實體的資料庫一致，作為源資料
            TabAddressBookEntity tn2 = new TabAddressBookEntity { ID = 1, Name = "肖青漩", Age = 21, Duty = "出雲公主", Sex = "女", TelphoneNumber = "017*-876543**" };


            AddressBookDataContext abcd2 = new AddressBookDataContext();
            Console.WriteLine("原始的資料庫內容");
            foreach (var t in abcd2.TabAddressBook.Where(row => row.ID == tn.ID))
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            AddressBookDataContext abcd = new AddressBookDataContext();

            abcd.TabAddressBook.Attach(tn, tn2);
            
            //應用操作
            abcd.SubmitChanges();

            //更新獲取新資料
            abcd2.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, abcd2.TabAddressBook.Where(row => row.ID == tn.ID));

            Console.WriteLine("\n附加到DataContext對象，並同步更新了資料庫");
            foreach (var t in abcd2.TabAddressBook.Where(row => row.ID == tn.ID))
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);


            AddressBookDataContext abcd3 = new AddressBookDataContext();
            abcd3.TabAddressBook.Attach(tn2, tn);
            abcd3.SubmitChanges();

            Console.ReadKey();
        }
    }
}
