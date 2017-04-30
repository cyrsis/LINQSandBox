using System;
using System.Collections.Generic;
using System.Linq;
using DemoLinq;

namespace DemoWhere2
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

            //�M��W�r�O3�Ӧr�åB�Ĥ@�Ӧr�O�u���v����T
            var query = from guest in gList
                        where guest.Name.Length == 3 &&
                                Check(guest.Name)

                        select guest;


            foreach (var g in query)
                Console.WriteLine(string.Format("{0} �~��:{1} �q��:{2}", g.Name, g.Age, g.Tel));

            Console.ReadKey();

        }

        /// <summary>
        /// �۩w�q��� 
        /// �˴��O�_�m�u���v
        /// </summary>
        static bool Check(string name)
        {
            if (name.Substring(0, 1) == "��")
                return true;

            return false;
        }
    }
}
