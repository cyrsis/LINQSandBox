using System;
using System.Linq;

namespace DemoElementAt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            var item = lst.ElementAt(2);

            Console.WriteLine(string.Format("索引為2的元素：{0}", item));

            try
            {
                var itme2 = lst.ElementAt(4);
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("\n應用ElementAt方法出錯：\n{0}", e.Message));
            }

            Console.ReadKey();
        }
    }
}
