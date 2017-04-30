using System;
using System.Linq;

namespace DemoLongCount1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            long lcount = lst.LongCount();

            Console.WriteLine("排序中元素數量為： {0} ", lcount);

            Console.ReadKey();
        }
    }
}
