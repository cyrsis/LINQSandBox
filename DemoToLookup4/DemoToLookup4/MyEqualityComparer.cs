using System.Collections.Generic;

namespace DemoDistinct2
{
    /// <summary>
    /// 自定義相等比較器
    /// </summary>
    public class MyEqualityComparer<T>: IEqualityComparer<T>
    {

        #region IEqualityComparer<T> 成員

        public bool Equals(T x, T y)
        {
            string stmp = x as string;

            if (stmp != null)
            {
                if (stmp == "蕭")
                    return false;
            }

            if (x.GetHashCode() == y.GetHashCode())
                return true;
            else
                return false;
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        #endregion
    }
}
