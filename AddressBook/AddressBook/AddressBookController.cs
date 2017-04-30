using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AddressBook
{
    /// <summary>
    /// 电话薄控制器
    /// </summary>
    public class AddressBookController
    {
        public AddressBookController()
        {
            this.dataContext = new AddressBookClassesDataContext();
            this.BookBindingList = this.dataContext.TabAddressBook.GetNewBindingList();
        }

        ~AddressBookController()
        {
            if (this.dataContext != null)
                this.dataContext.Dispose();
        }

        /// <summary>
        /// LINQ to SQL 数据库上下文
        /// </summary>
        public AddressBookClassesDataContext dataContext;

        /// <summary>
        /// 提供给控件的数据绑定对象
        /// </summary>
        public IBindingList BookBindingList { get; private set; }
   
        /// <summary>
        /// 添加新记录
        /// </summary>
        /// <param name="item"></param>
        public void New(TabAddressBook item)
        {
            if (item != null)
            {
                this.dataContext.TabAddressBook.InsertOnSubmit(item);
                this.dataContext.SubmitChanges();
                this.BookBindingList = this.dataContext.TabAddressBook.GetNewBindingList();
            }
        }

        /// <summary>
        /// 修改记录
        /// </summary>
        /// <param name="item"></param>
        public void Update(TabAddressBook item)
        {
            if (item != null)
            {

                var query = from i in this.dataContext.TabAddressBook
                            where i.ab_id == item.ab_id
                            select i;

                foreach (var q in query)
                {
                    q.ab_add = item.ab_add;
                    q.ab_age = item.ab_age;
                    q.ab_com = item.ab_com;
                    q.ab_dub = item.ab_dub;
                    q.ab_name = item.ab_name;
                    q.ab_sex = item.ab_sex;
                    q.ab_tel = item.ab_tel;
                }

                this.dataContext.SubmitChanges();
                this.BookBindingList = this.dataContext.TabAddressBook.GetNewBindingList();
            }
        }

        /// <summary>
        /// 删除一个电话簿记录
        /// </summary>
        public void Delete(TabAddressBook item)
        {
            if (item != null)
            {

                var query = from i in this.dataContext.TabAddressBook
                            where i.ab_id == item.ab_id
                            select i;

                foreach (var q in query)
                    this.dataContext.TabAddressBook.DeleteOnSubmit(q);

                this.dataContext.SubmitChanges();
                this.BookBindingList = this.dataContext.TabAddressBook.GetNewBindingList();
            }
        }

        /// <summary>
        /// 搜索
        /// </summary>
        public IEnumerable<TabAddressBook> Search(string p)
        {
            //利用LINQ搜索数据
            var query = from q in this.dataContext.TabAddressBook
                        where q.ab_name.IndexOf(p) > -1
                        select q;

            return query;
        }
    }
}
