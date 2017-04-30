using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DemoEntity2
{
    public class AddressBookDataContext : DataContext
    {
        private const string CONNSTR = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + "\"" +
                                     @"D:\��\LINQ �J��������\��5��\�{���X\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf" + "\"" +
                                     @";Integrated Security=True;User Instance=True";

        public AddressBookDataContext(XmlMappingSource map)
            : base(CONNSTR, map)
        {
            /// �ഫ�۹���|��������|
            /// �åͦ��s���r�Ŧ�
            string strmp = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf");

            string strconn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + "\"" +
                             @"%dbpath%" + "\"" +
                             @";Integrated Security=True;User Instance=True";

            if (System.IO.File.Exists(strmp))
            {
                this.Connection.ConnectionString = strconn.Replace("%dbpath%", strmp);
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
    }

}
