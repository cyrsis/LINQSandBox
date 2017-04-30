using System;
using System.Collections;
using System.Data.SqlClient;
using DemoEntity;

namespace DemoTranslate3
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            using (SqlConnection connection =
               new SqlConnection(abdc.DbConnectionString))
            {
                string queryString = "select * from TabAddressBook";

                SqlCommand command =
                    new SqlCommand(queryString, connection);
                connection.Open();

                IEnumerable result = abdc.Translate(Type.GetType("DemoEntity.TabAddressBookEntity"), command.ExecuteReader());

                Console.WriteLine("輸出TabAddressBook表內容");

                foreach (var r in result)
                {
                    TabAddressBookEntity g = r as TabAddressBookEntity;
                    Console.WriteLine("{0} {1} {2} {3}",
                           g.Name, g.Sex, g.Duty, g.Age);

                }
            }

            Console.ReadKey();
        }
    }
}
