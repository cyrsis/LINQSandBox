using System;
using System.Linq;

namespace DemoFirst2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "乖巧人兒", "霓裳公主", "蕭家二小姐", "出雲公主" };

            var item = lst.First(str=>str.IndexOf("公主")>-1);

            Console.WriteLine(string.Format("數組的第一個符合條件的元素：{0}", item));

            Console.ReadKey();
        }
    }
}
