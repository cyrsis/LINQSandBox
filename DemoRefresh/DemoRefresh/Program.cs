using System;
using System.Linq;
using DemoEntity;

namespace DemoRefresh
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            var query = from row in abdc.TabAddressBook
                        where row.Name == "肖青漩"
                        select row;

            if (query.Count() == 1)
            {
                TabAddressBookEntity t = query.First();

                Console.WriteLine("{0} 的 電話為：{1}", t.Name, t.TelphoneNumber);

                //在其他方法中修改記錄
                chg();

                Console.WriteLine("不應用Refresh方法。");
                Console.WriteLine("{0} 的 電話為：{1}", t.Name, t.TelphoneNumber);
                
                //更新實體物件
                abdc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, t);

                Console.WriteLine("應用Refresh方法後。");
                Console.WriteLine("{0} 的 電話已經被更新為：{1}", t.Name, t.TelphoneNumber);
            }

            Console.ReadKey();

        }

        /// <summary>
        /// 修改資料
        /// </summary>
        static void chg()
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            var query = from row in abdc.TabAddressBook
                        where row.Name == "肖青漩"
                        select row;

            if (query.Count() == 1)
            {
                TabAddressBookEntity t = query.First();
                Console.WriteLine("\n在其他的方法中，為 {0} 修改電話號碼", t.Name);

                //修改電話號碼
                t.TelphoneNumber = "017*-876543**";

                //應用修改
                abdc.SubmitChanges();

                Console.WriteLine("修改完畢。\n");
            }

        }
    }
}
