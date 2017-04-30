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
            //SQL Server 連接字符串
            string sqlsrv = "Data Source=(local);Initial Catalog=DbAddressBook;Integrated Security=True";

            //SQL Server Express檔案
           // string sqlexp = @"D:\書\LINQ 入門及應用\第5章\程式碼\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf";
            //轉換相對路徑為絕對路徑
            string sqlexp = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf");

            int pagesize = 2;
            int pagenum = 0;

            DataContext dcsql = new DataContext(sqlsrv);
            Table<TabAddressBookEntity> sqlsrvtab = dcsql.GetTable<TabAddressBookEntity>();

            var sqlsrvrows = sqlsrvtab.Skip(pagesize * pagenum).Take(pagesize);
            Console.WriteLine("從SQL Server讀取記錄\n");
            foreach (var g in sqlsrvrows)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Name, g.Sex, g.Duty, g.Age);
            Console.WriteLine("******************************");

            pagenum = 1;

            DataContext dcsqlexp = new DataContext(sqlexp);
            Table<TabAddressBookEntity> sqlexptab = dcsqlexp.GetTable<TabAddressBookEntity>();

            var sqlexprows = sqlexptab.Skip(pagesize * pagenum).Take(pagesize);
            Console.WriteLine("從SQL Server Express讀取記錄\n");
            foreach (var g in sqlexprows)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Name, g.Sex, g.Duty, g.Age);


            Console.ReadKey();

        }
    }
}
