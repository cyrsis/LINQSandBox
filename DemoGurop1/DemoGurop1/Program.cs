using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoGurop1
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


            ////���ӦW�r���Ĥ@�Ӧr�i�����
            //var query = from guest in gList
            //            group guest by guest.Name.Substring(0, 1);

            ////�ˬd���ո��
            //foreach (IGrouping<string, GuestInfo> guestGroup in query)
            //{
            //    //��X��e���ժ����
            //    Console.WriteLine(string.Format("������G{0} \n", guestGroup.Key));

            //    //�ˬd�դ�����
            //    foreach (var g in guestGroup)
            //        Console.WriteLine(string.Format("{0}  �q��:{1}", g.Name, g.Tel));
            //    Console.WriteLine("\n**********************************\n");
            //}



    //���Ӧ~�֬O�_�j��20����
    var query = from guest in gList
                group guest by guest.Age > 20;

    //�ˬd���ո��
    foreach (var guestGroup in query)
    {
        //��X��e���ժ����
        //Console.WriteLine(string.Format("�~�֬O�_�j�� 20 ������G{0} \n", guestGroup.Key));

        //�ˬd�դ�����
        foreach (var g in guestGroup)
            Console.WriteLine(string.Format("{0}  �q��:{1}", g.Name, g.Tel));
        Console.WriteLine("\n**********************************\n");
    }

            Console.ReadKey();
        }
    }
}
