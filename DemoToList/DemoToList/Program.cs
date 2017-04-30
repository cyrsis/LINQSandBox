using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoToList
{
    class Program
    {
        static void Main(string[] args)
        {
            ///定義數組
            string[] strarray = { "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            var query = from t in strarray
                        where t.IndexOf("公主") > -1
                        select t;

            List<string> lst = query.ToList();

            Console.WriteLine(string.Format("strarray 類型：{0}", strarray.GetType().Name));
            Console.WriteLine(string.Format("query 類型：{0}", query.GetType().Name));
            Console.WriteLine(string.Format("lst 類型：{0}", lst.GetType().Name));

            Console.Write("\nlst 內容：");
            foreach (string s in lst)
                Console.Write(string.Format(" {0}", s));

            Console.ReadKey();
        }
    }
}
