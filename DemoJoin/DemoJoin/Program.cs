using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //��l�ƫȤᶰ�X
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
                 new GuestInfo 
                { 
                    Name = "�}�鴸", 
                    Age = 24, 
                    Tel = "089*-569832**" 
                }
            };

            ///��l�ƫȤ�¾�ȶ��X
            List<GuestTitle> titleList = new List<GuestTitle>()
            {
                new GuestTitle{ Name = "�L�ߺa", Tilte = "���M�~��"},
                new GuestTitle{ Name = "�L�ߺa", Tilte = "�ѤU�Ĥ@�B"},
                new GuestTitle{ Name = "�v�C�x", Tilte = "�X�����D"},
                new GuestTitle{ Name = "������", Tilte = "�s��CEO"},
                new GuestTitle{ Name = "������", Tilte = "�ĥ��H��"}
            };

            Console.WriteLine("�����p��");
            //�ھکm�W�i�椺���p��
            var query = from guest in gList
                        join title in titleList on guest.Name equals title.Name
                        select new { Name = guest.Name, Title = title.Tilte, Age = guest.Age };


            foreach (var g in query)
                Console.WriteLine(string.Format("{0} {1} �~��:{2}", g.Title, g.Name, g.Age));


            Console.WriteLine("\n�ھکm�W�i������p��");

            //�ھکm�W�i������p��
            var query2 = from guest in gList
                         join title in titleList on guest.Name equals title.Name into tgroup
                         select new { Name = guest.Name, Titles = tgroup };

            foreach (var g in query2)
            {
                Console.WriteLine(g.Name);
                foreach (var g2 in g.Titles)
                    Console.WriteLine(string.Format("   {0}", g2.Tilte));
            }


            Console.WriteLine("\n���~���p��");
            //�ھکm�W�i�楪�~���p��
            var query3 = from guest in gList
                         join title in titleList on guest.Name equals title.Name into tgroup
                         from subtitle in tgroup.DefaultIfEmpty()
                         select new { Name = guest.Name, Title = (subtitle == null ? "�ů�" : subtitle.Tilte)} ;

            foreach (var g in query3)
                Console.WriteLine(string.Format("{0} {1}", g.Title, g.Name));

            Console.ReadKey();

        }
    }
}
