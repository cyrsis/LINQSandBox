using System;

namespace DemoCSharpEditor
{
    /// <summary>
    /// 光标所在的词
    /// </summary>
    public class CurrentWord
    {
        /// <summary>
        /// 起始位置
        /// </summary>
        public int StartIndex { get; set; }

        /// <summary>
        /// 结束位置
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// 词
        /// </summary>
        public string Word { get; set; }

    }
}
