using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoWhere3
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
                    Name = "�v�C�x", 
                    Age = 21, 
                    Tel = "017*-876543**" 
                },
                new GuestInfo 
                { 
                    Name = "������", 
                    Age = 19, 
                    Tel = "029*-981256**" 
                },
            };

            //�w�q�ʺA�z���Ʋ�
            string[] names = { "�}����", "���ɭY", "�v�C�x", "�����" };

            //�M��]�t�b�ʺA�z���Ʋդ����W�r
            var query = from guest in gList
                        where names.Contains(guest.Name)
                        select guest;

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} �~��:{1} �q��:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();

        }
    }
}
