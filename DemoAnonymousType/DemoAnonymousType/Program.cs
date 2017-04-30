using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoAnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            ///建立匿名類型
            var anonymous1 = new { Name = "安碧如", Title = "苗族聖姑", Age = 36 };
            var anonymous2 = new { Name = "寧雨昔", Title = "聖坊仙子", Age = 37 };

            List<string> lst = new List<string> { "高麗公主", "大華軍師", "霓裳公主" };

            Console.WriteLine(string.Format("anonymous1的類型：{0}", anonymous1.GetType().Name));
            Console.WriteLine(string.Format("{0} {1} {2}", anonymous1.Name, anonymous1.Title, anonymous1.Age));

            Console.WriteLine(string.Format("anonymous2的類型：{0}", anonymous2.GetType().Name));
            Console.WriteLine(string.Format("{0} {1} {2}", anonymous2.Name, anonymous2.Title, anonymous2.Age));

            Console.WriteLine("\n*******************************************\n");

            //LINQ select 子句中建立匿名類型
            var query = from n in lst
                        where n.IndexOf("公主") > -1
                        select new { Name = "查詢元素", Title = n };

            foreach (var item in query)
            {
                Console.WriteLine(string.Format("元素的類型：{0}", item.GetType().Name));
                Console.WriteLine(string.Format("{0} {1}", item.Name, item.Title));
            }

            Console.ReadKey();
        }
    }
}
