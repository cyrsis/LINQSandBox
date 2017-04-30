using System;
using System.Linq;

namespace DemoDefaultIfEmpty
{
    class Program
    {
        static void Main(string[] args)
        {
            //定義數組
            string[] nemes = { "林晚榮", "洛凝", "董巧巧", "依蓮", "安碧如" };
            //空的int類型排序
            var intempty = Enumerable.Empty<int>();

            //沒有找的元素的排序
            var empty = from n in nemes
                        where n == "寧雨昔"
                        select n;

            Console.WriteLine("DefaultIfEmpty 返回有內容的排序");
            foreach (string s in nemes.DefaultIfEmpty())
                Console.Write(string.Format("{0} ", s));


            Console.WriteLine(string.Format("\nempty 空排序元素數：{0}", intempty.Count()));

            Console.WriteLine(string.Format("empty 空排序應用DefaultIfEmpty方法後的元素數：{0}", empty.DefaultIfEmpty().Count()));

            Console.Write(string.Format("empty 空排序應用DefaultIfEmpty方法後的元素值："));
            foreach (var s in empty.DefaultIfEmpty())
                if (s == null)
                    Console.Write("null");


            Console.WriteLine("\n\n****************************************\n");

            Console.WriteLine(string.Format("intempty 空排序元素數：{0}", intempty.Count()));

            Console.WriteLine(string.Format("intempty 空排序應用DefaultIfEmpty方法後的元素數：{0}", intempty.DefaultIfEmpty().Count()));

            Console.Write(string.Format("intempty 空排序應用DefaultIfEmpty方法後的元素值："));
            foreach (var s in intempty.DefaultIfEmpty())
                Console.Write(s);

            Console.ReadKey();
        }
    }
}
