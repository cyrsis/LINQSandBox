using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DemoXElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string sxml = @"<根節點>
                                  <子節點>
                                        <第3級>1</第3級>
                                        <第3級>2</第3級>
                                   </子節點>
                                  <子節點>2</子節點>
                                  <子節點>3</子節點>
                                  <子節點>4</子節點>
                                  <子節點>5</子節點>
                                  <子節點>6</子節點>
                            </根節點>";

            XElement el = XElement.Parse(sxml);

            Console.WriteLine("應用Elements方法返回的子元素集合");
            IEnumerable<XElement> elChilds = el.Elements();
            foreach (XElement e in elChilds)
                Console.WriteLine(e.Name.LocalName);

            Console.WriteLine("\n應用Descendants方法返回的子元素集合");
            IEnumerable<XElement> elChilds2 = el.Descendants();
            foreach (XElement e in elChilds2)
                Console.WriteLine(e.Name.LocalName);

            Console.ReadKey();
        }
    }
}
