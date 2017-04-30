using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoFrom1
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化集合
            List<GuestInfo> gList = new List<GuestInfo>()
            {
                new GuestInfo { 
                    Name = "林晚榮", 
                    Age = 21,  
                    TelTable = new List<string>(){ 
                        "026*-888888**",
                        "13802588***"} 
                },
                new GuestInfo { 
                    Name = "寧雨昔", 
                    Age = 36,  
                    TelTable = new List<string>(){ 
                        "098*-568923**",
                        "132679856**"} 
                },
                new GuestInfo { 
                    Name = "洛凝",
                    Age = 19,  
                    TelTable = new List<string>(){ 
                        "033*-985690**",
                        "153129057**"}
                },
            };

            //尋找 電話號碼 ：132679856** 屬於哪個客戶
            var query = from guest in gList
                        from tel in guest.TelTable
                        where tel.IndexOf("132679856**") > -1
                        select guest;

            //輸出
            foreach (var g in query)
            {
                Console.WriteLine(string.Format("{0} 年齡:{1}", g.Name, g.Age));
                foreach (var t in g.TelTable)
                    Console.WriteLine(string.Format("       電話：{0}", t));
            }

            Console.ReadKey();
        }
    }
}
