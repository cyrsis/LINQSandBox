using System.Collections.Generic;

namespace DemoLinq
{
    /// <summary>
    /// 客戶資訊
    /// </summary>
    public class GuestInfo
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 年齡
        /// </summary>
        public int Age { set; get; }

        /// <summary>
        /// 電話
        /// </summary>
        public string Tel { set; get; }

        /// <summary>
        /// 電話表
        /// </summary>
        public List<string> TelTable { set; get; }

    }
}
