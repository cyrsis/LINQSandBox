using System;
using System.Linq;
using DemoEntity;

namespace DemoAttach1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abcd = new AddressBookDataContext();

            //建立一個實體，資料庫中存在這個包含這個主鍵的記錄
            TabAddressBookEntity tn = new TabAddressBookEntity { ID = 1, Name = "肖青漩", Age = 21, Duty = "出雲公主", Sex = "女", TelphoneNumber = "017*-876543**" };

            //從資料庫得到實體，這個實體的主鍵跟tn一樣
            TabAddressBookEntity tn2 = abcd.TabAddressBook.First();

            try
            {
                abcd.TabAddressBook.Attach(tn);
            }
            catch (Exception e)
            {
                Console.WriteLine("附加DataContext已經跟蹤的實體產生執行錯誤：");
                Console.WriteLine(e.Message);
            }


            AddressBookDataContext abcd2 = new AddressBookDataContext();
            abcd2.TabAddressBook.Attach(tn);
            //即便是用SubmitChanges方法應用操作，也不會更新資料庫
            abcd2.SubmitChanges();

            //為了顯示tn附加成功，將修改Name內容
            tn.Name += "_附加";

            Console.WriteLine("\n附加到另外的DataContext物件成功");
            foreach (var t in abcd2.TabAddressBook.Where(row => row.ID == tn.ID))
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);


            Console.WriteLine("\n資料庫內容並沒有同步更新");
            foreach (var t in abcd.TabAddressBook.Where(row => row.ID == tn.ID))
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            Console.ReadKey();
        }
    }
}
