using System;

namespace DemoDelegate1
{
    /// <summary>
    /// 定義一個沒有返回類型的委託
    /// </summary>
    delegate void myDelgage(string s);
    
    /// <summary>
    /// 定義一個有返回類型的委託
    /// </summary>
    delegate string myDelgageString(string s, bool man);

    class Program
    {
        /// <summary>
        /// 沒有返回的方法
        /// </summary>
        static void Show1(string s)
        {
            Console.WriteLine(string.Format("  你好, {0}!", s));
        }
        static void Show2(string s)
        {
            Console.WriteLine(string.Format("  早上好, {0}!", s));
        }
        static void Show3(string s)
        {
            Console.WriteLine(string.Format("  晚上好, {0}!", s));
        }

        /// <summary>
        /// 返回字符串的方法
        /// </summary>
        static string AddTitle(string s, bool man)
        {
            if (man)
                return string.Format("  你好, {0} 先生", s);
            else
                return string.Format("  你好, {0} 女士", s);
        }

        static void Main(string[] args)
        {
            string name = "林晚榮";
            string name2 = "徐芷晴";

            //.NET 1.1 的委託實例化
            myDelgage del1 = new myDelgage(Show1);
            Console.WriteLine("  .NET 1.1 的委託呼叫");
            del1(name);
            Console.WriteLine("***********************************");

            //.NET 2.0 以上的委託實例化
            myDelgage del2 = Show1;
            Console.WriteLine("  .NET 2.0 以上的委託呼叫");
            del2(name);
            Console.WriteLine("***********************************");

            //多路委託綁定
            Console.WriteLine("  多路委託綁定呼叫");
            del2 += Show2;
            del2 += Show3;
            del2(name);
            Console.WriteLine("\n  合併掉Show1委託呼叫");
            del2 -= Show1;
            del2(name);
            Console.WriteLine("***********************************");

            //返回類型的委託
            myDelgageString del3 = AddTitle;

            Console.WriteLine("  返回類型的委託呼叫");
            Console.WriteLine(del3(name, true));
            Console.WriteLine(del3(name2, false));

            Console.ReadKey();
        }

        public event myDelgage myEvet;
    }
}
