using System;

namespace DemoNullable
{
    /// <summary>
    /// �w�q�@�ӵ��c��
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
    /// �w�q�@�ӦC�|
    /// </summary>
    enum TestEnm { Test1, Test2 }
    class Program
    {
        static void Main(string[] args)
        {
            Test? stru = null;
            if (stru == null)
            {
                Console.WriteLine("���c�� �]�i�H��NULL");

                stru = new Test("�w�]�r�Ŧ�");
                //�i���������c���l�ƫ�A ��������˽c�ӭקﵲ�c��
                //�u���ȶǻ��X��
                Test vv = stru.Value;
                vv.Test1 = "Test String";
                Console.WriteLine(vv.Test1);

                //�c������
                Console.WriteLine(stru.Value.Test1);
            }
            
            Console.WriteLine("***************************");

            TestEnm? enu = null;
            if (enu == null)
            {
                Console.WriteLine("�C�| �����]�i�H��NULL");
                enu = TestEnm.Test1;
                Console.WriteLine(enu);
            }

            Console.WriteLine("***************************");

            int? i = null;
            if (i == null)
            {
                Console.WriteLine("Int �����]�i�H��NULL");
                i = 100;
                Console.WriteLine(i);
            }

            Console.WriteLine("***************************");

            bool? b = null;
            if (b == null)
            {
                Console.WriteLine("���� �����]�i�H��NULL");
                b = true;
                Console.WriteLine(b);
            }

            Console.WriteLine("***************************");

            i = null;
            Console.WriteLine(string.Format("�I�s i ���w�]�ȡG{0}",i??+0));

            //Test erstru = null;
            //TestEnm erenu = null;
            //int eri = null;
            //bool erb = null;

            Console.ReadKey();
        }
    }
}
