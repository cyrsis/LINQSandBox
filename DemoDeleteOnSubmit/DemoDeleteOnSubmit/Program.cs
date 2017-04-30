using System;
using System.Linq;
using DemoEntity;

namespace DemoDeleteOnSubmit
{
    class Program
    {
        static void Main(string[] args)
        {

            TabAddressBookEntity entity = new TabAddressBookEntity()
            {
                Name = "示範記錄",
                Sex = "-",
                Age = 0,
                Duty = "用於示範刪除記錄",
                TelphoneNumber = "******"

            };

            AddressBookDataContext abdc = new AddressBookDataContext();
            //先增加一個用於示範的記錄
            abdc.TabAddressBook.InsertOnSubmit(entity);
            abdc.SubmitChanges();


            //找到剛剛增加的示範記錄
            TabAddressBookEntity entitydel = (from v in abdc.TabAddressBook
                                             where v.Name == entity.Name
                                             select v
                                             ).First();


            abdc.TabAddressBook.DeleteOnSubmit(entitydel);

            Console.WriteLine("DeleteOnSubmit之後，SubmitChanges之前的內容");
            foreach (var t in abdc.TabAddressBook)
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            abdc.SubmitChanges();

            Console.WriteLine("\nSubmitChanges之後的內容");
            foreach (var t in abdc.TabAddressBook)
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);


            Console.ReadKey();
        }
    }
}
