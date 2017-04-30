using System;
using System.Collections.Generic;
using System.Linq;
using DemoDistinct2;
using DemoLinq;

namespace DemoToDictionary4
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
 

            //�ϥ�Name���e�@��Dictionary����ȡATel���e�@��Value��
            Dictionary<string, string> dictionary = gList.ToDictionary(guest => guest.Name,g => g.Tel, new MyEqualityComparer<string>());

            Console.WriteLine(string.Format("gList �����G{0}", gList.GetType().Name));
            Console.WriteLine(string.Format("dictionary �����G{0}", dictionary.GetType().Name));

            Console.WriteLine("\n�ˬd�O�_������z�L��Ȧs��������");
            foreach (var s in dictionary)
            {
                if (!dictionary.Keys.Contains(s.Key))
                    Console.WriteLine(string.Format("��Ȭ� {0} �����e�A����z�L��Ȧs���C", s.Key));
            }

            Console.WriteLine("\n�ˬddictionary����������");
            foreach (var s in dictionary)
                Console.WriteLine(string.Format("��ȡG{0}�A�q�ܡG{1}", s.Key, s.Value));

            Console.ReadKey();

        }
    }
}
