using System;
using System.Linq.Expressions;

namespace DemoLambda1
{
    class Program
    {
        delegate string MyDelegate(string title, string name);

        //delegate T MyDelegate2<T>(T a, T b);

        static void Main(string[] args)
        {
            //定義Lambda表達式
            MyDelegate dele = (title, name) => string.Format("{0} {1}", title, name);

            Console.WriteLine("呼叫Lambda表達式\n");
            //呼叫Lambda表達式
            Console.WriteLine(dele("出雲公主", "肖青漩"));
            Console.WriteLine(dele("乖巧人兒", "董巧巧"));
            Console.WriteLine(dele("蕭家二小姐", "蕭玉霜"));

            Console.WriteLine("\n*******************\n");

            string tmp = "我是Lambda語句外的變量";

            //定義Lambda語句
            MyDelegate dele2 = (title, name) =>
            {
                Console.WriteLine("從Lambda語句體中輸出");
                Console.WriteLine(string.Format("輸出外部變量tmp：{0}", tmp));
                string s;
                s = string.Format("{0} {1} 小姐", title, name);

                return s;
            };

            Console.WriteLine("呼叫Lambda語句\n");
            //呼叫Lambda表達式
            Console.WriteLine(dele2("霓裳公主", "秦仙兒"));

         
            Console.ReadKey();
        }
    }
}
