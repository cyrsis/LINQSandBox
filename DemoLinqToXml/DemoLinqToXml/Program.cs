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
                //從檔案中載入XML
                xdoc = XDocument.Parse(sr.ReadToEnd());
            }

            //使用LINQ表達式尋找Product節點，獲取節點的值
            IEnumerable<string> products = from ele in xdoc.Descendants()
                           where ele.Name.LocalName == "Product"
                           select ele.Value;                          


            foreach (string p in products)
                Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
