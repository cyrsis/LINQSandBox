using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoSort1
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
                    Name = "寧雨昔", 
                    Age = 36, 
                    Tel = "098*-568923**" 
                },
                new GuestInfo 
                { 
                    Name = "董巧巧", 
                    Age = 19, 
                    Tel = "029*-981256**" 
                },
            };

            Console.WriteLine("按照年齡升序進行排序");
            ///按照年齡升序進行排序
            var query = from guest in gList
                        orderby guest.Age
                        select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} 年齡:{1} 電話:{2}", g.Name, g.Age, g.Tel));


            Console.WriteLine("\n按照年齡降序進行排序");

            ///按照年齡降序進行排序
            query = from guest in gList
                    orderby guest.Age descending
                    select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} 年齡:{1} 電話:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();

        }
    }
}
