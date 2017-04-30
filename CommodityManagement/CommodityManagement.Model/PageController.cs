using System;

namespace CommodityManagement.Model
{
    /// <summary>
    /// 分页控制
    /// </summary>
    public class PageController
    {
        public PageController()
        {
            this.Now = 1;
            this.Total = 1;
            this.PageRows = 10;
        }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int Now{ get; set; }
        
        /// <summary>
        /// 总页数
        /// </summary>
        public int Total { get; private set; }

        private int pageRows;

        /// <summary>
        /// 每页记录数
        /// </summary>
        public int PageRows 
        {
            get
            {
                return pageRows;
            }
            set
            {
                this.pageRows = value;
                this.countpage();
            }
        }

        private long totalRows;

        /// <summary>
        /// 总记录数
        /// </summary>
        public long TotalRows
        {
            get
            {
                return totalRows;
            }
            set
            {
                this.totalRows = value;
                this.countpage();
            }
        }

        /// <summary>
        /// 计算页数
        /// </summary>
        private void countpage()
        {
            this.Total = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.totalRows) / Convert.ToDouble(this.PageRows)));

            FireEvent();
        }

        /// <summary>
        /// 引发事件
        /// </summary>
        public void FireEvent()
        {
            if (this.Total < 2)
            {
                if (OnlyPage != null)
                    OnlyPage(this, EventArgs.Empty);

                return;
            }

            if (Now == 1)
            {
                if (FirstPage != null)
                    FirstPage(this, EventArgs.Empty);

                return;
            }

            if (Now == this.Total)
            {
                if (LastPage != null)
                    LastPage(this, EventArgs.Empty);

                return;
            }

            if (Now > 1 && Now < this.Total)
            {
                if (Page != null)
                    Page(this, EventArgs.Empty);

                return;
            }

        }

        /// <summary>
        /// 首页
        /// </summary>
        public event EventHandler FirstPage;

        /// <summary>
        /// 末页
        /// </summary>
        public event EventHandler LastPage;

        /// <summary>
        /// 页
        /// </summary>
        public event EventHandler Page;

        /// <summary>
        /// 只有一页
        /// </summary>
        public event EventHandler OnlyPage;

        /// <summary>
        /// 下一页
        /// </summary>
        public void Next()
        {
            this.Now++;
            if (this.Now > this.Total)
                this.Now = this.Total;

            FireEvent();
        }

        /// <summary>
        /// 前一页
        /// </summary>
        public void Previous()
        {
            this.Now--;
            if (this.Now < 1)
                this.Now = 1;
            FireEvent();
        }

        /// <summary>
        /// 首页
        /// </summary>
        public void First()
        {
            this.Now = 1;
            FireEvent();
        }

        public void Last()
        {
            this.Now = this.Total;
            FireEvent();
        }
    }
}
