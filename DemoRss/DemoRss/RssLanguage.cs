using System;

namespace DemoRss
{
    /// <summary>
    /// Rss 語言資料
    /// </summary>
    public static class RssLanguage
    {
        /// <summary>
        /// 簡體中文
        /// </summary>
        public static string SimplifiedChinese  { get { return "zh-cn"; } }

        /// <summary>
        /// 美國英語
        /// </summary>
        public static string AmericanEnglish { get { return "en-us"; } }

        /// <summary>
        /// 獲取語言字符串
        /// </summary>
        /// <param name="lngenum">語言列舉</param>
        /// <returns>語言字符串</returns>
        public static string Language(RssLanguageEnum lngenum)
        {
            if (lngenum == RssLanguageEnum.SimplifiedChinese)
                return SimplifiedChinese;
            else
                return AmericanEnglish;
        }
    }
}
