using System;
using System.Data.Linq;
using System.Linq;
using DemoEntity;
using DemoTranslate1;

namespace DemoAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            //����D������
            TabAddressBookEntity guest = abdc.TabAddressBook.First();

            //����l���鶰�X
            EntitySet<TabShoppingListEntity> splst = guest.TabShoppingListEntity;

            //�s�W�l����
            TabShoppingListEntity sp = new TabShoppingListEntity()
            {
                Product = "3�J���p�ۧ٫�",
                Unit = "��",
                Amount = 1,
                Price = 60000,
                AddressBookID = guest.ID
            };

            splst.Add(sp);

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
