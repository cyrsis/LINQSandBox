using System;
using System.Linq;
using DemoEntity;

namespace DemoAttach2
{
    class Program
    {
        static void Main(string[] args)
        {
            //�إߤ@�ӹ���A�ǳƧ�s��Ʈw
            TabAddressBookEntity tn = new TabAddressBookEntity { ID = 1, Name = "�v_���[", Age = 21, Duty = "�X�����D", Sex = "�k", TelphoneNumber = "017*-876543**" };

            //�إߤ@�ӹ���A�o�ӹ��骺��Ʈw�@�P�A�@�������
            TabAddressBookEntity tn2 = new TabAddressBookEntity { ID = 1, Name = "�v�C�x", Age = 21, Duty = "�X�����D", Sex = "�k", TelphoneNumber = "017*-876543**" };


            AddressBookDataContext abcd2 = new AddressBookDataContext();
            Console.WriteLine("��l����Ʈw���e");
            foreach (var t in abcd2.TabAddressBook.Where(row => row.ID == tn.ID))
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            AddressBookDataContext abcd = new AddressBookDataContext();

            abcd.TabAddressBook.Attach(tn, tn2);
            
            //���ξާ@
            abcd.SubmitChanges();

            //��s����s���
            abcd2.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, abcd2.TabAddressBook.Where(row => row.ID == tn.ID));

            Console.WriteLine("\n���[��DataContext��H�A�æP�B��s�F��Ʈw");
            foreach (var t in abcd2.TabAddressBook.Where(row => row.ID == tn.ID))
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);


            AddressBookDataContext abcd3 = new AddressBookDataContext();
            abcd3.TabAddressBook.Attach(tn2, tn);
            abcd3.SubmitChanges();

            Console.ReadKey();
        }
    }
}
