using System;
using System.Data.Linq.Mapping;
using System.IO;
using System.Linq;

namespace DemoEntity2
{
    class Program
    {
        static void Main(string[] args)
        {
            //將包含映射資訊的XML檔案轉化為 XmlMappingSource 物件
            XmlMappingSource map = XmlMappingSource.FromXml(File.ReadAllText(@"..\..\map.xml"));

            AddressBookDataContext abc = new AddressBookDataContext(map);

            var query = from g in abc.TabAddressBook
                        where g.Duty.IndexOf("公主") < 0
                        select g;

            foreach (var g in query)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Name, g.Sex, g.Duty, g.Age);


            Console.ReadKey();
        }
    }
}
