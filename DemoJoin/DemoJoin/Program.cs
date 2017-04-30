using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化客戶集合
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
                 new GuestInfo 
                { 
                    Name = "徐芷晴", 
                    Age = 24, 
                    Tel = "089*-569832**" 
                }
            };

            ///初始化客戶職務集合
            List<GuestTitle> titleList = new List<GuestTitle>()
            {
                new GuestTitle{ Name = "林晚榮", Tilte = "金刀漢王"},
                new GuestTitle{ Name = "林晚榮", Tilte = "天下第一丁"},
                new GuestTitle{ Name = "肖青漩", Tilte = "出雲公主"},
                new GuestTitle{ Name = "董巧巧", Tilte = "酒店CEO"},
                new GuestTitle{ Name = "董巧巧", Tilte = "乖巧人兒"}
            };

            Console.WriteLine("內部聯接");
            //根據姓名進行內部聯接
            var query = from guest in gList
                        join title in titleList on guest.Name equals title.Name
                        select new { Name = guest.Name, Title = title.Tilte, Age = guest.Age };


            foreach (var g in query)
                Console.WriteLine(string.Format("{0} {1} 年齡:{2}", g.Title, g.Name, g.Age));


            Console.WriteLine("\n根據姓名進行分組聯接");

            //根據姓名進行分組聯接
            var query2 = from guest in gList
                         join title in titleList on guest.Name equals title.Name into tgroup
                         select new { Name = guest.Name, Titles = tgroup };

            foreach (var g in query2)
            {
                Console.WriteLine(g.Name);
                foreach (var g2 in g.Titles)
                    Console.WriteLine(string.Format("   {0}", g2.Tilte));
            }


            Console.WriteLine("\n左外部聯接");
            //根據姓名進行左外部聯接
            var query3 = from guest in gList
                         join title in titleList on guest.Name equals title.Name into tgroup
                         from subtitle in tgroup.DefaultIfEmpty()
                         select new { Name = guest.Name, Title = (subtitle == null ? "空缺" : subtitle.Tilte)} ;

            foreach (var g in query3)
                Console.WriteLine(string.Format("{0} {1}", g.Title, g.Name));

            Console.ReadKey();

        }
    }
}
