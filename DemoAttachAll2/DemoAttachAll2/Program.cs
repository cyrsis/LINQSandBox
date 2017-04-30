using System;
using System.Collections.Generic;
using System.Linq;
using DemoEntity;

namespace DemoAttachAll2
{
    class Program
    {
        static void Main(string[] args)
        {

            AddressBookDataContext abcd = new AddressBookDataContext();

            //獲取實體排序
            List<TabAddressBookEntity> entities = getentities();

           // List<TabAddressBookEntity> entities2 = getentities();

            //修改元素
            foreach (var e in entities)
                e.Name += "_N";

            abcd.TabAddressBook.AttachAll(entities,true);

            abcd.SubmitChanges();

            Console.WriteLine("\n附加到DataContext物件成功");
            foreach (var t in abcd.TabAddressBook)
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            AddressBookDataContext abcd2 = new AddressBookDataContext();

            Console.WriteLine("\n資料庫內容同步更新");
            foreach (var t in abcd2.TabAddressBook)
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);


            //AddressBookDataContext abcd3 = new AddressBookDataContext();
            //abcd3.TabAddressBook.AttachAll(entities2, true);
            //abcd3.SubmitChanges();

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
