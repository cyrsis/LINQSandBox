using System;
namespace CommodityManagement.Model
{
    /// <summary>
    /// 收银台界面接口
    /// </summary>
    public interface ICashRegisterControl
    {
        CommodityManagement.Model.CashRegister CheckOut { get; set; }
        event EventHandler Finish;
        void Clear();
    }
}
