using System;

namespace DemoGeneric1
{
    /// <summary>
    /// �x����
    /// </summary>
    public class GenericClass<T>
    {
        /// <summary>
        /// �x���������r�q
        /// </summary>
        private T value;

        /// <summary>
        /// �x�����������e
        /// </summary>
        public T Value
        {
            get
            {
                return value;
            }
        }

        /// <summary>
        /// �a�x���Ѽƪ����
        /// </summary>
        /// <param name="input"></param>
        public void Add(T input) 
        {
            this.value = input;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //�ϥΦr�Ŧ�����
            GenericClass<string> str = new GenericClass<string>();
            str.Add("�r�Ŧ����");
            Console.WriteLine(string.Format("Value �����G{0}", str.Value.GetType().Name));
            Console.WriteLine(string.Format("Value�G{0}", str.Value));

            Console.WriteLine("******************************");

            //�ϥ� int ����
            GenericClass<int> intc = new GenericClass<int>();
            intc.Add(123456);
            Console.WriteLine(string.Format("Value �����G{0}", intc.Value.GetType().Name));
            Console.WriteLine(string.Format("Value�G{0}", intc.Value));


            Console.ReadKey();
        }
    }
}
