using System;
using System.Linq;

namespace DemoFirstOrDefault2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 10,20,30,40,50,100 };

            var item = lst.FirstOrDefault(i => i==66);

            Console.WriteLine(string.Format("�Ʋժ��Ĥ@�ӲŦX���󪺤����G{0}", item));

            Console.ReadKey();
        }
    }
}
