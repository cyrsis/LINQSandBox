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
            //�N�]�t�M�g��T��XML�ɮ���Ƭ� XmlMappingSource ����
            XmlMappingSource map = XmlMappingSource.FromXml(File.ReadAllText(@"..\..\map.xml"));

            AddressBookDataContext abc = new AddressBookDataContext(map);

            var query = from g in abc.TabAddressBook
                        where g.Duty.IndexOf("���D") < 0
                        select g;

            foreach (var g in query)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Name, g.Sex, g.Duty, g.Age);


            Console.ReadKey();
        }
    }
}
