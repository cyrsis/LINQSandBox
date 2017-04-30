using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using DemoEntity;

namespace DemoGetChangeSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //準備需要修改的資料
            Dictionary<string, string> chg = new Dictionary<string, string>();
            chg.Add("董巧巧", "151066867**");
            chg.Add("蕭玉霜", "137052668**");

            AddressBookDataContext abdc = new AddressBookDataContext();

            //獲取需要修改的記錄
            var query = from r in abdc.TabAddressBook
                        where chg.Keys.Contains(r.Name)
                        select r;

            foreach (var r in query)
            {
                Console.WriteLine("\n{0} 的當前的電話為：{1}", r.Name, r.TelphoneNumber);
                Console.WriteLine("現在修改電話號碼為：{0}", chg[r.Name]);
                //修改電話號碼
                r.TelphoneNumber = chg[r.Name];
            }

            //獲取修改的對象
            ChangeSet cs = abdc.GetChangeSet();

            Console.WriteLine("\n輸出修改過的對象");

            foreach (var r in cs.Updates)
            {
                TabAddressBookEntity t = r as TabAddressBookEntity;
                Console.WriteLine("{0} 的 電話為：{1}", t.Name, t.TelphoneNumber);
            }

            //應用修改
            //abdc.SubmitChanges();

            Console.ReadKey();
        }
    }
}
