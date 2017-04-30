using System.Data.Linq;
using System.Data.Linq.Mapping;
using DemoEntity;

namespace DemoCreateDatabase
{
    public class TestCreateDatabaseDataContext : DataContext
    {
        public TestCreateDatabaseDataContext(string mdffn)
            : base(mdffn)
        {
        }

        /// <summary>
        /// TabAddressBookªí
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
