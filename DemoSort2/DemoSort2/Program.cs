using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoSort2
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
                    Name = "�����", 
                    Age = 18, 
                    Tel = "067*-781256**" 
                },
                new GuestInfo 
                { 
                    Name = "�}����", 
                    Age = 18, 
                    Tel = "039*-967512**" 
                },
                new GuestInfo 
                { 
                    Name = "�̽�", 
                    Age = 18, 
                    Tel = "098*-231238**" 
                },
                new GuestInfo 
                { 
                    Name = "������", 
                    Age = 19, 
                    Tel = "029*-981256**" 
                },
            };

            Console.WriteLine("���Ӧ~�ֶi��ƧǡB���ӦW�r�r�ƶi�榸�n�Ƨ�");
            ///���Ӧ~�ֶi��ƧǡB���ӦW�r�r�ƶi�榸�n�Ƨ�
            var query = from guest in gList
                        orderby guest.Age,guest.Name.Length
                        select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} �~��:{1} �q��:{2}", g.Name, g.Age, g.Tel));

            Console.WriteLine("\n���Ӧ~�ֶi��ƧǡB���ӦW�r�r�ƶi�歰�Ǧ��n�Ƨ�");

            ///���Ӧ~�ֶi��ƧǡB���ӦW�r�r�ƶi�歰�Ǧ��n�Ƨ�
            query = from guest in gList
                    orderby guest.Age, guest.Name.Length descending
                    select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} �~��:{1} �q��:{2}", g.Name, g.Age, g.Tel));


            Console.WriteLine("\n���Ӧ~�ֶi��ƧǡB�W�r�r�ơB�q�ܱƧ�");

            ///���Ӧ~�ֶi��ƧǡB���ӦW�r�r�ƶi�榸�n�ƧǡB���ӹq�ܶi��ĤT����Ƨ�
            query = from guest in gList
                    orderby guest.Age, guest.Name.Length, guest.Tel
                    select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} �~��:{1} �q��:{2}", g.Name, g.Age, g.Tel));

          

            Console.ReadKey();
        }
    }
}
