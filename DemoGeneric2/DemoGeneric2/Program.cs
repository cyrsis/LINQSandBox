using System;
using System.Collections.Generic;
using System.Collections;

namespace DemoGeneric2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            List<int> lst = new List<int>();

            //ArrayList 計時開始
            DateTime dt = DateTime.Now;

            //將100萬個元素加入ArrayList
            for (int i = 0; i < 1000000; i++)
                arr.Add(i);

            //ArrayList 計時段
            TimeSpan ts1 = DateTime.Now - dt;

            //List 計時開始
            dt = DateTime.Now;

            //將100萬個元素加入List
            for (int i = 0; i < 1000000; i++)
                lst.Add(i);

            //List 計時段
            TimeSpan ts2 = DateTime.Now - dt;


            Console.WriteLine(string.Format("ArrayList 耗時：{0} ms", ts1.Milliseconds));
            Console.WriteLine(string.Format("List<T> 耗時：{0} ms", ts2.Milliseconds));

            Console.ReadKey();
        }
    }
}
