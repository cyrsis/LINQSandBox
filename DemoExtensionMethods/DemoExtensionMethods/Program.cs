using System;

namespace DemoExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            string subb = "[a]http://www.baidu.com[/a]";

            Console.WriteLine(subb.UbbToHtmlLink());

            Console.WriteLine("\n");

            int i = 5;
            
            Console.WriteLine(string.Format("�˴� i �O�_�����ơG{0}",i.IsEven()));

            Console.WriteLine("\n");

            Program p = new Program();
            
            p.ExtensionShow();

            Console.ReadKey();
        }

    }
}
