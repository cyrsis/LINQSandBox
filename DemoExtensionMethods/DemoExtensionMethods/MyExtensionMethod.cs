using System;
using System.Text.RegularExpressions;

namespace DemoExtensionMethods
{
    public static class MyExtensionMethod
    {
        /// <summary>
        /// 把UBB程式碼格式化成HTML鏈接的擴充方法
        /// </summary>
        public static string UbbToHtmlLink(this string link)
        {
            string sp = @"(?is)\[a\](.+?)\[\/a\]";

            return Regex.Replace(link, sp, "<a href=\"$1\">$1</a>");
        }

        /// <summary>
        /// 檢測是否為偶數的擴充方法
        /// </summary>
        public static bool IsEven(this int i)
        {
            return (i % 2) == 0;
        }

        /// <summary>
        /// 給 Program 類增加擴充方法
        /// </summary>
        public static void ExtensionShow(this Program p)
        {
            Console.WriteLine("從擴充方法中顯示");
        }
    }
}
