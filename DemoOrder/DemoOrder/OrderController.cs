using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace DemoOrder
{
    /// <summary>
    /// 控制器類
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
        /// 返回修改物件
        /// </summary>
        public ChangeSet GetChangeSet()
        {
            return this.abdc.GetChangeSet();
        }

        private OrderSerializer ser;
        /// <summary>
        /// 排序化操作物件
        /// </summary>
        public OrderSerializer Serializer
        {
            get { return ser; }
            set { ser = value; }
        }

        /// <summary>
        /// 得到客戶列表
        /// </summary>
        public Table<TabAddressBookEntity> Guests
        {
            get
            {
                return abdc.TabAddressBook;
            }
        }

        /// <summary>
        /// 儲存
        /// </summary>
        public void Save()
        {
            abdc.SubmitChanges();
        }

        /// <summary>
        /// 更新資料
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
                //由於刪除了一對多關係的資料，並且沒有儲存修改
                //更新將產生執行錯誤
                //設計的初衷就是需要強制更新，放棄一切修改，所以
                //重新初始化 AddressBookDataContext
                this.abdc.Dispose();
                this.abdc = null;
                this.abdc = new AddressBookDataContext();
            }
        }

        /// <summary>
        /// 統計數量和總價
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
        /// 搜索關鍵字
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
