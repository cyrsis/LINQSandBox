using System;
using System.Linq;

namespace DemoCount2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            try
            {

                int icount = lst.Count(str => str.IndexOf("公主") > -1);

                Console.WriteLine("排序中元素數量為： {0} ", icount);

            }
            catch (OverflowException)
            {
                Console.WriteLine("排序中元素數量超過Int32類型的最大值。");
            }


            Console.ReadKey();

        }
    }
}
