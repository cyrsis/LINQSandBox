using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoToDictionary3
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


            //�ϥ�Tel���e�@��Dictionary�����,Name���e�@��Value��
            Dictionary<string, string> dictionary = gList.ToDictionary(guest => guest.Tel,
                g=>g.Name);

            Console.WriteLine(string.Format("gList �����G{0}", gList.GetType().Name));
            Console.WriteLine(string.Format("dictionary �����G{0}", dictionary.GetType().Name));

            Console.WriteLine("\ndictionary ���e�G");
            foreach (string s in dictionary.Keys)
                Console.WriteLine(string.Format("��ȡG{0}�A�m�W�G{1}", s, dictionary[s]));

            Console.ReadKey();

        }
    }
}
