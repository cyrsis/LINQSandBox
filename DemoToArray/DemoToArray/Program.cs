using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ///定義List
            List<string> lst = new List<string>{ "出雲公主", "乖巧人兒", "蕭家二小姐", "霓裳公主" };

            var query = from t in lst
                        where t.IndexOf("公主") > -1
                        select t;

            string[] strarray = query.ToArray();

            Console.WriteLine(string.Format("lst 類型：{0}", lst.GetType().Name));
            Console.WriteLine(string.Format("query 類型：{0}", query.GetType().Name));
            Console.WriteLine(string.Format("strarray 類型：{0}", strarray.GetType().Name));
            
            Console.Write("\nstrarray 內容：");
            foreach (string s in strarray)
                Console.Write(string.Format(" {0}", s));

            Console.ReadKey();
        }
    }
}
