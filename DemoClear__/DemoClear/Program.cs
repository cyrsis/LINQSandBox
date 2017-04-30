using System;
using System.Data.Linq;
using System.Linq;
using DemoEntity;
using DemoTranslate1;

namespace DemoClear
{
    class Program
    {
        static void Main(string[] args)
        {

            ////�W�[�{�ɸ��
            apptmpdata();

            AddressBookDataContext abdc = new AddressBookDataContext();

            //����D������
            TabAddressBookEntity guest = abdc.TabAddressBook.Where(e => e.Name == "������").First();

            Console.WriteLine("Clear��k���e�� {0} {1} {2} {3} ���ݲ��~�M��G",
                       guest.Name, guest.Sex, guest.Duty, guest.Age);

            foreach (var g in guest.TabShoppingListEntity)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Product, g.Price, g.Amount, g.Unit);

            guest.TabShoppingListEntity.Clear();

            //���έק�A�ñ��z�R������Ʈw�O��
            abdc.SubmitChanges();

            Console.WriteLine("\nClear��k���᪺{0} {1} {2} {3} ���ݲ��~�M��G",
                        guest.Name, guest.Sex, guest.Duty, guest.Age);

            ///��s���
            abdc.Refresh(RefreshMode.OverwriteCurrentValues, guest.TabShoppingListEntity);
            foreach (var g in guest.TabShoppingListEntity)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Product, g.Price, g.Amount, g.Unit);


            Console.ReadKey();

        }

        //�W�[�{�ɸ��
        static void apptmpdata()
        {
            AddressBookDataContext abdc = new AddressBookDataContext();

            TabAddressBookEntity guest = abdc.TabAddressBook.Where(e => e.Name == "������").First();

            EntitySet<TabShoppingListEntity> splst = guest.TabShoppingListEntity;

            for (int i = 0; i < 5; i++)
            {
                TabShoppingListEntity sp = new TabShoppingListEntity()
                {
                    Product = string.Format("�{�ɸ��{0}",i), 
                    Unit = "��",
                    Amount = 1,
                    Price = -1,
                    AddressBookID = guest.MainID
                };

                splst.Add(sp);
                abdc.SubmitChanges();
            }
        }
    }
}
