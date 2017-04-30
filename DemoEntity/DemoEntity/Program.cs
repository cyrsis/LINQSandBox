using System;
using System.Linq;

namespace DemoEntity
{
    class Program
    {
        static void Main(string[] args)
        {

            AddressBookDataContext abc = new AddressBookDataContext();

            IQueryable<TabAddressBookEntity> query = from g in abc.TabAddressBook
                                                     select g;

            foreach (var g in query)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Name, g.Sex, g.Duty, g.Age);


            Console.ReadKey();

        }
    }
}
