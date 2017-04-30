using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoToDictionary3
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


            //使用Tel內容作為Dictionary的鍵值,Name內容作為Value值
            Dictionary<string, string> dictionary = gList.ToDictionary(guest => guest.Tel,
                g=>g.Name);

            Console.WriteLine(string.Format("gList 類型：{0}", gList.GetType().Name));
            Console.WriteLine(string.Format("dictionary 類型：{0}", dictionary.GetType().Name));

            Console.WriteLine("\ndictionary 內容：");
            foreach (string s in dictionary.Keys)
                Console.WriteLine(string.Format("鍵值：{0}，姓名：{1}", s, dictionary[s]));

            Console.ReadKey();

        }
    }
}
