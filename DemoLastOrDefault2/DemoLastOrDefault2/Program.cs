using System;
using System.Linq;

namespace DemoLastOrDefault2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 10, 20, 30, 40, 50, 100 };

            var item = lst.LastOrDefault(i => i == 66);

            Console.WriteLine(string.Format("�Ʋժ��̲פ@�ӲŦX���󪺤����G{0}", item));

            Console.ReadKey();
        }
    }
}
