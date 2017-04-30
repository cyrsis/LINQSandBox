using System;
using System.IO;

namespace DemoCreateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //指定需要建立的資料庫檔案名
            //string filename = @"D:\書\LINQ 入門及應用\第5章\程式碼\DemoLinqToSql\DemoLinqToSql\TestCreateDatabase.mdf";

            /// 轉換相對路徑為絕對路徑
            /// 並生成連接字符串
            string filename = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\DbAddressBook_test.mdf");

        

            //初始化實體類
            TestCreateDatabaseDataContext dc = new TestCreateDatabaseDataContext(filename);

            if (dc.DatabaseExists())
                dc.DeleteDatabase();

            dc.CreateDatabase();

            if (dc.DatabaseExists())
                Console.WriteLine("{0} 資料庫檔案建立成功。", Path.GetFileName(filename));

            Console.ReadKey();
        }
    }
}
