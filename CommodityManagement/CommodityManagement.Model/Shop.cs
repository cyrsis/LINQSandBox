using System;

namespace CommodityManagement.Model
{

    /// <summary>
    /// 商店模型
    /// </summary>
    public class Shop : IDisposable
    {
        ~Shop()
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
                if (this.DataController != null)
                {
                    DataController.Dispose();
                }

            }
        }

        #endregion

        /// <summary>
        /// 需要刷新流水帐数据
        /// </summary>
        public event EventHandler RefreshAccount;

        public Shop(bool persistent)
        {
            Initialize(null, persistent);
        }

        public Shop()
        {
            Initialize(null,false);
        }
        public Shop(ICashRegisterControl checkout)
        {
            Initialize(checkout,false);
        }

        /// <summary>
        /// 初始化
        /// </summary>

        private void Initialize(ICashRegisterControl checkout, bool persistent)
        {
            this.DataController = new DataLayer();
            this.DataController.IsPersistent = persistent;
            this.DataController.ChangedOrSaved += new EventHandler(DataController_ChangedOrSaved);
            
            if (checkout != null)
            {
                this.CheckOutView = checkout;
                this.CheckOutView.CheckOut = new CashRegister(this.DataController);
                this.CheckOutView.Finish += new EventHandler(CheckOutView_Finish);
            }

            this.CommoditiesPageController = new PageController();
            this.AccountPageController = new PageController();

            this.count();
        }

        /// <summary>
        /// 为分页控制器计算记录数
        /// </summary>
        private void count()
        {
            this.CommoditiesPageController.TotalRows = this.DataController.GetCommoditiesCount();
            this.AccountPageController.TotalRows = this.DataController.GetAccountCount();
        }

        /// <summary>
        /// 数据层的保存事件处理
        /// </summary>
        void DataController_ChangedOrSaved(object sender, EventArgs e)
        {
            this.count();
        }

        /// <summary>
        /// 收银台的完成收银事件理出
        /// </summary>
        void CheckOutView_Finish(object sender, EventArgs e)
        {
            this.DataController.Save();

            if (RefreshAccount != null)
                RefreshAccount(this, EventArgs.Empty);

        }

        /// <summary>
        /// 数据层
        /// </summary>
        public DataLayer DataController { get; private set; } 

        /// <summary>
        /// 收银台
        /// </summary>
        public ICashRegisterControl CheckOutView { get; private set; }

        /// <summary>
        /// 流水账分页控制
        /// </summary>
        public PageController AccountPageController { get; private set; }
        
        /// <summary>
        /// 商品列表分页控制
        /// </summary>
        public PageController CommoditiesPageController { get; private set; }

    }
}
