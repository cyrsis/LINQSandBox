using System;
using System.Linq;
using DemoEntity;

namespace DemoAttach3
{
    class Program
    {
        static void Main(string[] args)
        {
            //�إߤ@�ӹ���A�ǳƧ�s��Ʈw
            TabAddressBookEntity tn = new TabAddressBookEntity { ID = 1, Name = "�v_���[", Age = 21, Duty = "�X�����D", Sex = "�k", TelphoneNumber = "017*-876543**" };

            AddressBookDataContext abcd2 = new AddressBookDataContext();
            Console.WriteLine("��l����Ʈw���e");
            foreach (var t in abcd2.TabAddressBook.Where(row => row.ID == tn.ID))
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            AddressBookDataContext abcd = new AddressBookDataContext();

            abcd.TabAddressBook.Attach(tn,true);

            //���ξާ@
            abcd.SubmitChanges();

            //��s����s���
            abcd2.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, abcd2.TabAddressBook.Where(row => row.ID == tn.ID));

            Console.WriteLine("\n���[��DataContext��H�A�æP�B��s�F��Ʈw");
            foreach (var t in abcd2.TabAddressBook.Where(row => row.ID == tn.ID))
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);


            AddressBookDataContext abcd3 = new AddressBookDataContext();
            tn.Name = "�v�C�x";
            abcd3.TabAddressBook.Attach(tn,true);
            abcd3.SubmitChanges();

            Console.ReadKey();
        }
    }
}
