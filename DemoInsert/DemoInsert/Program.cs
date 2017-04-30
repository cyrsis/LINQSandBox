using System;
using System.Data.Linq;
using System.Linq;
using DemoEntity;
using DemoTranslate1;

namespace DemoInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            //獲取主控實體
            TabAddressBookEntity guest = abdc.TabAddressBook.First();

            //獲取子實體集合
            EntitySet<TabShoppingListEntity> splst = guest.TabShoppingListEntity;

            //新增子實體
            TabShoppingListEntity sp = new TabShoppingListEntity()
            {
                Product = "獨門大宅院",
                Unit = "座",
                Amount = 1,
                Price = 5000000,
                AddressBookID = guest.ID
            };

            splst.Insert(splst.Count-1,sp);

            abdc.SubmitChanges();

            Console.WriteLine("{0} {1} {2} {3} 所屬產品清單：",
                        guest.Name, guest.Sex, guest.Duty, guest.Age);

            foreach (var g in splst)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Product, g.Price, g.Amount, g.Unit);


            Console.ReadKey();
        }
    }
}
