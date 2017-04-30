using System;
using System.Data.Linq;
using System.Windows.Forms;
using CommodityManagement.Model;

namespace CommodityManagement.Console
{
    public partial class ConsoleView : Form
    {
        private Shop shop;
        private CashRegisterControl crc;

        public ConsoleView()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Initialize()
        {
            this.acclst.AutoGenerateColumns = false;
            this.comlst.AutoGenerateColumns = false;
            this.toolseldate.Control.Controls.Add(this.dateTimePicker);
            this.dateTimePicker.Visible = true;
            this.dateTimePicker.Dock = DockStyle.Fill;
            this.crc = new CashRegisterControl();
            this.cashPage.Controls.Add(this.crc);
            this.shop = new Shop(this.crc);
            //持续连接
            this.shop.DataController.IsPersistent = true;
            this.shop.RefreshAccount += new EventHandler(shop_RefreshAccount);

            this.shop.AccountPageController.FirstPage += new EventHandler(AccountPageController_FirstPage);
            this.shop.AccountPageController.LastPage += new EventHandler(AccountPageController_LastPage);
            this.shop.AccountPageController.Page += new EventHandler(AccountPageController_Page);
            this.shop.AccountPageController.OnlyPage += new EventHandler(AccountPageController_OnlyPage);
            this.shop.AccountPageController.FireEvent();

            this.shop.CommoditiesPageController.FirstPage += new EventHandler
(CommoditiesPageController_FirstPage);
            this.shop.CommoditiesPageController.LastPage += new EventHandler(CommoditiesPageController_LastPage);
            this.shop.CommoditiesPageController.Page += new EventHandler(CommoditiesPageController_Page);
            this.shop.CommoditiesPageController.OnlyPage += new EventHandler(CommoditiesPageController_OnlyPage);

            this.bindAcc();
            this.bindComm();
        }

        void CommoditiesPageController_OnlyPage(object sender, EventArgs e)
        {
            toolStripButton12.Enabled = false;
            toolStripButton13.Enabled = false;
            toolStripButton11.Enabled = false;
            toolStripButton14.Enabled = false;
        }

        void CommoditiesPageController_Page(object sender, EventArgs e)
        {
            toolStripButton12.Enabled = true;
            toolStripButton13.Enabled = true;
            toolStripButton11.Enabled = true;
            toolStripButton14.Enabled = true;
        }

        void CommoditiesPageController_LastPage(object sender, EventArgs e)
        {
            toolStripButton12.Enabled = true;
            toolStripButton13.Enabled = true;
            toolStripButton11.Enabled = false;
            toolStripButton14.Enabled = false;
        }

        void CommoditiesPageController_FirstPage(object sender, EventArgs e)
        {
            toolStripButton12.Enabled = false;
            toolStripButton13.Enabled = false;
            toolStripButton11.Enabled = true;
            toolStripButton14.Enabled = true;
        }

        void AccountPageController_OnlyPage(object sender, EventArgs e)
        {
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            toolStripButton5.Enabled = false;
            toolStripButton6.Enabled = false;
        }

        void AccountPageController_Page(object sender, EventArgs e)
        {
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            toolStripButton5.Enabled = true;
            toolStripButton6.Enabled = true;
        }

        void AccountPageController_LastPage(object sender, EventArgs e)
        {
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            toolStripButton5.Enabled = false;
            toolStripButton6.Enabled = false;
        }

        void AccountPageController_FirstPage(object sender, EventArgs e)
        {
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            toolStripButton5.Enabled = true;
            toolStripButton6.Enabled = true;
        }

        void shop_RefreshAccount(object sender, EventArgs e)
        {
            bindAcc();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.shop.DataController.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.shop.CheckOutView.Clear();
            this.shop.DataController.Refresh();
            this.bindAcc();
            this.bindComm();
        }

        private void ConsoleView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeSet chg = this.shop.DataController.GetChangeSet();

            if (chg != null)
            {
                if (chg.Deletes.Count > 0 || chg.Inserts.Count > 0 || chg.Updates.Count > 0)
                {
                    if (MessageBox.Show("检测到数据已经改变，是否保存到数据库？", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        this.shop.DataController.Save();

                }
            }
        }

        private void bindAcc()
        {
            this.acclst.DataSource = this.shop.DataController.GetRunningAccountPage(this.shop.AccountPageController.Now, this.shop.AccountPageController.PageRows);
        }


        private void bindComm()
        {
            this.comlst.DataSource = this.shop.DataController.GetCommodityListPage(this.shop.CommoditiesPageController.Now, this.shop.CommoditiesPageController.PageRows);
        }


        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.shop.AccountPageController.First();
            bindAcc();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.shop.AccountPageController.Previous();
            bindAcc();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.shop.AccountPageController.Next();
            bindAcc();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.shop.AccountPageController.Last();
            bindAcc();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.shop.AccountPageController.First();
            bindComm();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            this.shop.AccountPageController.Previous();
            bindComm();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.shop.AccountPageController.Next();
            bindComm();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.shop.AccountPageController.Last();
            bindComm();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            this.acclst.DataSource = this.shop.DataController.GetRunningAccountByDay(this.dateTimePicker.Value);
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            bindAcc();
        }
    }
}
