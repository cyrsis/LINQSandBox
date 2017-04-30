using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace CommodityManagement.Model
{
    /// <summary>
    /// 数据层
    /// </summary>
    public class DataLayer : IDisposable
    {
        ~DataLayer()
        {
            Dispose(false);
        }

        #region IDisposable 成员

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    context.Dispose();
                }

            }
        }

        #endregion

        private CommodityManagementDataContext context;

        /// <summary>
        /// 根据是否持久化，初始化实体类
        /// 一般情况下网页界面不需要持久连接的实体
        /// winform的桌面程序可以使用持久连接的实体
        /// </summary>
        private CommodityManagementDataContext Context
        {
            get
            {
                if (!this.isPersistent && context == null)
                    this.context = new CommodityManagementDataContext();

                return context;
            }
            set
            {
                ///释放实体类资源
                if (value == null && context != null && !this.isPersistent)
                {
                    this.context.Dispose();
                    this.context = null;
                }
            }
        }

        /// <summary>
        /// 返回修改对象
        /// </summary>
        public ChangeSet GetChangeSet()
        {
            if (context != null)
                return context.GetChangeSet();
            else
                return null;
        }

        private bool isPersistent;

        /// <summary>
        /// 是否需要持久连接
        /// </summary>
        public bool IsPersistent
        {
            get
            {
                return this.isPersistent;
            }
            set
            {
                this.isPersistent = value;

                if (context == null && value)
                    this.context = new CommodityManagementDataContext();

                if (!value)
                    this.Context = null;
            }
        }

        /// <summary>
        /// 获取持久连接下的全部商品表
        /// </summary>
        public Table<CommodityList> Commodities
        {
            get
            {
                if (!this.isPersistent)
                    this.IsPersistent = true;

                return this.Context.CommodityList;
            }
        }


        /// <summary>
        /// 获取持久连接下的流水帐
        /// </summary>
        public Table<RunningAccount> Account
        {
            get
            {
                if (!this.isPersistent)
                    this.IsPersistent = true;

                return this.Context.RunningAccount;
            }
        }

             /// <summary>
        /// 分页获取商品列表
        /// </summary>
        /// <param name="ipage">页码，从编号1开始</param>
        /// <returns>记录集</returns>
        public IEnumerable<CommodityList> GetCommodityListPage(int ipage,int pagerow)
        {
            ipage--;

            if (ipage < 0)
                ipage = 0;

            var q = this.Context.CommodityList.Skip(pagerow * ipage).Take(pagerow);

            return getCommodities(q);
        }

        /// <summary>
        /// 搜索商品
        /// </summary>
        /// <param name="skey">关键字</param>
        /// <returns>记录集</returns>
        public IEnumerable<CommodityList> SerachCommodities(string skey)
        {
            var q = from row in this.Context.CommodityList
                    where row.Barcode == skey ||
                            row.Name.IndexOf(skey) > -1
                    select row;

            return getCommodities(q);
        }

        private IEnumerable<CommodityList> getCommodities(IQueryable<CommodityList> query)
        {
            if (this.isPersistent)
                return query;

            else
            {
                IEnumerable<CommodityList> rows = query.ToList();
                this.Context = null;
                return rows;
            }
        }

        /// <summary>
        /// 分页获取流水账
        /// </summary>
        /// <param name="ipage">页码，从编号1开始</param>
        /// <returns>记录集</returns>
        public IEnumerable<RunningAccount> GetRunningAccountPage(int ipage,int pagerow)
        {
            ipage--;

            if (ipage < 0)
                ipage = 0;

            var q = this.Context.RunningAccount.Skip(pagerow * ipage).Take(pagerow);

            return getAccount(q);
        }

        /// <summary>
        /// 获取某天的流水账
        /// </summary>
        /// <param name="date">某天的日期</param>
        /// <returns></returns>
        public IEnumerable<RunningAccount> GetRunningAccountByDay(DateTime date)
        {
            var q = from row in this.Context.RunningAccount
                    where row.Date.Year == date.Year &&
                    row.Date.Month == date.Month && row.Date.Day == date.Day
                    select row;

            return getAccount(q);
        }

        private IEnumerable<RunningAccount> getAccount(IQueryable<RunningAccount> query)
        {
            if (this.isPersistent)
                return query;

            else
            {
                IEnumerable<RunningAccount> rows = query.ToList();
                this.Context = null;
                return rows;
            }
        }

        /// <summary>
        /// 添加流水账
        /// </summary>
        public void AppendAccount(RunningAccount account)
        {
            this.Context.RunningAccount.InsertOnSubmit(account);

            if (!this.isPersistent)
                this.Context.SubmitChanges();

            this.Context = null;
        }

        /// <summary>
        /// 删除流水账项目
        /// </summary>
        public void DeleteAccount(long aid)
        {
            var q = from row in this.Context.RunningAccount
                    where row.Id == aid
                    select row;

            if (q.Any())
                this.Context.RunningAccount.DeleteOnSubmit(q.First());

            if (!this.isPersistent)
                this.Context.SubmitChanges();

            this.Context = null;
        }

        /// <summary>
        /// 获取流水帐记录数
        /// </summary>
        /// <returns></returns>
        public int GetAccountCount()
        {
            int i = this.Context.RunningAccount.Count();
            this.Context = null;

            return i;
        }

        /// <summary>
        /// 获取流水帐记录数
        /// </summary>
        /// <returns></returns>
        public int GetCommoditiesCount()
        {
            int i = this.Context.CommodityList.Count();
            this.Context = null;

            return i;
        }

        /// <summary>
        /// 刷新或保存完毕
        /// </summary>
        public event EventHandler ChangedOrSaved;
        
        /// <summary>
        /// 持久连接下保存数据
        /// </summary>
        public void Save()
        {
            if (this.isPersistent)
            {
                this.Context.SubmitChanges();
                if (ChangedOrSaved != null)
                    ChangedOrSaved(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 持久连接下刷新数据
        /// </summary>
        public void Refresh()
        {
            if (this.isPersistent)
            {
                try
                {
                    this.Context.Refresh(RefreshMode.OverwriteCurrentValues, this.Context.CommodityList);
                    this.Context.Refresh(RefreshMode.OverwriteCurrentValues, this.Context.RunningAccount);
                }
                catch
                {
                    this.Context = null;
                    this.isPersistent = true;
                }

                if (ChangedOrSaved != null)
                    ChangedOrSaved(this, EventArgs.Empty);
            }
        }
    
    }
}
