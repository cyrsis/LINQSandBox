using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoSelect1
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化集合
            List<GuestInfo> gList = new List<GuestInfo>()
            {
                new GuestInfo 
                { 
                    Name = "寧雨昔", 
                    Age = 36, 
                    Tel = "098*-568923**" },
                new GuestInfo 
                { 
                    Name = "肖青漩", 
                    Age = 21, 
                    Tel = "017*-876543**" 
                },
                new GuestInfo 
                { 
                    Name = "董巧巧", 
                    Age = 19, 
                    Tel = "029*-981256**" 
                },
            };


            //篩選年齡小於30的客戶資訊並投影成MyGuestInfo類型
            var query = from guest in gList
                        where guest.Age < 30
                        select new MyGuestInfo { Name = guest.Name, Tel = guest.Tel };

            foreach (var g in query)
                Console.WriteLine(string.Format("{0}  電話:{1} 類型：{2}", g.Name, g.Tel, g.ToString()));

            Console.ReadKey();
        }
    }
}
