using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoFrom2
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

            List<GuestInfo> gList2 = new List<GuestInfo>()
            {
                new GuestInfo 
                {
                    Name = "蕭玉霜", 
                    Age = 17,
                    Tel = "137052668**" 
                },
                new GuestInfo
                {
                    Name = "秦仙兒", 
                    Age = 20,
                    Tel = "151983676**" 
                },
                new GuestInfo 
                {
                    Name = "蕭玉若", 
                    Age = 21,
                    Tel = "152987235**"
                },
            };

            //guest 表尋找Age大於20，
            //guest2 尋找Age大於17，
            //結果交叉鏈接
            var query = from guest in gList
                        where guest.Age > 20
                        from guest2 in gList2
                        where guest2.Age > 17
                        select new { guest, guest2 };

            //輸出

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} {1}", g.guest.Name, g.guest2.Name));

            Console.ReadKey();
        }
    }
}
