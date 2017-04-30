using System;
using System.Linq;
using DemoEntity;

namespace DemoAttach1
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookDataContext abcd = new AddressBookDataContext();

            //�إߤ@�ӹ���A��Ʈw���s�b�o�ӥ]�t�o�ӥD�䪺�O��
            TabAddressBookEntity tn = new TabAddressBookEntity { ID = 1, Name = "�v�C�x", Age = 21, Duty = "�X�����D", Sex = "�k", TelphoneNumber = "017*-876543**" };

            //�q��Ʈw�o�����A�o�ӹ��骺�D���tn�@��
            TabAddressBookEntity tn2 = abcd.TabAddressBook.First();

            try
            {
                abcd.TabAddressBook.Attach(tn);
            }
            catch (Exception e)
            {
                Console.WriteLine("���[DataContext�w�g���ܪ����鲣�Ͱ�����~�G");
                Console.WriteLine(e.Message);
            }


            AddressBookDataContext abcd2 = new AddressBookDataContext();
            abcd2.TabAddressBook.Attach(tn);
            //�Y�K�O��SubmitChanges��k���ξާ@�A�]���|��s��Ʈw
            abcd2.SubmitChanges();

            //���F���tn���[���\�A�N�ק�Name���e
            tn.Name += "_���[";

            Console.WriteLine("\n���[��t�~��DataContext���󦨥\");
            foreach (var t in abcd2.TabAddressBook.Where(row => row.ID == tn.ID))
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);


            Console.WriteLine("\n��Ʈw���e�èS���P�B��s");
            foreach (var t in abcd.TabAddressBook.Where(row => row.ID == tn.ID))
                Console.WriteLine("{0} {1} {2} {3}",
                        t.Name, t.Sex, t.Duty, t.Age);

            Console.ReadKey();
        }
    }
}
