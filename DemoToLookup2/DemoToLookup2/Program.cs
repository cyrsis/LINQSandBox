using System;
using System.Collections.Generic;
using System.Linq;
using DemoDistinct2;
using DemoLinq;

namespace DemoToLookup2
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


            //使用姓作為Lookup的鍵值
            ILookup<string, GuestInfo> lookup = gList.ToLookup(guest => guest.Name.Substring(0, 1), new MyEqualityComparer<string>());

            Console.WriteLine(string.Format("gList 類型：{0}", gList.GetType().Name));
            Console.WriteLine(string.Format("lookup 類型：{0}", lookup.GetType().Name));

            Console.WriteLine("\nlookup 內容：");
            foreach (var k in lookup)
            {
                Console.WriteLine(string.Format("鍵值：{0}", k.Key));
                foreach (var v in k)
                    Console.WriteLine(string.Format("姓名：{0}，年齡：{1}", v.Name, v.Age));

                Console.WriteLine("****************************");
            }
            Console.ReadKey();
        }
    }
}
