using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using DemoEntity;

namespace DemoTranslate1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            using (SqlConnection connection =
               new SqlConnection(abdc.DbConnectionString))
            {
                string queryString = "select * from TabAddressBook;select * from TabShoppingList;";

                SqlCommand command =
                    new SqlCommand(queryString, connection);
                connection.Open();

                IMultipleResults result = abdc.Translate(command.ExecuteReader());


                Console.WriteLine("輸出TabAddressBook表內容");

                IEnumerable<TabAddressBookEntity> tab1 = result.GetResult<TabAddressBookEntity>();

                foreach (var g in tab1)
                    Console.WriteLine("{0} {1} {2} {3}",
                            g.Name, g.Sex, g.Duty, g.Age);

                Console.WriteLine("\n輸出TabShoppingList表內容");

                IEnumerable<TabShoppingListEntity> tab2 = result.GetResult<TabShoppingListEntity>();

                foreach (var g in tab2)
                    Console.WriteLine("{0} 價格：{1} 數量：{2} {3}",
                            g.Product, g.Price, g.Amount, g.Unit);
            }

            Console.ReadKey();
        }
    }
}
