using System;
using System.Collections.Generic;
using System.Linq;
using DemoDistinct2;
using DemoLinq;

namespace DemoToLookup2
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
                    Name = "������", 
                    Age = 17, 
                    Tel = "053*-985690**" },
                new GuestInfo 
                { 
                    Name = "���ɭY", 
                    Age = 21, 
                    Tel = "035*-120967**" 
                },
                new GuestInfo 
                { 
                    Name = "�}����", 
                    Age = 18, 
                    Tel = "039*-967512**" 
                },
                new GuestInfo 
                { 
                    Name = "�}�鴸", 
                    Age = 24, 
                    Tel = "089*-569832**" 
                }
            };


            //�ϥΩm�@��Lookup�����
            ILookup<string, GuestInfo> lookup = gList.ToLookup(guest => guest.Name.Substring(0, 1), new MyEqualityComparer<string>());

            Console.WriteLine(string.Format("gList �����G{0}", gList.GetType().Name));
            Console.WriteLine(string.Format("lookup �����G{0}", lookup.GetType().Name));

            Console.WriteLine("\nlookup ���e�G");
            foreach (var k in lookup)
            {
                Console.WriteLine(string.Format("��ȡG{0}", k.Key));
                foreach (var v in k)
                    Console.WriteLine(string.Format("�m�W�G{0}�A�~�֡G{1}", v.Name, v.Age));

                Console.WriteLine("****************************");
            }
            Console.ReadKey();
        }
    }
}
