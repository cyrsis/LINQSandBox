using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DemoXElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用原型一構建
            XElement el1 = new XElement("原型1根節點");
            Console.WriteLine(el1);

            Console.WriteLine("***********************************");

            //使用原型2構建
            XElement el2 = new XElement(el1);
            el2.Name = "原型2根節點";
            Console.WriteLine(el2);

            Console.WriteLine("***********************************");

            //使用原型3構建
            XElement el3 = new XElement(
                                new XStreamingElement("原型3根節點",
                                                        from el in el1.Elements()
                                                        select el
                                                      )
                                        );
            Console.WriteLine(el3);

            Console.WriteLine("***********************************");

            //使用原型4構建
            XElement el4 = new XElement("原型4根節點",new XElement("原型4的子節點"));
            Console.WriteLine(el4);

            Console.WriteLine("***********************************");


            //使用原型5構建
            XElement el5 = new XElement("原型5根節點", 
                new XElement("原型5的子節點",1),
                new XElement("原型5的子節點",2),
                new XElement("原型5的子節點",3)
            );
            Console.WriteLine(el5);

            Console.ReadKey();

        }
    }
}
