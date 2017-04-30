using System.Data.Linq.Mapping;

namespace DemoEntity2
{
    /// <summary>
    ///   不包含映射資訊的 TabAddressBook 表格的實體類
    /// </summary>
    public class TabAddressBookEntity
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Duty { get; set; }

        public string Sex { get; set; }

        public System.Nullable<byte> Age { get; set; }

        public string Address { get; set; }

        public string Company { get; set; }

        public string TelphoneNumber { get; set; }

    }
}
