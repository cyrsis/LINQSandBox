using System;
using System.Collections.Generic;
using System.Linq;
using DemoEntity;

namespace DemoDeleteAllOnSubmit
{
    class Program
    {
        static void Main(string[] args)
        {
            //�s�W����Ƨ�
            List<TabAddressBookEntity> entitys = new List<TabAddressBookEntity>
            {
                new TabAddressBookEntity()
                {
                    Name = "�ܽd�O��1",
                    Sex = "-",
                    Age = 0,
                    Duty = "�Ω�ܽd�R���O��",
                    TelphoneNumber = "******"

                },
                new TabAddressBookEntity()
                {
                    Name = "�ܽd�O��2",
                    Sex = "-",
                    Age = 0,
                    Duty = "�Ω�ܽd�R���O��",
                    TelphoneNumber = "******"

                }
            };


            AddressBookDataContext abdc = new AddressBookDataContext();
            //���W�[�T�ӥΩ�ܽd���O��
            abdc.TabAddressBook.InsertAllOnSubmit(entitys);
            abdc.SubmitChanges();


            //�����W�[���ܽd�O�����X
            IEnumerable<TabAddressBookEntity> entitysdel = from v in abdc.TabAddressBook
                                                        where v.Age == 0
                                                        select v;



            abdc.TabAddressBook.DeleteAllOnSubmit(entitysdel);

            Console.WriteLine("DeleteAllOnSubmit����ASubmitChanges���e�����e");
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
