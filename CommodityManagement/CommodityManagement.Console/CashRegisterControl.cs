using System;
using System.Linq;
using System.Windows.Forms;
using CommodityManagement.Model;

namespace CommodityManagement.Console
{
    /// <summary>
    /// 收银台界面控件
    /// </summary>
    public partial class CashRegisterControl : UserControl, ICashRegisterControl
    {
        public CashRegisterControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.buylst.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 结账完毕
        /// </summary>
        public event EventHandler Finish;

        private CashRegister checkOut;
        /// <summary>
        /// 收银台控制器
        /// </summary>
        public CashRegister CheckOut
        {
            get
            {
                return checkOut;
            }
            set
            {
                if (checkOut != null)
                {
                    eventbind(false);
                    checkOut = null;
                }

                checkOut = value;
                
                if (value != null)
                {
                    databind(this.checkOut.Sum());
                    eventbind(true);
                }
            }
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void databind(double total)
        {
            if (this.checkOut != null)
            {
                this.buylst.DataSource = this.checkOut.Buys.ToList();
            }

            this.txttotal.Text = total.ToString();
        }

        /// <summary>
        /// 事件绑定
        /// </summary>
        /// <param name="b"></param>
        private void eventbind(bool b)
        {
            if (this.checkOut != null)
            {
                if (b)
                {
                    this.checkOut.NotFoundCommodity += new EventHandler(checkOut_NotFoundCommodity);
                    this.checkOut.FindCommodity += new EventHandler<CashRegisterEventArgs>(checkOut_FindCommodity);
                    this.checkOut.Finish += new EventHandler<CashRegisterEventArgs>(checkOut_Finish);
                }
                else
                {
                    this.checkOut.NotFoundCommodity -= new EventHandler(checkOut_NotFoundCommodity);
                    this.checkOut.FindCommodity -= new EventHandler<CashRegisterEventArgs>(checkOut_FindCommodity);
                    this.checkOut.Finish -= new EventHandler<CashRegisterEventArgs>(checkOut_Finish);
                }
            }
        }

        void checkOut_Finish(object sender, CashRegisterEventArgs e)
        {
            this.reset();
            if (this.Finish != null)
                this.Finish(this, EventArgs.Empty);
        }

        /// <summary>
        /// 添加商品
        /// </summary>
        void checkOut_FindCommodity(object sender, CashRegisterEventArgs e)
        {
            databind(e.Total);
           
            this.buylst.Rows[this.buylst.Rows.Count - 1].Selected = true;
            this.buylst.FirstDisplayedScrollingRowIndex = this.buylst.Rows.Count - 1;
            this.txtsec.Text = string.Empty;
            this.txtsec.Focus();
        }
         
        void checkOut_NotFoundCommodity(object sender, EventArgs e)
        {
            MessageBox.Show("商品没有找到", "收银台");
            this.txtsec.SelectAll();
        }

        private void txtcash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Control c in this.buylst.Controls)
                    System.Diagnostics.Debug.WriteLine(c.ToString());

                if (MessageBox.Show("是否结账？", "收银台", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //结账
                    if (this.checkOut != null)
                        this.checkOut.SettleAccounts();
                }
            }
        }

        private void txtcash_TextChanged(object sender, System.EventArgs e)
        {
           double cash = -1;
           
            if (double.TryParse(this.txtcash.Text, out cash))
               this.txtchg.Text = (cash - Convert.ToDouble(this.txttotal.Text)).ToString(); 
        }

        private void txtsec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtsec.Text = this.txtsec.Text.Trim();
                
                if (this.txtsec.Text.Length < 1)
                    return;

                //检索商品
                if (this.checkOut != null)
                    this.checkOut.Check(this.txtsec.Text);

                this.txtsec.SelectAll();
            }
        }

        private void txtcash_Enter(object sender, EventArgs e)
        {
            this.txttotal.Text = this.checkOut.Sum().ToString();
            txtcash.SelectAll();
        }

        private void txtsec_VisibleChanged(object sender, EventArgs e)
        {
            this.txtsec.Focus();
        }

        private void buylst_KeyDown(object sender, KeyEventArgs e)
        {
            //删除选中行
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in this.buylst.SelectedRows)
                {
                    RunningAccount ra = row.DataBoundItem as RunningAccount;

                    if (ra != null)
                    {
                        var q = from item in this.checkOut.Buys
                                where item.Id == ra.Id
                                select item;
                        if (q.Any())
                            this.checkOut.Buys.Remove(q.First());
                    }
                }

                this.databind(this.checkOut.Sum());
            }
        }

        /// <summary>
        /// 放弃全部内容
        /// 并清除记录
        /// </summary>
        public void Clear()
        {
            this.checkOut.Clear();
            this.reset();
        }

        /// <summary>
        /// 复位控件
        /// </summary>
        private void reset()
        {
            this.databind(0);
            this.txtcash.Text = string.Empty;
            this.txtchg.Text = "0";
            this.txtsec.Text = string.Empty;
            this.txtsec.Focus();
        }

    }
}
