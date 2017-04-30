using System;
using System.Collections.Generic;

namespace DemoVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "測試字符串";
            var i = 123456;
            var lst = new List<string>();
            var arr = new string[] { "大華軍師", "金刀可汗", "聖坊仙子", "金陵才女" };

            Console.WriteLine(string.Format("變量 str 的資料類型：{0}", str.GetType().Name));
            Console.WriteLine(string.Format("變量 i 的資料類型：{0}", i.GetType().Name));
            Console.WriteLine(string.Format("變量 lst 的資料類型：{0}", lst.GetType().Name));
            Console.WriteLine(string.Format("變量 arr 的資料類型：{0}", arr.GetType().Name));

            Console.ReadKey();
        }
    }
}
