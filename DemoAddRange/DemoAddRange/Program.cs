using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using DemoEntity;
using DemoTranslate1;

namespace DemoAddRange
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            //獲取主控實體
            TabAddressBookEntity guest = abdc.TabAddressBook.Where(e => e.Name == "董巧巧").First();

            //獲取子實體集合
            EntitySet<TabShoppingListEntity> splst = guest.TabShoppingListEntity;

            //新增子實體集合
            List<TabShoppingListEntity> sps = new List<TabShoppingListEntity>
            {
               new TabShoppingListEntity{ 
                   Product = "1克拉鑽石戒指",
                   Unit = "個",
                   Amount = 1,
                   Price = 60000,
                   AddressBookID = guest.ID
               },
               new TabShoppingListEntity{ 
                   Product = "旺角酒樓",
                   Unit = "座",
                   Amount = 1,
                   Price = 1000000,
                   AddressBookID = guest.ID
               }
            };


            splst.AddRange(sps);

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
