using System;
using System.Collections.Generic;

namespace DemoVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "���զr�Ŧ�";
            var i = 123456;
            var lst = new List<string>();
            var arr = new string[] { "�j�حx�v", "���M�i��", "�t�{�P�l", "�����~�k" };

            Console.WriteLine(string.Format("�ܶq str ����������G{0}", str.GetType().Name));
            Console.WriteLine(string.Format("�ܶq i ����������G{0}", i.GetType().Name));
            Console.WriteLine(string.Format("�ܶq lst ����������G{0}", lst.GetType().Name));
            Console.WriteLine(string.Format("�ܶq arr ����������G{0}", arr.GetType().Name));

            Console.ReadKey();
        }
    }
}
