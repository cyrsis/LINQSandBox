using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DemoOrder
{
    [DatabaseAttribute(Name="DbAddressBook")]
    public class AddressBookDataContext : DataContext
    {
        private const string CONNSTR = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + "\"" +
                                     @"D:\書\LINQ 入門及應用\第5章\程式碼\DemoLinqToSql\DemoLinqToSql\2DbAddressBook.mdf" + "\"" +
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
        /// TabAddressBook表
        /// </summary>
        public Table<TabAddressBookEntity> TabAddressBook
        {
            get
            {
                return this.GetTable<TabAddressBookEntity>();
            }
        }


        /// <summary>
        /// TabShoppingList表
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
