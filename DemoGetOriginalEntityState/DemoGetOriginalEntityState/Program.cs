using System;
using System.Linq;
using DemoEntity;

namespace DemoGetOriginalEntityState
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abcd = new AddressBookDataContext();

            TabAddressBookEntity entity = abcd.TabAddressBook.First();

            entity.Name += "_N";

            Console.WriteLine("修改後的entity實體內容");
            Console.WriteLine("{0} {1} {2} {3}",
                    entity.Name, entity.Sex, entity.Duty, entity.Age);

            TabAddressBookEntity entity2 = abcd.TabAddressBook.GetOriginalEntityState(entity);

            Console.WriteLine("\n原始的entity實體內容");
            Console.WriteLine("{0} {1} {2} {3}",
                    entity2.Name, entity2.Sex, entity2.Duty, entity2.Age);

            abcd.SubmitChanges();

            TabAddressBookEntity entity3 = abcd.TabAddressBook.GetOriginalEntityState(entity);

            Console.WriteLine("\nSubmitChanges方法後的entity原始實體內容");
            Console.WriteLine("{0} {1} {2} {3}",
                    entity3.Name, entity3.Sex, entity3.Duty, entity3.Age);

            Console.ReadKey();
        }
    }
}
