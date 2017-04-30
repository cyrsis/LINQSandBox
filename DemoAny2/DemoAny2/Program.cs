using System;
using System.Linq;

namespace DemoAny2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            bool p = lst.Any(s => s.IndexOf("公主") > -1);
            bool p2 = lst.Any(s => s.IndexOf("仙子") > -1);

            Console.WriteLine(string.Format("是否有包含「公主」這個詞的元素：{0}", p));
            Console.WriteLine(string.Format("\n是否有包含「仙子」這個詞的元素：{0}", p2));
            Console.ReadKey();
        }
    }
}
