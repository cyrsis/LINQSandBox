using System;
using System.Linq;
using System.Collections;
using DemoLinq;

namespace DemoLinq2
{
    class Program
    {
        static void Main(string[] args)
        {
            //��l��ArrayList
            ArrayList gList = new ArrayList();
            gList.Add(
                new GuestInfo { Name = "�L�ߺa", Age = 21, Tel = "888888**" }
                );

            gList.Add(
                   new GuestInfo { Name = "��B��", Age = 36, Tel = "568923**" }
                   );

            gList.Add(
                   new GuestInfo { Name = "����", Age = 19, Tel = "985690**" }
                   );

            //�d�� �~�֤j�� 19 ���Ȥ�
            var query = from GuestInfo guest in gList
                        where guest.Age > 19
                        select guest;

            //��X
            foreach (GuestInfo g in query)
                Console.WriteLine(string.Format("{0} �~��:{1} �q��:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();

        }
    }
}
