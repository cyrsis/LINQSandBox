using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using DemoEntity;
using DemoTranslate1;

namespace DemoAddRange
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            //����D������
            TabAddressBookEntity guest = abdc.TabAddressBook.Where(e => e.Name == "������").First();

            //����l���鶰�X
            EntitySet<TabShoppingListEntity> splst = guest.TabShoppingListEntity;

            //�s�W�l���鶰�X
            List<TabShoppingListEntity> sps = new List<TabShoppingListEntity>
            {
               new TabShoppingListEntity{ 
                   Product = "1�J���p�ۧ٫�",
                   Unit = "��",
                   Amount = 1,
                   Price = 60000,
                   AddressBookID = guest.ID
               },
               new TabShoppingListEntity{ 
                   Product = "�����s��",
                   Unit = "�y",
                   Amount = 1,
                   Price = 1000000,
                   AddressBookID = guest.ID
               }
            };


            splst.AddRange(sps);

            abdc.SubmitChanges();

            Console.WriteLine("{0} {1} {2} {3} ���ݲ��~�M��G",
                        guest.Name, guest.Sex, guest.Duty, guest.Age);

            foreach (var g in splst)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Product, g.Price, g.Amount, g.Unit);


            Console.ReadKey();

        }
    }
}
