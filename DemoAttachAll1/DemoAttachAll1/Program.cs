using System;
using System.Collections.Generic;
using System.Linq;
using DemoEntity;

namespace DemoAttachAll1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abcd = new AddressBookDataContext();

            //�������Ƨ�
            List<TabAddressBookEntity> entities = getentities();

            //���F�ϧO�ק�@�U����
            foreach(var e in entities)
                e.Name += "_N";

            abcd.TabAddressBook.AttachAll(entities);

            //�Y�K�O��SubmitChanges��k���ξާ@�A�]���|��s��Ʈw
            abcd.SubmitChanges();

            Console.WriteLine("\n���[��DataContext���󦨥\");
            foreach (var t in abcd.TabAddressBook)
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            AddressBookDataContext abcd2 = new AddressBookDataContext();
           
            Console.WriteLine("\n��Ʈw���e�èS���P�B��s");
            foreach (var t in abcd2.TabAddressBook)
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            Console.ReadKey();
        }

        /// <summary>
        /// ����ƧǶ��X
        /// </summary>
        /// <returns></returns>
        static List<TabAddressBookEntity> getentities()
        {
            List<TabAddressBookEntity> entities = null;

            using (AddressBookDataContext abcd = new AddressBookDataContext())
            {
                entities = abcd.TabAddressBook.ToList();
            }

            return entities;
        }
    }
}
