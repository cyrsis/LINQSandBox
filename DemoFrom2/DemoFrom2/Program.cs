using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoFrom2
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

            List<GuestInfo> gList2 = new List<GuestInfo>()
            {
                new GuestInfo 
                {
                    Name = "������", 
                    Age = 17,
                    Tel = "137052668**" 
                },
                new GuestInfo
                {
                    Name = "���P��", 
                    Age = 20,
                    Tel = "151983676**" 
                },
                new GuestInfo 
                {
                    Name = "���ɭY", 
                    Age = 21,
                    Tel = "152987235**"
                },
            };

            //guest ��M��Age�j��20�A
            //guest2 �M��Age�j��17�A
            //���G��e�챵
            var query = from guest in gList
                        where guest.Age > 20
                        from guest2 in gList2
                        where guest2.Age > 17
                        select new { guest, guest2 };

            //��X

            foreach (var g in query)
                Console.WriteLine(string.Format("{0} {1}", g.guest.Name, g.guest2.Name));

            Console.ReadKey();
        }
    }
}
