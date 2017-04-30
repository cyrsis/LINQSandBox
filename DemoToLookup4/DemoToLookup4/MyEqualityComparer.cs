using System.Collections.Generic;

namespace DemoDistinct2
{
    /// <summary>
    /// �۩w�q�۵������
    /// </summary>
    public class MyEqualityComparer<T>: IEqualityComparer<T>
    {

        #region IEqualityComparer<T> ����

        public bool Equals(T x, T y)
        {
            string stmp = x as string;

            if (stmp != null)
            {
                if (stmp == "��")
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
