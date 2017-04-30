using System;

namespace DemoGeneric1
{
    /// <summary>
    /// 泛型類
    /// </summary>
    public class GenericClass<T>
    {
        /// <summary>
        /// 泛型類型的字段
        /// </summary>
        private T value;

        /// <summary>
        /// 泛型類型的內容
        /// </summary>
        public T Value
        {
            get
            {
                return value;
            }
        }

        /// <summary>
        /// 帶泛型參數的函數
        /// </summary>
        /// <param name="input"></param>
        public void Add(T input) 
        {
            this.value = input;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //使用字符串類型
            GenericClass<string> str = new GenericClass<string>();
            str.Add("字符串測試");
            Console.WriteLine(string.Format("Value 類型：{0}", str.Value.GetType().Name));
            Console.WriteLine(string.Format("Value：{0}", str.Value));

            Console.WriteLine("******************************");

            //使用 int 類型
            GenericClass<int> intc = new GenericClass<int>();
            intc.Add(123456);
            Console.WriteLine(string.Format("Value 類型：{0}", intc.Value.GetType().Name));
            Console.WriteLine(string.Format("Value：{0}", intc.Value));


            Console.ReadKey();
        }
    }
}
