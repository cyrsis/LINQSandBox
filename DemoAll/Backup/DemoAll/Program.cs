using System;
using System.Linq;

namespace DemoAll
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lst = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            bool p = lst.All(s => s.GetTypeCode() == TypeCode.String);
            bool p2 = lst.All(s => s.IndexOf("公主")>-1);

            Console.WriteLine(string.Format("全部元素是否都是String類型：{0}", p));
            Console.WriteLine(string.Format("\n全部元素是否都包含「公主」這個詞：{0}", p2));
            Console.ReadKey();
        }
    }
}
