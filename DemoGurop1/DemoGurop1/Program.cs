using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoGurop1
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


            ////按照名字的第一個字進行分組
            //var query = from guest in gList
            //            group guest by guest.Name.Substring(0, 1);

            ////檢查分組資料
            //foreach (IGrouping<string, GuestInfo> guestGroup in query)
            //{
            //    //輸出當前分組的鍵值
            //    Console.WriteLine(string.Format("分組鍵：{0} \n", guestGroup.Key));

            //    //檢查組內元素
            //    foreach (var g in guestGroup)
            //        Console.WriteLine(string.Format("{0}  電話:{1}", g.Name, g.Tel));
            //    Console.WriteLine("\n**********************************\n");
            //}



    //按照年齡是否大於20分組
    var query = from guest in gList
                group guest by guest.Age > 20;

    //檢查分組資料
    foreach (var guestGroup in query)
    {
        //輸出當前分組的鍵值
        //Console.WriteLine(string.Format("年齡是否大於 20 分組鍵：{0} \n", guestGroup.Key));

        //檢查組內元素
        foreach (var g in guestGroup)
            Console.WriteLine(string.Format("{0}  電話:{1}", g.Name, g.Tel));
        Console.WriteLine("\n**********************************\n");
    }

            Console.ReadKey();
        }
    }
}
