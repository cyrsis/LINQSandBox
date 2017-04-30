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

            //string filename = @"D:\��\LINQ �J��������\��5��\�{���X\DemoLinqToSql\DemoLinqToSql\TestCreateDatabase.mdf";

            ///�ഫ�۹���|��������|
            string filename = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\TestCreateDatabase.mdf");

            //string filename2 = @"D:\��\LINQ �J��������\��5��\�{���X\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf";

            ///�ഫ�۹���|��������|
            string filename2 = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\DbAddressBook.mdf");

            string filename3 = @"c:\test.mdf";

            if (Check(filename))
                Console.WriteLine("{0} ��Ʈw�ɮצs�b�C", Path.GetFileName(filename));

            if (Check(filename2))
                Console.WriteLine("{0} ��Ʈw�ɮצs�b�C", Path.GetFileName(filename2));

            if (!Check(filename3))
                Console.WriteLine("{0} ��Ʈw�ɮ� ���s�b�C", Path.GetFileName(filename3));

          
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
