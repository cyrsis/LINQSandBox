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
            Console.WriteLine("�ק�᪺entity���餺�e");
            Console.WriteLine("{0} {1} {2} {3}",
                    entity.Name, entity.Sex, entity.Duty, entity.Age);

            ModifiedMemberInfo[] mms = abcd.TabAddressBook.GetModifiedMembers(entity);

            Console.WriteLine("\n�ק�L��entity����");

            foreach (ModifiedMemberInfo m in mms)
                Console.WriteLine("{0} �����Q�ק�L�A��l�ȡG{1} �ק�ȡG{2}",
                    m.Member.Name, m.OriginalValue, m.CurrentValue);

            Console.ReadKey();

        }
    }
}
