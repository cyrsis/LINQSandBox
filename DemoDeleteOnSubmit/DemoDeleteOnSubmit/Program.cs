using System;
using System.Linq;
using DemoEntity;

namespace DemoDeleteOnSubmit
{
    class Program
    {
        static void Main(string[] args)
        {

            TabAddressBookEntity entity = new TabAddressBookEntity()
            {
                Name = "�ܽd�O��",
                Sex = "-",
                Age = 0,
                Duty = "�Ω�ܽd�R���O��",
                TelphoneNumber = "******"

            };

            AddressBookDataContext abdc = new AddressBookDataContext();
            //���W�[�@�ӥΩ�ܽd���O��
            abdc.TabAddressBook.InsertOnSubmit(entity);
            abdc.SubmitChanges();


            //�����W�[���ܽd�O��
            TabAddressBookEntity entitydel = (from v in abdc.TabAddressBook
                                             where v.Name == entity.Name
                                             select v
                                             ).First();


            abdc.TabAddressBook.DeleteOnSubmit(entitydel);

            Console.WriteLine("DeleteOnSubmit����ASubmitChanges���e�����e");
            foreach (var t in abdc.TabAddressBook)
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            abdc.SubmitChanges();

            Console.WriteLine("\nSubmitChanges���᪺���e");
            foreach (var t in abdc.TabAddressBook)
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);


            Console.ReadKey();
        }
    }
}
