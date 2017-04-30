using System;
using System.Data.Linq;
using System.IO;

namespace DemoDeleteDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
          //  string filename = @"D:\書\LINQ 入門及應用\第5章\程式碼\DemoLinqToSql\DemoLinqToSql\TestCreateDatabase.mdf";

           string filename = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\DbAddressBook_test.mdf");

            string filename2 = @"c:\test.mdf";

            try
            {
                Delete(filename2);
            }
            catch
            {
                Console.WriteLine("刪除並不存在的資料庫檔案出錯。");
            }

            Delete(filename);

            if (!Check(filename))
                Console.WriteLine("{0} 資料庫檔案 被成功刪除。", Path.GetFileName(filename));
            Console.ReadKey();
        }

        static void Delete(string sfn)
        {
            using (DataContext dc = new DataContext(sfn))
            {
               dc.DeleteDatabase();
            }
        }

        static bool Check(string sfn)
        {
            bool op;

            using (DataContext dc = new DataContext(sfn))
            {
                op = dc.DatabaseExists();
            }

            return op;
        }
    }
}
