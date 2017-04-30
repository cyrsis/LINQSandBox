using System;
using System.Collections.Generic;
using System.Collections;

namespace DemoGeneric2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            List<int> lst = new List<int>();

            //ArrayList �p�ɶ}�l
            DateTime dt = DateTime.Now;

            //�N100�U�Ӥ����[�JArrayList
            for (int i = 0; i < 1000000; i++)
                arr.Add(i);

            //ArrayList �p�ɬq
            TimeSpan ts1 = DateTime.Now - dt;

            //List �p�ɶ}�l
            dt = DateTime.Now;

            //�N100�U�Ӥ����[�JList
            for (int i = 0; i < 1000000; i++)
                lst.Add(i);

            //List �p�ɬq
            TimeSpan ts2 = DateTime.Now - dt;


            Console.WriteLine(string.Format("ArrayList �ӮɡG{0} ms", ts1.Milliseconds));
            Console.WriteLine(string.Format("List<T> �ӮɡG{0} ms", ts2.Milliseconds));

            Console.ReadKey();
        }
    }
}
