using System;

namespace DemoDelegate2
{
    /// <summary>
    /// 自定義的事件資料類
    /// </summary>
    public class MyEnentArgs : EventArgs
    {
        /// <summary>
        /// 需要傳遞的資料
        /// </summary>
        public int Number { get; private set; }

        public MyEnentArgs(int n)
        {
            this.Number = n;
        }
    }

}
