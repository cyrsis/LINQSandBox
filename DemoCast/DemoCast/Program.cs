using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DemoCast
{
    class Program
    {
        static void Main(string[] args)
        {
            //定義ArrayList
            //由於ArrayList沒有實現泛型IEnumerable<T>接口，
            //所以無法用集合初始化器 
            ArrayList nemes = new ArrayList();
            nemes.Add( "林晚榮");
            nemes.Add( "洛凝");
            nemes.Add( "董巧巧");
            nemes.Add( "依蓮");

            IEnumerable<string> newnames = nemes.Cast<string>();

            foreach (string s in newnames)
                Console.Write(string.Format("{0} ",s));

            Console.ReadKey();
        }
    }
}
