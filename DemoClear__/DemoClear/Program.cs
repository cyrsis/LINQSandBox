using System;
using System.Data.Linq;
using System.Linq;
using DemoEntity;
using DemoTranslate1;

namespace DemoClear
{
    class Program
    {
        static void Main(string[] args)
        {

            ////增加臨時資料
            apptmpdata();

            AddressBookDataContext abdc = new AddressBookDataContext();

            //獲取主控實體
            TabAddressBookEntity guest = abdc.TabAddressBook.Where(e => e.Name == "蕭玉霜").First();

            Console.WriteLine("Clear方法之前的 {0} {1} {2} {3} 所屬產品清單：",
                       guest.Name, guest.Sex, guest.Duty, guest.Age);

            foreach (var g in guest.TabShoppingListEntity)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Product, g.Price, g.Amount, g.Unit);

            guest.TabShoppingListEntity.Clear();

            //應用修改，並推理刪除掉資料庫記錄
            abdc.SubmitChanges();

            Console.WriteLine("\nClear方法之後的{0} {1} {2} {3} 所屬產品清單：",
                        guest.Name, guest.Sex, guest.Duty, guest.Age);

            ///更新資料
            abdc.Refresh(RefreshMode.OverwriteCurrentValues, guest.TabShoppingListEntity);
            foreach (var g in guest.TabShoppingListEntity)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Product, g.Price, g.Amount, g.Unit);


            Console.ReadKey();

        }

        //增加臨時資料
        static void apptmpdata()
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            TabAddressBookEntity guest = abdc.TabAddressBook.Where(e => e.Name == "蕭玉霜").First();

            EntitySet<TabShoppingListEntity> splst = guest.TabShoppingListEntity;

            for (int i = 0; i < 5; i++)
            {
                TabShoppingListEntity sp = new TabShoppingListEntity()
                {
                    Product = string.Format("臨時資料{0}",i), 
                    Unit = "個",
                    Amount = 1,
                    Price = -1,
                    AddressBookID = guest.MainID
                };

                splst.Add(sp);
                abdc.SubmitChanges();
            }
        }
    }
}
