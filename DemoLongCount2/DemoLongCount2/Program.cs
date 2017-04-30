using System;
using System.Linq;

namespace DemoLongCount2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            long lcount = lst.LongCount(str => str.IndexOf("公主") > -1);

            Console.WriteLine("排序中元素數量為： {0} ", lcount);

            Console.ReadKey();
        }
    }
}
