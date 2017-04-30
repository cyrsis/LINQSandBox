using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Linq2ObjectsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //定義個字符串數組
            string[] friends = { "霓裳公主", "蕭家大小姐", "出雲公主", "苗族聖姑", "高麗公主" };

            Console.WriteLine("按照傳統的方法尋找\n");

            //初始化一個新的集合，用於儲存後面查詢到的元素
            ArrayList values = new ArrayList();

            //使用傳統的方法尋找字符串包含「公主」的詞組。
            //檢查數組把復合條件的元素放入values集合中
            foreach (string word in friends)
            {
                if (word.IndexOf("公主") > -1)
                    values.Add(word);
            }
            
            //對結果進行排序
            values.Sort();

            //檢查並輸出查詢結果
            foreach (string w in values)
                Console.WriteLine(w);

            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("使用LINQ方法查詢\n");

            //使用LINQ技術尋找包含「公主」的詞組,並對結果進行排序。
            var value = from v in friends
                        where v.IndexOf("公主") > -1
                        orderby v
                        select v;

            
            //檢查並輸出查詢結果
            foreach (var w in value)
                Console.WriteLine(w);

            //為了方便檢視執行結果，等待使用者按鍵後結束程式
            Console.ReadKey();
        }
    }
}
