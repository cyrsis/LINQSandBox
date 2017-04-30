using System;
using DemoEntity;
using System.Linq;

namespace DemoGetTable
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext dc = new AddressBookDataContext();

            var tab1 = dc.GetTable<TabAddressBookEntity>();

            var rows1 = from g in tab1 select g;

            var tab2 = dc.GetTable(Type.GetType("DemoEntity.TabAddressBookEntity"));

            var rows2 = from TabAddressBookEntity g in tab2 select g;

           Console.WriteLine("排序 rows1 和 排序 rows2 是否相等:{0}",rows1.AsEnumerable().SequenceEqual(rows2));

           Console.ReadKey();
        }
    }
}
