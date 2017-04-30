using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoWhere1
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



            ///�W�r�O2�Ӧr�Ϊ̩m"�v" 
            ///�åB �~�֤j�󵥩�19���Ȥ�
            var query = from guest in gList
                        where (guest.Name.Length == 2 ||
                                guest.Name.Substring(0, 1) == "�v") &&
                                guest.Age >= 19

                        select guest;


            foreach (var g in query)
                Console.WriteLine(string.Format("{0} �~��:{1} �q��:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();
        }
    }
}
