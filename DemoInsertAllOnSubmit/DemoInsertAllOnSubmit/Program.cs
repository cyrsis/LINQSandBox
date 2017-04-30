using System;
using System.Collections.Generic;
using DemoEntity;

namespace DemoInsertAllOnSubmit
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
                    Name = "徐長今",
                    Sex = "女",
                    Age = 18,
                    Duty = "高麗公主",
                    TelphoneNumber = "039*-967512**"

                },
                new TabAddressBookEntity()
                {
                    Name = "徐芷晴",
                    Sex = "女",
                    Age = 24,
                    Duty = "大華軍師",
                    TelphoneNumber = "089*-569832**"

                }
            };


            AddressBookDataContext abdc = new AddressBookDataContext();
            abdc.TabAddressBook.InsertAllOnSubmit(entitys);

            Console.WriteLine("InsertAllOnSubmit之後，SubmitChanges之前的內容");
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
