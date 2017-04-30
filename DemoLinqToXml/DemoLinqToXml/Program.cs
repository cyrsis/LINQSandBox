using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DemoLinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = null;

            using (StreamReader sr = new StreamReader("test.xml"))
            {
                //�q�ɮפ����JXML
                xdoc = XDocument.Parse(sr.ReadToEnd());
            }

            //�ϥ�LINQ��F���M��Product�`�I�A����`�I����
            IEnumerable<string> products = from ele in xdoc.Descendants()
                           where ele.Name.LocalName == "Product"
                           select ele.Value;                          


            foreach (string p in products)
                Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
