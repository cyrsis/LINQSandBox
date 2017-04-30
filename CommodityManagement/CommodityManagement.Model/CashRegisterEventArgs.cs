using System;
using System.Collections.Generic;

namespace CommodityManagement.Model
{
    /// <summary>
    /// 收银台事件数据类
    /// </summary>
    public class CashRegisterEventArgs :EventArgs
    {
        /// <summary>
        /// 帐目
        /// </summary>
        public RunningAccount Account { get; private set; }

        /// <summary>
        /// 累计总价
        /// </summary>
        public double Total { get; private set; }

        /// <summary>
        /// 账单
        /// </summary>
        public List<RunningAccount> List { get; private set; }

        public CashRegisterEventArgs(List<RunningAccount> lst)
        {
            this.List = lst;
        }

        public CashRegisterEventArgs(RunningAccount a,double t)
        {
            this.Account = a;
            this.Total = t;
        }
    }
}
