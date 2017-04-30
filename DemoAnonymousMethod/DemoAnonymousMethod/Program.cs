using System;

namespace DemoAnonymousMethod
{
    class Program
    {
        delegate void DemoDelegate();
        static void Main(string[] args)
        {
            //建立匿名方法
            DemoDelegate dele = delegate { Console.WriteLine("從匿名方法中輸出"); };

            //呼叫匿名方法
            dele();

            Console.ReadKey();
        }
    }
}
