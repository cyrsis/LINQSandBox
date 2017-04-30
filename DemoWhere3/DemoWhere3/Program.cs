using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoWhere3
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

            //定義動態述詞數組
            string[] names = { "徐長今", "蕭玉若", "肖青漩", "月牙兒" };

            //尋找包含在動態述詞數組中的名字
            var query = from guest in gList
                        where names.Contains(guest.Name)
                        select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} 年齡:{1} 電話:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();

        }
    }
}
