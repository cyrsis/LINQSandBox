using System;

namespace DemoAnonymousMethod
{
    class Program
    {
        delegate void DemoDelegate();
        static void Main(string[] args)
        {
            //�إ߰ΦW��k
            DemoDelegate dele = delegate { Console.WriteLine("�q�ΦW��k����X"); };

            //�I�s�ΦW��k
            dele();

            Console.ReadKey();
        }
    }
}
