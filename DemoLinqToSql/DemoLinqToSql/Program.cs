using System;
using System.Linq;

namespace DemoLinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化實體類
            AddresBookDataClassesDataContext ad = new AddresBookDataClassesDataContext();

            IQueryable<TabAddressBook> query = from g in ad.TabAddressBook
                                               where g.ab_dub.IndexOf("公主") > -1
                                               select g;


            foreach (var g in query)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.ab_name, g.ab_sex, g.ab_dub, g.ab_age);
              
            Console.ReadKey();

        }
    }
}
