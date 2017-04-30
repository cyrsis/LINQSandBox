using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoInto
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

            //按照名字的第一個字進行分組並用分組key進行排序
            Console.WriteLine("into用於group子句的分組時刻");
            var query = from guest in gList
                        group guest by guest.Name.Substring(0, 1) into grguest
                        orderby grguest.Key descending
                        select grguest;

            //檢查分組資料
            foreach (var guestGroup in query)
            {
                //輸出當前分組的鍵值
                Console.WriteLine(string.Format("分組鍵：{0} \n", guestGroup.Key));

                //檢查組內元素
                foreach (var g in guestGroup)
                    Console.WriteLine(string.Format("{0}  電話:{1}", g.Name, g.Tel));
                Console.WriteLine("\n**********************************\n");
            }

            Console.WriteLine("\ninto用於select子句的投影時刻");

            //select 子句中 的 info 子句使用
            var query2 = from guest in gList
                         select new{NewName = guest.Name, NewAge = guest.Age} into newguest
                         orderby newguest.NewAge
                         select newguest;
                             
            //檢查分組資料
            foreach (var g in query2)
            {
                Console.WriteLine(string.Format("{0} 年齡：{1}", g.NewName,g.NewAge));
            }

            Console.ReadKey();
        }
    }
}
