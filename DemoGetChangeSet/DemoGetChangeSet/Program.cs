using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using DemoEntity;

namespace DemoGetChangeSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //�ǳƻݭn�ק諸���
            Dictionary<string, string> chg = new Dictionary<string, string>();
            chg.Add("������", "151066867**");
            chg.Add("������", "137052668**");

            AddressBookDataContext abdc = new AddressBookDataContext();

            //����ݭn�ק諸�O��
            var query = from r in abdc.TabAddressBook
                        where chg.Keys.Contains(r.Name)
                        select r;

            foreach (var r in query)
            {
                Console.WriteLine("\n{0} ����e���q�ܬ��G{1}", r.Name, r.TelphoneNumber);
                Console.WriteLine("�{�b�ק�q�ܸ��X���G{0}", chg[r.Name]);
                //�ק�q�ܸ��X
                r.TelphoneNumber = chg[r.Name];
            }

            //����ק諸��H
            ChangeSet cs = abdc.GetChangeSet();

            Console.WriteLine("\n��X�ק�L����H");

            foreach (var r in cs.Updates)
            {
                TabAddressBookEntity t = r as TabAddressBookEntity;
                Console.WriteLine("{0} �� �q�ܬ��G{1}", t.Name, t.TelphoneNumber);
            }

            //���έק�
            //abdc.SubmitChanges();

            Console.ReadKey();
        }
    }
}
