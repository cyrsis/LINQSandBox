using System;

namespace DemoOrder
{
    /// <summary>
    /// �ϱƧǤƵ��G
    /// </summary>
    public class UnserializerResult
    {
        public UnserializerResult(TabAddressBookEntity e, bool isnew)
        {
            this.IsNew = isnew;
            this.Entity = e;
        }

        /// <summary>
        /// �ϱƧǤƱo�쪺����
        /// </summary>
        public TabAddressBookEntity Entity{get;private set;}

        /// <summary>
        /// �O�_�O�s�W�[������
        /// </summary>
        public bool IsNew { get; private set; }
    }
}
