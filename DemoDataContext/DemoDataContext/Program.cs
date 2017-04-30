using System;
using System.Data.Linq;
using System.Linq;
using DemoEntity;

namespace DemoDataContext
{
    class Program
    {
        static void Main(string[] args)
        {
            //SQL Server �s���r�Ŧ�
            string sqlsrv = "Data Source=(local);Initial Catalog=DbAddressBook;Integrated Security=True";

            //SQL Server Express�ɮ�
           // string sqlexp = @"D:\��\LINQ �J��������\��5��\�{���X\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf";
            //�ഫ�۹���|��������|
            string sqlexp = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf");

            int pagesize = 2;
            int pagenum = 0;

            DataContext dcsql = new DataContext(sqlsrv);
            Table<TabAddressBookEntity> sqlsrvtab = dcsql.GetTable<TabAddressBookEntity>();

            var sqlsrvrows = sqlsrvtab.Skip(pagesize * pagenum).Take(pagesize);
            Console.WriteLine("�qSQL ServerŪ���O��\n");
            foreach (var g in sqlsrvrows)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Name, g.Sex, g.Duty, g.Age);
            Console.WriteLine("******************************");

            pagenum = 1;

            DataContext dcsqlexp = new DataContext(sqlexp);
            Table<TabAddressBookEntity> sqlexptab = dcsqlexp.GetTable<TabAddressBookEntity>();

            var sqlexprows = sqlexptab.Skip(pagesize * pagenum).Take(pagesize);
            Console.WriteLine("�qSQL Server ExpressŪ���O��\n");
            foreach (var g in sqlexprows)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Name, g.Sex, g.Duty, g.Age);


            Console.ReadKey();

        }
    }
}
