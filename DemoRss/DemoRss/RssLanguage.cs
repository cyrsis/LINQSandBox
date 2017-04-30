using System;

namespace DemoRss
{
    /// <summary>
    /// Rss �y�����
    /// </summary>
    public static class RssLanguage
    {
        /// <summary>
        /// ²�餤��
        /// </summary>
        public static string SimplifiedChinese  { get { return "zh-cn"; } }

        /// <summary>
        /// ����^�y
        /// </summary>
        public static string AmericanEnglish { get { return "en-us"; } }

        /// <summary>
        /// ����y���r�Ŧ�
        /// </summary>
        /// <param name="lngenum">�y���C�|</param>
        /// <returns>�y���r�Ŧ�</returns>
        public static string Language(RssLanguageEnum lngenum)
        {
            if (lngenum == RssLanguageEnum.SimplifiedChinese)
                return SimplifiedChinese;
            else
                return AmericanEnglish;
        }
    }
}
