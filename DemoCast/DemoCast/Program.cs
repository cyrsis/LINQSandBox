using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DemoCast
{
    class Program
    {
        static void Main(string[] args)
        {
            //�w�qArrayList
            //�ѩ�ArrayList�S����{�x��IEnumerable<T>���f�A
            //�ҥH�L�k�ζ��X��l�ƾ� 
            ArrayList nemes = new ArrayList();
            nemes.Add( "�L�ߺa");
            nemes.Add( "����");
            nemes.Add( "������");
            nemes.Add( "�̽�");

            IEnumerable<string> newnames = nemes.Cast<string>();

            foreach (string s in newnames)
                Console.Write(string.Format("{0} ",s));

            Console.ReadKey();
        }
    }
}
