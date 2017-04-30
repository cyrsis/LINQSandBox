using System;
using System.Linq;

namespace DemoSingleOrDefault1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lst = { "乖巧人兒" };
            int[] lst2 = { };
            string[] lst3 = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            var item = lst.SingleOrDefault();
            var item2 = lst2.SingleOrDefault();

            Console.WriteLine(string.Format("lst數組的第一個元素：{0}", item));
            Console.WriteLine(string.Format("lst2數組的第一個元素：{0}", item2));

            try
            {
                var itme3 = lst3.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("\nlst3應用SingleOrDefault方法出錯：{0}", e.Message));
            }


            Console.ReadKey();
        }
    }
}
