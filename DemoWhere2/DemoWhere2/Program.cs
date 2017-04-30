using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoWhere2
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

            //尋找名字是3個字並且第一個字是「董」的資訊
            var query = from guest in gList
                        where guest.Name.Length == 3 &&
                                Check(guest.Name)

                        select guest;


            foreach (var g in query)
                Console.WriteLine(string.Format("{0} 年齡:{1} 電話:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();

        }

        /// <summary>
        /// 自定義函數 
        /// 檢測是否姓「董」
        /// </summary>
        static bool Check(string name)
        {
            if (name.Substring(0, 1) == "董")
                return true;

            return false;
        }
    }
}
