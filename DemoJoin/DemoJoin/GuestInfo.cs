using System.Collections.Generic;

namespace DemoLinq
{
    /// <summary>
    /// �Ȥ��T
    /// </summary>
    public class GuestInfo
    {
        /// <summary>
        /// �m�W
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// �~��
        /// </summary>
        public int Age { set; get; }

        /// <summary>
        /// �q��
        /// </summary>
        public string Tel { set; get; }

        /// <summary>
        /// �q�ܪ�
        /// </summary>
        public List<string> TelTable { set; get; }

    }
}
