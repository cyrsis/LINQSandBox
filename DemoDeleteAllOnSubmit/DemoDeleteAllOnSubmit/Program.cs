using System;
using System.Collections.Generic;
using System.Linq;
using DemoEntity;

namespace DemoDeleteAllOnSubmit
{
    class Program
    {
        static void Main(string[] args)
        {
            //新增實體排序
            List<TabAddressBookEntity> entitys = new List<TabAddressBookEntity>
            {
                new TabAddressBookEntity()
                {
                    Name = "示範記錄1",
                    Sex = "-",
                    Age = 0,
                    Duty = "用於示範刪除記錄",
                    TelphoneNumber = "******"

                },
                new TabAddressBookEntity()
                {
                    Name = "示範記錄2",
                    Sex = "-",
                    Age = 0,
                    Duty = "用於示範刪除記錄",
                    TelphoneNumber = "******"

                }
            };


            AddressBookDataContext abdc = new AddressBookDataContext();
            //先增加三個用於示範的記錄
            abdc.TabAddressBook.InsertAllOnSubmit(entitys);
            abdc.SubmitChanges();


            //找到剛剛增加的示範記錄集合
            IEnumerable<TabAddressBookEntity> entitysdel = from v in abdc.TabAddressBook
                                                        where v.Age == 0
                                                        select v;



            abdc.TabAddressBook.DeleteAllOnSubmit(entitysdel);

            Console.WriteLine("DeleteAllOnSubmit之後，SubmitChanges之前的內容");
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
