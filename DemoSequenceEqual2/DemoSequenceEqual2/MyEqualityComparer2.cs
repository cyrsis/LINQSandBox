using System.Collections.Generic;
using System.Linq;

namespace DemoSequenceEqual2
{
    /// <summary>
    /// 自定義string數組比較器
    /// </summary>
    public class MyEqualityComparer2<T> : IEqualityComparer<T>
    {
        private string[] sec;
        public MyEqualityComparer2(string[] s)
        {
            this.sec = s;
        }

        #region IEqualityComparer<T> 成員

        public bool Equals(T x, T y)
        {
            string stmp = x as string;

            if (stmp != null)
            {
                return sec.Contains(stmp);
            }

            return false;
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        #endregion
    }
}
