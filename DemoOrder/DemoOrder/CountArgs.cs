using System;

namespace DemoOrder
{
    /// <summary>
    /// �έp�����
    /// </summary>
    public class CountArgs 
    {
        public CountArgs(int acount, int count)
        {
            this.AmountCount = acount;
            this.Count = count;
        }

        /// <summary>
        /// �ƶq�X�p
        /// </summary>
        public int AmountCount
        {
            get;
            private set;
        }

        /// <summary>
        /// �X�p
        /// </summary>
        public int Count
        {
            get;
            private set;
        }
    }
}
