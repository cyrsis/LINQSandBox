using System;
using System.Linq;

namespace DemoRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            ///�w�q�@�ӰΦW����
            var orange = new {Color="���",Name="�ܤl"};

            var oranges = Enumerable.Repeat(orange,5);

            Console.WriteLine("�]�t5�ӰΦW����������");
            foreach (var n in oranges)
                Console.WriteLine(string.Format("{0}��{1} ", n.Color, n.Name));

            Console.ReadKey();
        }
    }
}

