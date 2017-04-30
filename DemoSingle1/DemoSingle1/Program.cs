using System;
using System.Linq;

namespace DemoSingle1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "乖巧人兒" };
            string[] lst2 = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            var item = lst.Single();

            try
            {
                var itme2 = lst2.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("lst2應用Single方法出錯：{0}", e.Message));
            }

            Console.WriteLine(string.Format("\nlst數組的唯一元素：{0}", item));

            Console.ReadKey();
        }
    }
}
