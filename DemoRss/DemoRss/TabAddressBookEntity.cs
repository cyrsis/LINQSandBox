using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Runtime.Serialization;

namespace DemoOrder
{
    [Table(Name="TabAddressBook")]
    [DataContract()]
    public class TabAddressBookEntity
    {
        public TabAddressBookEntity()
        {
            init();
        }

        private void init()
        {
            this._TabShoppingList = new EntitySet<TabShoppingListEntity>(new Action<TabShoppingListEntity>(this.attach_TabShoppingList), new Action<TabShoppingListEntity>(this.detach_TabShoppingList));
        }

        private void attach_TabShoppingList(TabShoppingListEntity entity)
        {
            entity.TabAddressBook = this;
        }

        /// <summary>
        /// §R°£®É¨è
        /// </summary>
        /// <param name="entity"></param>
        private void detach_TabShoppingList(TabShoppingListEntity entity)
        {
            entity.TabAddressBook = null;
        }

        [Column(AutoSync = AutoSync.OnInsert, DbType = "BigInt NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, Name = "ab_id",IsVersion = true)]
        [DataMember()]
        public long MainID
        {
            get;set;
        }

        private EntitySet<TabShoppingListEntity> _TabShoppingList;
      
        [Association(Name = "TabAddressBook_TabShoppingList", Storage = "_TabShoppingList", ThisKey = "MainID", OtherKey = "AddressBookID")]
        [DataMember()]
        public EntitySet<TabShoppingListEntity> TabShoppingListEntity
        {
            get
            {
                return this._TabShoppingList;
            }
            set
            {
                if (this._TabShoppingList == null)
                    init();

                this._TabShoppingList.Assign(value);
            }
        }


        [Column(Name = "ab_name", DbType = "VarChar(10) NOT NULL", CanBeNull = false)]
        [DataMember()]
        public string Name
        {
            get;
            set;
        }

        [Column(Name = "ab_dub", DbType = "VarChar(50)")]
        [DataMember()]
        public string Duty
        {
            get;
            set;
        }

        [Column(Name = "ab_sex", DbType = "VarChar(4) NOT NULL", CanBeNull = false)]
        [DataMember()]
        public string Sex
        {
            get;
            set;
        }

        [Column(Name = "ab_age", DbType = "TinyInt")]
        [DataMember()]
        public System.Nullable<byte> Age
        {
            get;
            set;
        }

        [Column(Name = "ab_add", DbType = "VarChar(200)")]
        [DataMember()]
        public string Address
        {
            get;
            set;
        }

        [Column(Name = "ab_com", DbType = "VarChar(200)")]
        [DataMember()]
        public string Company
        {
            get;
            set;
        }

        [Column(Name = "ab_tel", DbType = "Text", UpdateCheck = UpdateCheck.Never)]
        [DataMember()]
        public string TelphoneNumber 
        {
            get;
            set;
        }
    }
}
