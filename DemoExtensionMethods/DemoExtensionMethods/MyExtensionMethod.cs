using System;
using System.Text.RegularExpressions;

namespace DemoExtensionMethods
{
    public static class MyExtensionMethod
    {
        /// <summary>
        /// ��UBB�{���X�榡�Ʀ�HTML�챵���X�R��k
        /// </summary>
        public static string UbbToHtmlLink(this string link)
        {
            string sp = @"(?is)\[a\](.+?)\[\/a\]";

            return Regex.Replace(link, sp, "<a href=\"$1\">$1</a>");
        }

        /// <summary>
        /// �˴��O�_�����ƪ��X�R��k
        /// </summary>
        public static bool IsEven(this int i)
        {
            return (i % 2) == 0;
        }

        /// <summary>
        /// �� Program ���W�[�X�R��k
        /// </summary>
        public static void ExtensionShow(this Program p)
        {
            Console.WriteLine("�q�X�R��k�����");
        }
    }
}
