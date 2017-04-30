using System.Data.Linq;
using System.Data.Linq.Mapping;
using DemoTranslate1;

namespace DemoEntity
{
    [DatabaseAttribute(Name="DbAddressBook")]
    public class AddressBookDataContext : DataContext
    {
        private const string CONNSTR = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + "\"" +
                                     @"D:\��\LINQ �J��������\��5��\�{���X\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf" + "\"" +
                                     @";Integrated Security=True;User Instance=True";

        private string _DbConnectionString;
        public string DbConnectionString
        {
            get
            {
                return _DbConnectionString;
            }
        }

        public AddressBookDataContext() : base(CONNSTR)
        {
            _DbConnectionString = CONNSTR;

            /// �ഫ�۹���|��������|
            /// �åͦ��s���r�Ŧ�
            string strmp = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf");

            string strconn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + "\"" +
                             @"%dbpath%" + "\"" +
                             @";Integrated Security=True;User Instance=True";

            if (System.IO.File.Exists(strmp))
            {
                _DbConnectionString = strconn.Replace("%dbpath%", strmp);
                this.Connection.ConnectionString = _DbConnectionString;

            }
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
