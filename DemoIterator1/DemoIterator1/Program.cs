using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoIterator1
{
    /// <summary>
    /// �]�t���N�����۩w�q���X��
    /// </summary>
    public class MyDocuments : IEnumerable
    {
        private List<string> docs = new List<string>();

        public void Add(string s)
        {
            docs.Add(s);
        }

        #region IEnumerable ����

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
            Console.WriteLine("�q�]�t�۩w�q���N�������X�����C�|����\n");
            //��l�Ʀ۩w�q���X
            MyDocuments document = new MyDocuments();
            document.Add("�̽�");
            document.Add("����");
            document.Add("�}����");
            document.Add("��B��");
            document.Add("�w�Ѧp");
            document.Add("����");
            document.Add("���ɭY");

            //�z�L�a���۩w�q���N�������C�|����
            foreach (string s in document)
                Console.Write(string.Format(" {0} ", s));

            Console.WriteLine("\n**********************************************\n");
            Console.WriteLine("�q�۩w�q���N����k���C�|����\n");

            List<string> docs = new List<string>();
            docs.Add("�̽�");
            docs.Add("����");
            docs.Add("�}����");
            docs.Add("��B��");
            docs.Add("�w�Ѧp");
            docs.Add("����");
            docs.Add("���ɭY");

            //�z�L�۩w�q���N����k���C�|����
            foreach (string s in Documents(docs))
                Console.Write(string.Format(" {0} ",s));

            Console.ReadKey();
        }

        /// <summary>
        /// ���N����k
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
