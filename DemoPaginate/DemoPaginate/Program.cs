using System;
using System.Linq;

namespace DemoPaginate
{
    class Program
    {
        static void Main(string[] args)
        {
            //��e���X
            int ipage = 0;
            //�C���O����
            int ipagesize = 2;

            //�w�q�Ʋ�
            string[] nemes = { "�L�ߺa", "����", "������", "�X�����D", "�̽�", "�w�Ѧp" };

            Console.WriteLine(string.Format("��X�� {0} ���O��", ipage));
            //��X�� 0 ���O��
            var q = nemes.Skip(ipagesize * ipage).Take(ipagesize);
            foreach (string s in q)
                Console.WriteLine(s);

            ipage++;
            Console.WriteLine(string.Format("\n��X�� {0} ���O��", ipage));
            //��X�� 1 ���O��
            var q2 = nemes.Skip(ipagesize * ipage).Take(ipagesize);
            foreach (string s in q2)
                Console.WriteLine(s);

            ipage++;
            Console.WriteLine(string.Format("\n��X�� {0} ���O��", ipage));
            //��X�� 2 ���O��
            var q3 = nemes.Skip(ipagesize * ipage).Take(ipagesize);
            foreach (string s in q3)
                Console.WriteLine(s);

            Console.ReadKey();


        }
    }
}
