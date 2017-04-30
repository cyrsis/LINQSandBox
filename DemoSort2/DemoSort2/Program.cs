using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoSort2
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
                    Name = "月牙兒", 
                    Age = 18, 
                    Tel = "067*-781256**" 
                },
                new GuestInfo 
                { 
                    Name = "徐長今", 
                    Age = 18, 
                    Tel = "039*-967512**" 
                },
                new GuestInfo 
                { 
                    Name = "依蓮", 
                    Age = 18, 
                    Tel = "098*-231238**" 
                },
                new GuestInfo 
                { 
                    Name = "董巧巧", 
                    Age = 19, 
                    Tel = "029*-981256**" 
                },
            };

            Console.WriteLine("按照年齡進行排序、按照名字字數進行次要排序");
            ///按照年齡進行排序、按照名字字數進行次要排序
            var query = from guest in gList
                        orderby guest.Age,guest.Name.Length
                        select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} 年齡:{1} 電話:{2}", g.Name, g.Age, g.Tel));

            Console.WriteLine("\n按照年齡進行排序、按照名字字數進行降序次要排序");

            ///按照年齡進行排序、按照名字字數進行降序次要排序
            query = from guest in gList
                    orderby guest.Age, guest.Name.Length descending
                    select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} 年齡:{1} 電話:{2}", g.Name, g.Age, g.Tel));


            Console.WriteLine("\n按照年齡進行排序、名字字數、電話排序");

            ///按照年齡進行排序、按照名字字數進行次要排序、按照電話進行第三條件排序
            query = from guest in gList
                    orderby guest.Age, guest.Name.Length, guest.Tel
                    select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} 年齡:{1} 電話:{2}", g.Name, g.Age, g.Tel));

          

            Console.ReadKey();
        }
    }
}
