using System;
using System.Collections.Generic;
using System.Linq;
using DemoDistinct2;
using DemoLinq;

namespace DemoToDictionary4
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
                    Name = "蕭玉霜", 
                    Age = 17, 
                    Tel = "053*-985690**" },
                new GuestInfo 
                { 
                    Name = "蕭玉若", 
                    Age = 21, 
                    Tel = "035*-120967**" 
                },
                new GuestInfo 
                { 
                    Name = "徐長今", 
                    Age = 18, 
                    Tel = "039*-967512**" 
                },
                new GuestInfo 
                { 
                    Name = "徐芷晴", 
                    Age = 24, 
                    Tel = "089*-569832**" 
                }
            };
 

            //使用Name內容作為Dictionary的鍵值，Tel內容作為Value值
            Dictionary<string, string> dictionary = gList.ToDictionary(guest => guest.Name,g => g.Tel, new MyEqualityComparer<string>());

            Console.WriteLine(string.Format("gList 類型：{0}", gList.GetType().Name));
            Console.WriteLine(string.Format("dictionary 類型：{0}", dictionary.GetType().Name));

            Console.WriteLine("\n檢查是否有不能透過鍵值存取的元素");
            foreach (var s in dictionary)
            {
                if (!dictionary.Keys.Contains(s.Key))
                    Console.WriteLine(string.Format("鍵值為 {0} 的內容，不能透過鍵值存取。", s.Key));
            }

            Console.WriteLine("\n檢查dictionary全部的元素");
            foreach (var s in dictionary)
                Console.WriteLine(string.Format("鍵值：{0}，電話：{1}", s.Key, s.Value));

            Console.ReadKey();

        }
    }
}
