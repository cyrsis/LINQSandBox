using System;
using System.Collections.Generic;

namespace DemoInitializer2
{
    /// <summary>
    /// 示範物件
    /// </summary>
    class Girlfriend
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    /// <summary>
    /// 示範物件
    /// </summary>
    class Boy
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        /// <summary>
        /// 集合內容
        /// </summary>
        public List<Girlfriend> Girls { get; set;}
    }


    class Program
    {
        static void Main(string[] args)
        {
            //用集合初始化器建立集合
            List<string> gfs1 = new List<string> { "肖青漩", "董巧巧", "蕭玉霜" };

            //等價於
            List<string> gfs2 = new List<string>();
            gfs2.Add("肖青漩");
            gfs2.Add("董巧巧");
            gfs2.Add("蕭玉霜");

            //物件集合初始化器復合使用
            Boy boy = new Boy { Name = "林晚榮", Age = 24, 
                                    Girls = new List<Girlfriend> 
                                    { 
                                        new Girlfriend { Name = "肖青漩", Age = 23 }, 
                                        new Girlfriend { Name = "董巧巧", Age = 18 }, 
                                        new Girlfriend { Name = "蕭玉霜", Age = 16 } 
                                    } 
                               };


            Console.ReadKey();

        }
    }
}
