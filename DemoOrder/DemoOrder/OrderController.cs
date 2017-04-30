using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace DemoOrder
{
    /// <summary>
    /// �����
    /// </summary>
    public class OrderController
    {
        public OrderController()
        {
            this.abdc = new AddressBookDataContext();
            this.ser = new OrderSerializer(this.abdc);
        }

        private AddressBookDataContext abdc;

        /// <summary>
        /// ��^�ק磌��
        /// </summary>
        public ChangeSet GetChangeSet()
        {
            return this.abdc.GetChangeSet();
        }

        private OrderSerializer ser;
        /// <summary>
        /// �ƧǤƾާ@����
        /// </summary>
        public OrderSerializer Serializer
        {
            get { return ser; }
            set { ser = value; }
        }

        /// <summary>
        /// �o��Ȥ�C��
        /// </summary>
        public Table<TabAddressBookEntity> Guests
        {
            get
            {
                return abdc.TabAddressBook;
            }
        }

        /// <summary>
        /// �x�s
        /// </summary>
        public void Save()
        {
            abdc.SubmitChanges();
        }

        /// <summary>
        /// ��s���
        /// </summary>
        public void Refresh()
        {
            try
            {
                abdc.Refresh(RefreshMode.KeepChanges, abdc.TabAddressBook);
                abdc.Refresh(RefreshMode.KeepChanges, abdc.TabShoppingList);
            }
            catch
            {
                //�ѩ�R���F�@��h���Y����ơA�åB�S���x�s�ק�
                //��s�N���Ͱ�����~
                //�]�p����J�N�O�ݭn�j���s�A���@���ק�A�ҥH
                //���s��l�� AddressBookDataContext
                this.abdc.Dispose();
                this.abdc = null;
                this.abdc = new AddressBookDataContext();
            }
        }

        /// <summary>
        /// �έp�ƶq�M�`��
        /// </summary>
        public static CountArgs Count(TabAddressBookEntity guest)
        {
            if (guest == null)
                return null;

            if (guest.TabShoppingListEntity != null)
            {
                int amount = guest.TabShoppingListEntity.Sum(row => row.Amount);

                CountArgs arg = new CountArgs(
                    amount,
                    guest.TabShoppingListEntity.Sum(row => row.Amount * (int)row.Price) + amount
                    );

                return arg;
            }

            return null;
        }

        /// <summary>
        /// �j������r
        /// </summary>
        public IEnumerable<TabAddressBookEntity> Search(string word)
        {
            var query = from r in this.abdc.TabAddressBook
                        where r.Name.IndexOf(word) > -1 ||
                         r.Sex.IndexOf(word) > -1 ||
                         r.TelphoneNumber.IndexOf(word) > -1 ||
                         r.Address.IndexOf(word) > -1 ||
                         r.Company.IndexOf(word) > -1 ||
                         r.Duty.IndexOf(word) > -1 ||
                         r.Age.ToString().IndexOf(word) > -1
                        select r;

            return query;
        }
    }
}
