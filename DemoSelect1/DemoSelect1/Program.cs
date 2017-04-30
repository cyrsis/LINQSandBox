using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoSelect1
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
                    Name = "��B��", 
                    Age = 36, 
                    Tel = "098*-568923**" },
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


            //�z��~�֤p��30���Ȥ��T�ç�v��MyGuestInfo����
            var query = from guest in gList
                        where guest.Age < 30
                        select new MyGuestInfo { Name = guest.Name, Tel = guest.Tel };

            foreach (var g in query)
                Console.WriteLine(string.Format("{0}  �q��:{1} �����G{2}", g.Name, g.Tel, g.ToString()));

            Console.ReadKey();
        }
    }
}
