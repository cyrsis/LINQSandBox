using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoCreateDatabase;
using System.IO;
using System.Data.Linq;

namespace DemoDatabaseExists
{
    class Program
    {
        static void Main(string[] args)
        {

            //string filename = @"D:\書\LINQ 入門及應用\第5章\程式碼\DemoLinqToSql\DemoLinqToSql\TestCreateDatabase.mdf";

            ///轉換相對路徑為絕對路徑
            string filename = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\TestCreateDatabase.mdf");

            //string filename2 = @"D:\書\LINQ 入門及應用\第5章\程式碼\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf";

            ///轉換相對路徑為絕對路徑
            string filename2 = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf");

            string filename3 = @"c:\test.mdf";

            if (Check(filename))
                Console.WriteLine("{0} 資料庫檔案存在。", Path.GetFileName(filename));

            if (Check(filename2))
                Console.WriteLine("{0} 資料庫檔案存在。", Path.GetFileName(filename2));

            if (!Check(filename3))
                Console.WriteLine("{0} 資料庫檔案 不存在。", Path.GetFileName(filename3));

          
            Console.ReadKey();
        }

        static bool Check(string sfn)
        {
            bool op;

            using (TestCreateDatabaseDataContext dc = new TestCreateDatabaseDataContext(sfn))
            {
                op = dc.DatabaseExists();
            }   

            return op;
        }
    }

}
