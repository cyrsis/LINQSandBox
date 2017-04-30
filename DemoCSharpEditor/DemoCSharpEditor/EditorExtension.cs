using System;
using System.Linq;

namespace DemoCSharpEditor
{
    /// <summary>
    /// String 扩展
    /// </summary>
    public static class EditorExtension
    {
        /// <summary>
        /// 单词分隔字符数组
        /// </summary>
        public static char[] SplitChar = { ' ', ',', '.', ';', '\n', '{', '}', '\r', Convert.ToChar(9),'(',')','[',']' };

        /// <summary>
        /// 检测字符是否分割字符
        /// </summary>
        public static bool IsSplit(this Char chr)
        {

            var query = SplitChar.Where(c => c == chr);

            if (query.Count<char>() > 0)
                return true;
            else
                return false;
        }


        /// <summary>
        /// 检测字符串最后一个字符是否是分割字符
        /// </summary>
        public static bool LastCharIsSplit(this string str, int cursorinde)
        {
            if (cursorinde < 1)
                return false;

            var sec = from c in SplitChar
                      where c == str[cursorinde - 1]
                      select c;

            if (sec.Count<char>() > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 光标所在的单词
        /// </summary>
        public static CurrentWord CursorWord(this string str, int cursorindex)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            if (cursorindex < 2)
                return null;

            int i = str.LastIndexOfAny(SplitChar, cursorindex - 2);
            int ed = cursorindex - 2;

            if (ed < 1)
                ed = str.Length;

            if (i < 0)
                i = 0;
            else
                i = i + 1;

            if (ed < str.Length)
            {
                //光标不在字符串尾部,向后搜索
                ed = str.IndexOfAny(SplitChar, ed);
            }

            if (ed < 0)
                return null;

            char lastc = str[ed - 1];
            if (lastc.IsSplit())
                ed = ed - 1;

            ed = ed - i;

            if (ed < 1)
                return null;

            return new CurrentWord
            {
                StartIndex = i,
                Length = ed,
                Word = str.Substring(i, ed)
            };
        }
    }
}
