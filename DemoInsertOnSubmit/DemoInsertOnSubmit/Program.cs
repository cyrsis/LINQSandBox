using System;
using DemoEntity;

namespace DemoInsertOnSubmit
{
    class Program
    {
        static void Main(string[] args)
        {
            //�s�W����
            TabAddressBookEntity entity = new TabAddressBookEntity()
            {
                Name = "��B��",
                Sex = "�k",
                Age = 36,
                Duty = "�t�{�P�l",
                TelphoneNumber = "098*-568923**"

            };

            AddressBookDataContext abdc = new AddressBookDataContext();
            abdc.TabAddressBook.InsertOnSubmit(entity);

            Console.WriteLine("InsertOnSubmit����ASubmitChanges���e�����e");
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
