using System.Data.Linq.Mapping;

namespace DemoTranslate1
{
    [Table(Name = "TabShoppingList")]
    public class TabShoppingListEntity
    {
        [Column(Name = "sl_id", AutoSync = AutoSync.OnInsert, DbType = "BigInt NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public long ID
        {
            get;
            set;
        }

        [Column(Name = "sl_abid", DbType = "BigInt NOT NULL")]
        public long AddressBookID
        {
            get;
            set;
        }

        [Column(Name = "sl_pname", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
        public string Product
        {
            get;
            set;
        }

        [Column(Name = "sl_price", DbType = "Money NOT NULL")]
        public decimal Price
        {
            get;
            set;
        }

        [Column(Name = "sl_amount", DbType = "Int NOT NULL")]
        public int Amount
        {
            get;
            set;
        }

        [Column(Name = "sl_unit", DbType = "VarChar(10)")]
        public string Unit
        {
            get;
            set;
        }

        [Column(Name = "sl_indate", DbType = "DateTime")]
        public System.Nullable<System.DateTime> Date
        {
            get;
            set;
        }
    }
}
