using System;
using System.Xml.Linq;

namespace DemoXElementMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<根節點>
                                  <子節點>1</子節點>
                                  <子節點>2</子節點>
                                  <子節點>3</子節點>
                                  <子節點>4</子節點>
                                  <子節點>5</子節點>
                                  <子節點>6</子節點>
                            </根節點>";


            XElement el = XElement.Parse(sxml);

            XElement elChild = el.Element("子節點");

            Console.WriteLine(elChild);

            Console.ReadKey();
        }
    }
}
