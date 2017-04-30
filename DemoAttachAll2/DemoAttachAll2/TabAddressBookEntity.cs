using System.Data.Linq.Mapping;

namespace DemoEntity
{
    [Table(Name="TabAddressBook")]
    public class TabAddressBookEntity
    {
        [Column(AutoSync = AutoSync.OnInsert, DbType = "BigInt NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, Name = "ab_id",IsVersion = true)]
        public long ID
        {
            get;set;
        }


        [Column(Name = "ab_name", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
        public string Name
        {
            get;
            set;
        }

        [Column(Name = "ab_dub", DbType = "VarChar(50)")]
        public string Duty
        {
            get;
            set;
        }

        [Column(Name = "ab_sex", DbType = "VarChar(4) NOT NULL", CanBeNull = false)]
        public string Sex
        {
            get;
            set;
        }

        [Column(Name = "ab_age", DbType = "TinyInt")]
        public System.Nullable<byte> Age
        {
            get;
            set;
        }

        [Column(Name = "ab_add", DbType = "VarChar(200)")]
        public string Address
        {
            get;
            set;
        }

        [Column(Name = "ab_com", DbType = "VarChar(200)")]
        public string Company
        {
            get;
            set;
        }

        [Column(Name = "ab_tel", DbType = "Text", UpdateCheck = UpdateCheck.Never)]
        public string TelphoneNumber 
        {
            get;
            set;
        }
    }
}
