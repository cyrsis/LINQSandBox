using System;
using System.Data.Linq;
using System.Linq;
using DemoEntity;

namespace DemoGetModifiedMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abcd = new AddressBookDataContext();

            TabAddressBookEntity entity = abcd.TabAddressBook.First();

            entity.Name += "_N";
            entity.Duty += "_N";
            entity.Age += 3;
            Console.WriteLine("修改後的entity實體內容");
            Console.WriteLine("{0} {1} {2} {3}",
                    entity.Name, entity.Sex, entity.Duty, entity.Age);

            ModifiedMemberInfo[] mms = abcd.TabAddressBook.GetModifiedMembers(entity);

            Console.WriteLine("\n修改過的entity成員");

            foreach (ModifiedMemberInfo m in mms)
                Console.WriteLine("{0} 成員被修改過，原始值：{1} 修改值：{2}",
                    m.Member.Name, m.OriginalValue, m.CurrentValue);

            Console.ReadKey();

        }
    }
}
