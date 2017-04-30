using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoInto
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

            //���ӦW�r���Ĥ@�Ӧr�i����ըåΤ���key�i��Ƨ�
            Console.WriteLine("into�Ω�group�l�y�����ծɨ�");
            var query = from guest in gList
                        group guest by guest.Name.Substring(0, 1) into grguest
                        orderby grguest.Key descending
                        select grguest;

            //�ˬd���ո��
            foreach (var guestGroup in query)
            {
                //��X��e���ժ����
                Console.WriteLine(string.Format("������G{0} \n", guestGroup.Key));

                //�ˬd�դ�����
                foreach (var g in guestGroup)
                    Console.WriteLine(string.Format("{0}  �q��:{1}", g.Name, g.Tel));
                Console.WriteLine("\n**********************************\n");
            }

            Console.WriteLine("\ninto�Ω�select�l�y����v�ɨ�");

            //select �l�y�� �� info �l�y�ϥ�
            var query2 = from guest in gList
                         select new{NewName = guest.Name, NewAge = guest.Age} into newguest
                         orderby newguest.NewAge
                         select newguest;
                             
            //�ˬd���ո��
            foreach (var g in query2)
            {
                Console.WriteLine(string.Format("{0} �~�֡G{1}", g.NewName,g.NewAge));
            }

            Console.ReadKey();
        }
    }
}
