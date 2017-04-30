using System;
using System.Data.Linq;
using System.IO;

namespace DemoDeleteDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
          //  string filename = @"D:\��\LINQ �J��������\��5��\�{���X\DemoLinqToSql\DemoLinqToSql\TestCreateDatabase.mdf";

           string filename = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\DbAddressBook_test.mdf");

            string filename2 = @"c:\test.mdf";

            try
            {
                Delete(filename2);
            }
            catch
            {
                Console.WriteLine("�R���ä��s�b����Ʈw�ɮץX���C");
            }

            Delete(filename);

            if (!Check(filename))
                Console.WriteLine("{0} ��Ʈw�ɮ� �Q���\�R���C", Path.GetFileName(filename));
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
