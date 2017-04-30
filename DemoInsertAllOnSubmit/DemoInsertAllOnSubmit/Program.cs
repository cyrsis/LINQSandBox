using System;
using System.Collections.Generic;
using DemoEntity;

namespace DemoInsertAllOnSubmit
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
                    Name = "�}����",
                    Sex = "�k",
                    Age = 18,
                    Duty = "���R���D",
                    TelphoneNumber = "039*-967512**"

                },
                new TabAddressBookEntity()
                {
                    Name = "�}�鴸",
                    Sex = "�k",
                    Age = 24,
                    Duty = "�j�حx�v",
                    TelphoneNumber = "089*-569832**"

                }
            };


            AddressBookDataContext abdc = new AddressBookDataContext();
            abdc.TabAddressBook.InsertAllOnSubmit(entitys);

            Console.WriteLine("InsertAllOnSubmit����ASubmitChanges���e�����e");
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
