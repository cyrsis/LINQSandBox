using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoWhere1
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



            ///名字是2個字或者姓"肖" 
            ///並且 年齡大於等於19的客戶
            var query = from guest in gList
                        where (guest.Name.Length == 2 ||
                                guest.Name.Substring(0, 1) == "肖") &&
                                guest.Age >= 19

                        select guest;


            foreach (var g in query)
                Console.WriteLine(string.Format("{0} 年齡:{1} 電話:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();
        }
    }
}
