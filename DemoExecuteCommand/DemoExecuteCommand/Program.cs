using System;
using DemoEntity;

namespace DemoExecuteCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AddressBookDataContext abdc = new AddressBookDataContext();

            abdc.ExecuteCommand("insert into TabAddressBook (ab_name,ab_dub,ab_sex,ab_age,ab_tel)values({0},{1},{2},{3},{4})", "����", "�����~�k", "�k", 19, "033*-985690**");
            abdc.ExecuteCommand("insert into TabAddressBook (ab_name,ab_dub,ab_sex,ab_age,ab_tel)values({0},{1},{2},{3},{4})", "�w�Ѧp", "�]�ڸt�h", "�k", 35, "067*-788945**");

            //�˵��������
            foreach (var r in abdc.TabAddressBook)
                Console.WriteLine("{0} {1} �q�ܡG{2}", r.Name, r.Duty, r.TelphoneNumber);


            Console.ReadKey();

        }
    }
}
