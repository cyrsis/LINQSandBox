using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSingleOrDefault2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 10, 20, 30, 40, 50, 100, 50 };

            var item = lst.SingleOrDefault(i => i == 66);

            Console.WriteLine(string.Format("�Ʋժ��ߤ@�ŦX���󪺤����G{0}", item));

            try
            {

                var item2 = lst.SingleOrDefault(i => i == 50);

            }
            catch (Exception e)
            {
                Console.WriteLine(string.Format("\n����SingleOrDefault��k�X���G{0}", e.Message));
            }



            Console.ReadKey();
        }
    }
}
