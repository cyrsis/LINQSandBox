using System;

namespace DemoOrder
{
    /// <summary>
    /// 統計資料類
    /// </summary>
    public class CountArgs 
    {
        public CountArgs(int acount, int count)
        {
            this.AmountCount = acount;
            this.Count = count;
        }

        /// <summary>
        /// 數量合計
        /// </summary>
        public int AmountCount
        {
            get;
            private set;
        }

        /// <summary>
        /// 合計
        /// </summary>
        public int Count
        {
            get;
            private set;
        }
    }
}
