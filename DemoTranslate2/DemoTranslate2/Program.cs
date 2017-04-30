using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DemoEntity;
using DemoTranslate1;

namespace DemoTranslate2
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            using (SqlConnection connection =
               new SqlConnection(abdc.DbConnectionString))
            {
                string queryString = "select * from TabShoppingList";

                SqlCommand command =
                    new SqlCommand(queryString, connection);
                connection.Open();

                IEnumerable<TabShoppingListEntity> result = abdc.Translate <TabShoppingListEntity>(command.ExecuteReader());

                Console.WriteLine("輸出TabShoppingList表內容");

                foreach (var g in result)
                    Console.WriteLine("{0} 價格：{1} 數量：{2} {3}",
                            g.Product, g.Price, g.Amount, g.Unit);
            }

            Console.ReadKey();
        }
    }
}
