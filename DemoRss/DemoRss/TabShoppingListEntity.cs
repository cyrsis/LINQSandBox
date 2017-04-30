using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Runtime.Serialization;

namespace DemoOrder
{
    [Table(Name = "TabShoppingList")]
    [DataContract()]
    public class TabShoppingListEntity
    {
        private EntityRef<TabAddressBookEntity> _TabAddressBook = default(EntityRef<TabAddressBookEntity>);

        [Association(Name = "TabAddressBook_TabShoppingList", Storage = "_TabAddressBook", ThisKey = "AddressBookID", OtherKey = "MainID", IsForeignKey = true, DeleteOnNull = true)]
        public TabAddressBookEntity TabAddressBook
        {
            get
            {
                return this._TabAddressBook.Entity;
            }
            set
            {
                TabAddressBookEntity previousValue = this._TabAddressBook.Entity;
                if (((previousValue != value)
                            || (this._TabAddressBook.HasLoadedOrAssignedValue == false)))
                {
                    if ((previousValue != null))
                    {
                        this._TabAddressBook.Entity = null;
                        previousValue.TabShoppingListEntity.Remove(this);
                    }
                    this._TabAddressBook.Entity = value;
                    if ((value != null))
                    {
                        value.TabShoppingListEntity.Add(this);
                        this.AddressBookID = value.MainID;
                    }
                    else
                    {
                        this.AddressBookID = default(long);
                    }
                }
            }
        }

        [Column(Name = "sl_id", AutoSync = AutoSync.OnInsert, DbType = "BigInt NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        [DataMember()]
        public long ID
        {
            get;
            set;
        }

        [Column(Name = "sl_abid", DbType = "BigInt NOT NULL", CanBeNull = false)]
        [DataMember()]
        public long AddressBookID
        {
            get;
            set;
        }

        [Column(Name = "sl_pname", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
        [DataMember()]
        public string Product
        {
            get;
            set;
        }

        [Column(Name = "sl_price", DbType = "Money NOT NULL")]
        [DataMember()]
        public decimal Price
        {
            get;
            set;
        }

        [Column(Name = "sl_amount", DbType = "Int NOT NULL")]
        [DataMember()]
        public int Amount
        {
            get;
            set;
        }

        [Column(Name = "sl_unit", DbType = "VarChar(10)")]
        [DataMember()]
        public string Unit
        {
            get;
            set;
        }

        [Column(Name = "sl_indate", DbType = "DateTime")]
        [DataMember()]
        public System.Nullable<System.DateTime> Date
        {
            get;
            set;
        }
    }
}
