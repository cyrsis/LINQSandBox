using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoLet
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
                    Name = "林晚榮", 
                    Age = 21, 
                    Tel = "026*-888888**" },
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


            ///姓"肖"或姓 "董"的客戶
            var query = from guest in gList
                        let g = guest.Name.Substring(0,1)
                        where g == "肖" || g == "董"
                        select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} 年齡:{1} 電話:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();
        }
    }
}
