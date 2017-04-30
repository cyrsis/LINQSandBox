using System;

namespace DemoInitializer1
{
    class Girlfriend
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Boy
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Girlfriend Girl{ get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //用物件初始化器建立物件
            Girlfriend gf1 = new Girlfriend { Name = "秦仙兒",  };
            
            //等價於
            Girlfriend gf2 = new Girlfriend();
            gf2.Name = "蕭玉若";
            gf2.Age = 21;

            //用嵌套的對象初始化器建立物件
            Boy boy1 = new Boy { Name = "林晚榮", Age = 24, Girl = new Girlfriend { Name = "肖青漩", Age = 20 } };

            //等價於
            Boy boy2 = new Boy();
            Girlfriend gf3 = new Girlfriend();

            gf3.Name = "董巧巧";
            gf3.Age = 18;
            boy2.Name = "林三";
            boy2.Age = 24;
            boy2.Girl = gf3;

            Console.WriteLine("gf1 初始化的類型：" + gf1.GetType().Name);
            Console.WriteLine("boy1 初始化的類型：" + boy1.GetType().Name);

            Console.ReadKey();
        }
    }
}
