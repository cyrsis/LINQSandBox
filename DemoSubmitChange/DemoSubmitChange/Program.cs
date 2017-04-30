using System;
using System.Linq;
using DemoEntity;

namespace DemoSubmitChange
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            var query = from row in abdc.TabAddressBook
                        where row.Name == "�v�C�x"
                        select row;

            if (query.Count() == 1)
            {
                TabAddressBookEntity t = query.First();
                Console.WriteLine("{0} �� �q�ܬ��G{1}", t.Name, t.TelphoneNumber);

                Console.WriteLine("\n�{�b�}�l�ק�q�ܸ��X���G137010877**");

                //�ק�q�ܸ��X
                t.TelphoneNumber = "137010877**";

                //���έק�
                abdc.SubmitChanges();
            }

            Console.WriteLine("\n��X�������O���A�˵��קﵲ�G�C");
            foreach (var r in abdc.TabAddressBook)
                Console.WriteLine("{0} �� �q�ܬ��G{1}", r.Name, r.TelphoneNumber);


            Console.ReadKey();
        }
    }
}
