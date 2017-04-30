using System;
using System.Linq;
using DemoEntity;

namespace DemoRefresh
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

                //�b��L��k���ק�O��
                chg();

                Console.WriteLine("������Refresh��k�C");
                Console.WriteLine("{0} �� �q�ܬ��G{1}", t.Name, t.TelphoneNumber);
                
                //��s���骫��
                abdc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, t);

                Console.WriteLine("����Refresh��k��C");
                Console.WriteLine("{0} �� �q�ܤw�g�Q��s���G{1}", t.Name, t.TelphoneNumber);
            }

            Console.ReadKey();

        }

        /// <summary>
        /// �ק���
        /// </summary>
        static void chg()
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            var query = from row in abdc.TabAddressBook
                        where row.Name == "�v�C�x"
                        select row;

            if (query.Count() == 1)
            {
                TabAddressBookEntity t = query.First();
                Console.WriteLine("\n�b��L����k���A�� {0} �ק�q�ܸ��X", t.Name);

                //�ק�q�ܸ��X
                t.TelphoneNumber = "017*-876543**";

                //���έק�
                abdc.SubmitChanges();

                Console.WriteLine("�ק粒���C\n");
            }

        }
    }
}
