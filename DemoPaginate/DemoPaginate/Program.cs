using System;
using System.Linq;

namespace DemoPaginate
{
    class Program
    {
        static void Main(string[] args)
        {
            //當前頁碼
            int ipage = 0;
            //每頁記錄數
            int ipagesize = 2;

            //定義數組
            string[] nemes = { "林晚榮", "洛凝", "董巧巧", "出雲公主", "依蓮", "安碧如" };

            Console.WriteLine(string.Format("輸出第 {0} 頁記錄", ipage));
            //輸出第 0 頁記錄
            var q = nemes.Skip(ipagesize * ipage).Take(ipagesize);
            foreach (string s in q)
                Console.WriteLine(s);

            ipage++;
            Console.WriteLine(string.Format("\n輸出第 {0} 頁記錄", ipage));
            //輸出第 1 頁記錄
            var q2 = nemes.Skip(ipagesize * ipage).Take(ipagesize);
            foreach (string s in q2)
                Console.WriteLine(s);

            ipage++;
            Console.WriteLine(string.Format("\n輸出第 {0} 頁記錄", ipage));
            //輸出第 2 頁記錄
            var q3 = nemes.Skip(ipagesize * ipage).Take(ipagesize);
            foreach (string s in q3)
                Console.WriteLine(s);

            Console.ReadKey();


        }
    }
}
