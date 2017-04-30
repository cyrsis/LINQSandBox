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

           Console.WriteLine("�Ƨ� rows1 �M �Ƨ� rows2 �O�_�۵�:{0}",rows1.AsEnumerable().SequenceEqual(rows2));

           Console.ReadKey();
        }
    }
}
