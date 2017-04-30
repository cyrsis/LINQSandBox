using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoFrom1
{
    class Program
    {
        static void Main(string[] args)
        {
            //��l�ƶ��X
            List<GuestInfo> gList = new List<GuestInfo>()
            {
                new GuestInfo { 
                    Name = "�L�ߺa", 
                    Age = 21,  
                    TelTable = new List<string>(){ 
                        "026*-888888**",
                        "13802588***"} 
                },
                new GuestInfo { 
                    Name = "��B��", 
                    Age = 36,  
                    TelTable = new List<string>(){ 
                        "098*-568923**",
                        "132679856**"} 
                },
                new GuestInfo { 
                    Name = "����",
                    Age = 19,  
                    TelTable = new List<string>(){ 
                        "033*-985690**",
                        "153129057**"}
                },
            };

            //�M�� �q�ܸ��X �G132679856** �ݩ���ӫȤ�
            var query = from guest in gList
                        from tel in guest.TelTable
                        where tel.IndexOf("132679856**") > -1
                        select guest;

            //��X
            foreach (var g in query)
            {
                Console.WriteLine(string.Format("{0} �~��:{1}", g.Name, g.Age));
                foreach (var t in g.TelTable)
                    Console.WriteLine(string.Format("       �q�ܡG{0}", t));
            }

            Console.ReadKey();
        }
    }
}
