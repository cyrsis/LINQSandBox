using System;
using DemoEntity;

namespace DemoInsertOnSubmit
{
    class Program
    {
        static void Main(string[] args)
        {
            //新增實體
            TabAddressBookEntity entity = new TabAddressBookEntity()
            {
                Name = "寧雨昔",
                Sex = "女",
                Age = 36,
                Duty = "聖坊仙子",
                TelphoneNumber = "098*-568923**"

            };

            AddressBookDataContext abdc = new AddressBookDataContext();
            abdc.TabAddressBook.InsertOnSubmit(entity);

            Console.WriteLine("InsertOnSubmit之後，SubmitChanges之前的內容");
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
