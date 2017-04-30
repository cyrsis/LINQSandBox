using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoIterator1
{
    /// <summary>
    /// 包含迭代器的自定義集合類
    /// </summary>
    public class MyDocuments : IEnumerable
    {
        private List<string> docs = new List<string>();

        public void Add(string s)
        {
            docs.Add(s);
        }

        #region IEnumerable 成員

        public IEnumerator GetEnumerator()
        {
            foreach (string s in docs)
            {
                yield return s;
            }

        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("從包含自定義迭代器的集合類中列舉元素\n");
            //初始化自定義集合
            MyDocuments document = new MyDocuments();
            document.Add("依蓮");
            document.Add("玉珈");
            document.Add("徐長今");
            document.Add("寧雨昔");
            document.Add("安碧如");
            document.Add("洛凝");
            document.Add("蕭玉若");

            //透過帶有自定義迭代器的類列舉元素
            foreach (string s in document)
                Console.Write(string.Format(" {0} ", s));

            Console.WriteLine("\n**********************************************\n");
            Console.WriteLine("從自定義迭代器方法中列舉元素\n");

            List<string> docs = new List<string>();
            docs.Add("依蓮");
            docs.Add("玉珈");
            docs.Add("徐長今");
            docs.Add("寧雨昔");
            docs.Add("安碧如");
            docs.Add("洛凝");
            docs.Add("蕭玉若");

            //透過自定義迭代器方法中列舉元素
            foreach (string s in Documents(docs))
                Console.Write(string.Format(" {0} ",s));

            Console.ReadKey();
        }

        /// <summary>
        /// 迭代器方法
        /// </summary>
        static IEnumerable Documents(List<string> docs)
        {
            foreach (string s in docs)
            {
                yield return s;
            }
        }

    }
}
