using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using DemoTranslate1;

namespace DemoEntity
{
    [Table(Name="TabAddressBook")]
    public class TabAddressBookEntity
    {
        public TabAddressBookEntity()
        {
            this._TabShoppingList = new EntitySet<TabShoppingListEntity>(new Action<TabShoppingListEntity>(this.attach_TabShoppingList), new Action<TabShoppingListEntity>(this.detach_TabShoppingList));
        }

        private void attach_TabShoppingList(TabShoppingListEntity entity)
        {
            entity.TabAddressBook = this;
        }

        /// <summary>
        /// �R���ɨ�
        /// </summary>
        /// <param name="entity"></param>
        private void detach_TabShoppingList(TabShoppingListEntity entity)
        {
            entity.TabAddressBook = null;
        }

        [Column(AutoSync = AutoSync.OnInsert, DbType = "BigInt NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, Name = "ab_id")]
        public long MainID
        {
            get;set;
        }

        private EntitySet<TabShoppingListEntity> _TabShoppingList;
      
        [Association(Name = "TabAddressBook_TabShoppingList", Storage = "_TabShoppingList", ThisKey = "MainID", OtherKey = "AddressBookID")]
        public EntitySet<TabShoppingListEntity> TabShoppingListEntity
        {
            get
            {
                return this._TabShoppingList;
            }
            set
            {
                this._TabShoppingList.Assign(value);
            }
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
