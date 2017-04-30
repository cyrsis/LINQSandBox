using System;

namespace DemoNullable
{
    /// <summary>
    /// 定義一個結構體
    /// </summary>
    public struct Test
    {
        string stest;
        public string Test1 
        {
            get
            {
                return stest;
            }
            set 
            { 
                stest = value;
            }
        }

        public Test(string s)
        {
            this.stest = s;
        }

    }
    /// <summary>
    /// 定義一個列舉
    /// </summary>
    enum TestEnm { Test1, Test2 }
    class Program
    {
        static void Main(string[] args)
        {
            Test? stru = null;
            if (stru == null)
            {
                Console.WriteLine("結構體 也可以為NULL");

                stru = new Test("預設字符串");
                //可空類型結構體初始化後， 不能取消裝箱來修改結構體
                //只能把值傳遞出來
                Test vv = stru.Value;
                vv.Test1 = "Test String";
                Console.WriteLine(vv.Test1);

                //箱內的值
                Console.WriteLine(stru.Value.Test1);
            }
            
            Console.WriteLine("***************************");

            TestEnm? enu = null;
            if (enu == null)
            {
                Console.WriteLine("列舉 類型也可以為NULL");
                enu = TestEnm.Test1;
                Console.WriteLine(enu);
            }

            Console.WriteLine("***************************");

            int? i = null;
            if (i == null)
            {
                Console.WriteLine("Int 類型也可以為NULL");
                i = 100;
                Console.WriteLine(i);
            }

            Console.WriteLine("***************************");

            bool? b = null;
            if (b == null)
            {
                Console.WriteLine("布爾 類型也可以為NULL");
                b = true;
                Console.WriteLine(b);
            }

            Console.WriteLine("***************************");

            i = null;
            Console.WriteLine(string.Format("呼叫 i 的預設值：{0}",i??+0));

            //Test erstru = null;
            //TestEnm erenu = null;
            //int eri = null;
            //bool erb = null;

            Console.ReadKey();
        }
    }
}
