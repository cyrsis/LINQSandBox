using System;
using System.Linq;
using System.Collections;
using DemoLinq;

namespace DemoLinq2
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化ArrayList
            ArrayList gList = new ArrayList();
            gList.Add(
                new GuestInfo { Name = "林晚榮", Age = 21, Tel = "888888**" }
                );

            gList.Add(
                   new GuestInfo { Name = "寧雨昔", Age = 36, Tel = "568923**" }
                   );

            gList.Add(
                   new GuestInfo { Name = "洛凝", Age = 19, Tel = "985690**" }
                   );

            //查詢 年齡大於 19 的客戶
            var query = from GuestInfo guest in gList
                        where guest.Age > 19
                        select guest;

            //輸出
            foreach (GuestInfo g in query)
                Console.WriteLine(string.Format("{0} 年齡:{1} 電話:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();

        }
    }
}
