using System;

namespace DemoDelegate2
{
    /// <summary>
    /// �۩w�q���ƥ�����
    /// </summary>
    public class MyEnentArgs : EventArgs
    {
        /// <summary>
        /// �ݭn�ǻ������
        /// </summary>
        public int Number { get; private set; }

        public MyEnentArgs(int n)
        {
            this.Number = n;
        }
    }

}
