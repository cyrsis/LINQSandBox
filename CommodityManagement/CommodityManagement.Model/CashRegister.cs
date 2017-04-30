using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;

namespace CommodityManagement.Model
{
    /// <summary>
    /// 收银台控制器
    /// </summary>
    public class CashRegister
    {
        private DataLayer data;

        /// <summary>
        /// 尚未结账的商品
        /// </summary>
        public List<RunningAccount> Buys { get; private set; }

        public CashRegister(DataLayer dl)
        {
            this.data = dl;
            this.Buys = new List<RunningAccount>();
        }

        /// <summary>
        /// 找到商品
        /// </summary>
        public event EventHandler<CashRegisterEventArgs> FindCommodity;
        
        /// <summary>
        /// 没有找到商品
        /// </summary>
        public event EventHandler NotFoundCommodity;

        /// <summary>
        /// 结账完毕
        /// 可以传递给打印模型
        /// </summary>
        public event EventHandler<CashRegisterEventArgs> Finish;

        /// <summary>
        /// 查找商品
        /// </summary>
        public void Check(string barcode)
        {
            var q = data.SerachCommodities(barcode);

            if (q.Any())
            {
                CommodityList c = q.First();
                RunningAccount ra = new RunningAccount();
                ra.Date = DateTime.Now;
                ra.Amount = 1;
                ra.Barcode = c.Barcode;
                ra.Price = c.Price;
                ra.Name = c.Name;
                ra.CommodityListId = c.Id;

                Buys.Add(ra);

                ///引发事件
                if (FindCommodity != null)
                    FindCommodity(this, new CashRegisterEventArgs(ra, this.Sum()));
            }
            else
            {
                //引发事件
                if (NotFoundCommodity != null)
                    NotFoundCommodity(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 删除尚未结账的商品
        /// </summary>
        public void Remove(RunningAccount c)
        {
            if (Buys.Contains(c))
                Buys.Remove(c);
        }

        /// <summary>
        /// 清除尚未结账的商品
        /// </summary>
        public void Clear()
        {
           Buys.Clear();
        }

        /// <summary>
        /// 结账
        /// </summary>
        public void SettleAccounts()
        {
            foreach (var c in this.Buys)
                this.data.AppendAccount(c);

            this.Clear();

            //引发事件
            if (Finish != null)
                Finish(this, new CashRegisterEventArgs(this.Buys.ToList()));

        }

        /// <summary>
        /// 统计总价
        /// </summary>
        public double Sum()
        {
            return this.Buys.Sum(acc => acc.Price * acc.Amount);
        }

    }
}
