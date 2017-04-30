using System;
using System.Collections.Generic;
using System.Linq;
using DemoEntity;

namespace DemoAttachAll1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abcd = new AddressBookDataContext();

            //獲取實體排序
            List<TabAddressBookEntity> entities = getentities();

            //為了區別修改一下元素
            foreach(var e in entities)
                e.Name += "_N";

            abcd.TabAddressBook.AttachAll(entities);

            //即便是用SubmitChanges方法應用操作，也不會更新資料庫
            abcd.SubmitChanges();

            Console.WriteLine("\n附加到DataContext物件成功");
            foreach (var t in abcd.TabAddressBook)
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            AddressBookDataContext abcd2 = new AddressBookDataContext();
           
            Console.WriteLine("\n資料庫內容並沒有同步更新");
            foreach (var t in abcd2.TabAddressBook)
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            Console.ReadKey();
        }

        /// <summary>
        /// 獲取排序集合
        /// </summary>
        /// <returns></returns>
        static List<TabAddressBookEntity> getentities()
        {
            List<TabAddressBookEntity> entities = null;

            using (AddressBookDataContext abcd = new AddressBookDataContext())
            {
                entities = abcd.TabAddressBook.ToList();
            }

            return entities;
        }
    }
}
