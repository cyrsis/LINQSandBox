using System;
using System.Linq;

namespace DemoSingle2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "乖巧人兒", "霓裳公主", "蕭家二小姐", "出雲公主" };

            var item = lst.Single(str => str.IndexOf("小姐") > -1);

            try
            {
                var item2 = lst.Single(str => str.IndexOf("公主") > -1);
            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("應用Single方法出錯：{0}", e.Message));
            }

            Console.WriteLine(string.Format("\n數組唯一符合條件的元素：{0}", item));

            Console.ReadKey();
        }
    }
}
