using System;
using System.Data.Linq;
using System.Linq;
using DemoEntity;
using DemoTranslate1;

namespace DemoRemoveAt
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

            //���apptmpdata��k���J���{�ɸ��
            TabShoppingListEntity sp = guest.TabShoppingListEntity.Where(t => t.Product == "�{�ɸ��").First();

            Console.WriteLine("RemoveAt��k���e�� {0} {1} {2} {3} ���ݲ��~�M��G",
                       guest.Name, guest.Sex, guest.Duty, guest.Age);

            foreach (var g in guest.TabShoppingListEntity)
                Console.WriteLine("{0} {1} {2} {3}",
                        g.Product, g.Price, g.Amount, g.Unit);

            //�������
            int index = guest.TabShoppingListEntity.IndexOf(sp);

            guest.TabShoppingListEntity.RemoveAt(index);

            Console.WriteLine("\n�u{0}�v�����A���ޡG{1}�A�Q�����C", sp.Product, index);

            //���έק�A�ñ��z�R������Ʈw�O��
            abdc.SubmitChanges();

            Console.WriteLine("\nRemoveAt��k���᪺{0} {1} {2} {3} ���ݲ��~�M��G",
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

            //����D������
            TabAddressBookEntity guest = abdc.TabAddressBook.Where(e => e.Name == "������").First();

            //����l���鶰�X
            EntitySet<TabShoppingListEntity> splst = guest.TabShoppingListEntity;

            //�s�W�l����
            TabShoppingListEntity sp = new TabShoppingListEntity()
            {
                Product = "�{�ɸ��",
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
