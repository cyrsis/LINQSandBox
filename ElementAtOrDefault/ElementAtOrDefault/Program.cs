using System;
using System.Linq;

namespace ElementAtOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };
            int[] lst2 = { 10, 100, 1000, 1000 };

            var item = lst.ElementAtOrDefault(2);
            var itme2 = lst2.ElementAtOrDefault(4);


            Console.WriteLine(string.Format("索引為2的元素：{0}", item));
            Console.WriteLine(string.Format("\n返回lst2的元素預設值：{0}", itme2));

            Console.ReadKey();
        }
    }
}
