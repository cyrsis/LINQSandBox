using System;
using System.Linq;

namespace DefaultIfEmpty2
{
    class Program
    {
        static void Main(string[] args)
        {
            //�Ū�int�����Ƨ�
            var intempty = Enumerable.Empty<int>();

            Console.Write("int �����w�]�ȡG");
            foreach (var i in intempty.DefaultIfEmpty())
                Console.Write(i);

            Console.Write("\nint �����۩w�q�w�]�ȡG");
            foreach (var i in intempty.DefaultIfEmpty(-100))
                Console.Write(i);

            Console.ReadKey();
        }
    }
}
