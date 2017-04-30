using System;
using System.Data.Linq;
using System.Linq;
using DemoEntity;
using DemoTranslate1;

namespace DemoRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            ////增加臨時資料
            apptmpdata();

            AddressBookDataContext abdc = new AddressBookDataContext();

            //獲取主控實體
            TabAddressBookEntity guest = abdc.TabAddressBook.Where(e => e.Name == "董巧巧").First();

            //找到apptmpdata方法插入的臨時資料
            TabShoppingListEntity sp = guest.TabShoppingListEntity.Where(t => t.Product == "臨時資料").First();

            Console.WriteLine("Remove方法之前的 {0} {1} {2} {3} 所屬產品清單：",
                       guest.Name, guest.Sex, guest.Duty, guest.Age);

            foreach (var g in guest.TabShoppingListEntity)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Product, g.Price, g.Amount, g.Unit);


            if (guest.TabShoppingListEntity.Remove(sp))
                Console.WriteLine("\n「{0}」元素移除成功。",sp.Product);

            //應用修改，並推理刪除掉資料庫記錄
            abdc.SubmitChanges();

            Console.WriteLine("\nRemove方法之後的{0} {1} {2} {3} 所屬產品清單：",
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

            //獲取主控實體            
            //獲取子實體集合
            EntitySet<TabShoppingListEntity> splst = guest.TabShoppingListEntity;

            //新增子實體
            TabShoppingListEntity sp = new TabShoppingListEntity()
            {
                Product = "臨時資料",
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
