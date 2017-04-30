using System;
using DemoEntity;

namespace DemoExecuteCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AddressBookDataContext abdc = new AddressBookDataContext();

            abdc.ExecuteCommand("insert into TabAddressBook (ab_name,ab_dub,ab_sex,ab_age,ab_tel)values({0},{1},{2},{3},{4})", "洛凝", "金陵才女", "女", 19, "033*-985690**");
            abdc.ExecuteCommand("insert into TabAddressBook (ab_name,ab_dub,ab_sex,ab_age,ab_tel)values({0},{1},{2},{3},{4})", "安碧如", "苗族聖姑", "女", 35, "067*-788945**");

            //檢視全部資料
            foreach (var r in abdc.TabAddressBook)
                Console.WriteLine("{0} {1} 電話：{2}", r.Name, r.Duty, r.TelphoneNumber);


            Console.ReadKey();

        }
    }
}
