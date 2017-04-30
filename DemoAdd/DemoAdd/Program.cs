using System;
using System.Data.Linq;
using System.Linq;
using DemoEntity;
using DemoTranslate1;

namespace DemoAdd
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
                Product = "3克拉鑽石戒指",
                Unit = "個",
                Amount = 1,
                Price = 60000,
                AddressBookID = guest.ID
            };

            splst.Add(sp);

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
