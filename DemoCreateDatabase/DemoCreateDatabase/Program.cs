using System;
using System.IO;

namespace DemoCreateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //���w�ݭn�إߪ���Ʈw�ɮצW
            //string filename = @"D:\��\LINQ �J��������\��5��\�{���X\DemoLinqToSql\DemoLinqToSql\TestCreateDatabase.mdf";

            /// �ഫ�۹���|��������|
            /// �åͦ��s���r�Ŧ�
            string filename = System.IO.Path.GetFullPath(@"..\..\..\..\DemoLinqToSql\DemoLinqToSql\DbAddressBook_test.mdf");

        

            //��l�ƹ�����
            TestCreateDatabaseDataContext dc = new TestCreateDatabaseDataContext(filename);

            if (dc.DatabaseExists())
                dc.DeleteDatabase();

            dc.CreateDatabase();

            if (dc.DatabaseExists())
                Console.WriteLine("{0} ��Ʈw�ɮ׫إߦ��\�C", Path.GetFileName(filename));

            Console.ReadKey();
        }
    }
}
