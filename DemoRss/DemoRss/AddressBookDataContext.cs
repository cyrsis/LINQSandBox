using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DemoOrder
{
    [DatabaseAttribute(Name="DbAddressBook")]
    public class AddressBookDataContext : DataContext
    {
        private const string CONNSTR = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + "\"" +
                                     @"D:\��\LINQ �J��������\��5��\�{���X\DemoLinqToSql\DemoLinqToSql\2DbAddressBook.mdf" + "\"" +
                                     @";Integrated Security=True;User Instance=True";

        public string DbConnectionString
        {
            get
            {
                return CONNSTR;
            }
        }

        public AddressBookDataContext() : base(CONNSTR)
        {
        }

        /// <summary>
        /// TabAddressBook��
        /// </summary>
        public Table<TabAddressBookEntity> TabAddressBook
        {
            get
            {
                return this.GetTable<TabAddressBookEntity>();
            }
        }


        /// <summary>
        /// TabShoppingList��
        /// </summary>
        public Table<TabShoppingListEntity> TabShoppingList
        {
            get
            {
                return this.GetTable<TabShoppingListEntity>();
            }
        }
    }
}
