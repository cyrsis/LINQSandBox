using System;

namespace DemoOrder
{
    /// <summary>
    /// 反排序化結果
    /// </summary>
    public class UnserializerResult
    {
        public UnserializerResult(TabAddressBookEntity e, bool isnew)
        {
            this.IsNew = isnew;
            this.Entity = e;
        }

        /// <summary>
        /// 反排序化得到的實體
        /// </summary>
        public TabAddressBookEntity Entity{get;private set;}

        /// <summary>
        /// 是否是新增加的實體
        /// </summary>
        public bool IsNew { get; private set; }
    }
}
