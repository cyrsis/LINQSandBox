using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoSort1
{
    class Program
    {
        static void Main(string[] args)
        {
            //��l�ƶ��X
            List<GuestInfo> gList = new List<GuestInfo>()
            {
                new GuestInfo 
                { 
                    Name = "�L�ߺa", 
                    Age = 21, 
                    Tel = "026*-888888**" },
                new GuestInfo 
                { 
                    Name = "��B��", 
                    Age = 36, 
                    Tel = "098*-568923**" 
                },
                new GuestInfo 
                { 
                    Name = "������", 
                    Age = 19, 
                    Tel = "029*-981256**" 
                },
            };

            Console.WriteLine("���Ӧ~�֤ɧǶi��Ƨ�");
            ///���Ӧ~�֤ɧǶi��Ƨ�
            var query = from guest in gList
                        orderby guest.Age
                        select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} �~��:{1} �q��:{2}", g.Name, g.Age, g.Tel));


            Console.WriteLine("\n���Ӧ~�֭��Ƕi��Ƨ�");

            ///���Ӧ~�֭��Ƕi��Ƨ�
            query = from guest in gList
                    orderby guest.Age descending
                    select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} �~��:{1} �q��:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();

        }
    }
}
