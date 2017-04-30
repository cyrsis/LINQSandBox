using System;
using CommodityManagement.Model;

namespace CommodityManagement.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);

            if (this.shop != null)
            {
                this.shop.Dispose();
                this.shop = null;
            }
        }

        private Shop shop;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.shop = new Shop();
            shop.CommoditiesPageController.FirstPage += new EventHandler(CommoditiesPageController_FirstPage);
            shop.CommoditiesPageController.LastPage += new EventHandler(CommoditiesPageController_LastPage);
            shop.CommoditiesPageController.OnlyPage += new EventHandler(CommoditiesPageController_OnlyPage);
            shop.CommoditiesPageController.Page += new EventHandler(CommoditiesPageController_Page);

            shop.CommoditiesPageController.Now = Convert.ToInt32(this.pagenum.Text);

            //每页显示的记录数
            shop.CommoditiesPageController.PageRows = Convert.ToInt32(this.pagerow.Text);

            this.bindcomm();
        }

        private void bindcomm()
        {
            this.CommoditiesShow.DataSource = shop.DataController.GetCommodityListPage(shop.CommoditiesPageController.Now, shop.CommoditiesPageController.PageRows);
            this.CommoditiesShow.DataBind();

            this.info.Text = string.Format("共计　{0}　条记录，分　{1}　页显示，当前是第　{2}　页。", shop.CommoditiesPageController.TotalRows, shop.CommoditiesPageController.Total, shop.CommoditiesPageController.Now);

        }

        void CommoditiesPageController_Page(object sender, EventArgs e)
        {
            this.fistbut.Enabled = true;
            this.prebut.Enabled = true;
            this.nextbut.Enabled = true;
            this.lastbut.Enabled = true;
        }

        void CommoditiesPageController_OnlyPage(object sender, EventArgs e)
        {
            this.fistbut.Enabled = false;
            this.prebut.Enabled = false;
            this.nextbut.Enabled = false;
            this.lastbut.Enabled = false;
        }

        void CommoditiesPageController_LastPage(object sender, EventArgs e)
        {
            this.fistbut.Enabled = true;
            this.prebut.Enabled = true;
            this.nextbut.Enabled = false;
            this.lastbut.Enabled = false;
        }

        void CommoditiesPageController_FirstPage(object sender, EventArgs e)
        {
            this.fistbut.Enabled = false;
            this.prebut.Enabled = false;
            this.nextbut.Enabled = true;
            this.lastbut.Enabled = true;
        }
        protected void fistbut_Click(object sender, EventArgs e)
        {
            shop.CommoditiesPageController.First();
            this.pagenum.Text = shop.CommoditiesPageController.Now.ToString();
            this.bindcomm();
        }
        protected void prebut_Click(object sender, EventArgs e)
        {
            shop.CommoditiesPageController.Previous();
            this.pagenum.Text = shop.CommoditiesPageController.Now.ToString();
            this.bindcomm();
        }
        protected void nextbut_Click(object sender, EventArgs e)
        {
            shop.CommoditiesPageController.Next();
            this.pagenum.Text = shop.CommoditiesPageController.Now.ToString();
            this.bindcomm();
        }
        protected void lastbut_Click(object sender, EventArgs e)
        {
            shop.CommoditiesPageController.Last();
            this.pagenum.Text = shop.CommoditiesPageController.Now.ToString();
            this.bindcomm();
        }

        /// <summary>
        /// 搜索商品
        /// </summary>
        protected void secbut_Click(object sender, EventArgs e)
        {
            this.seckey.Text = this.seckey.Text.Trim();
            if (this.seckey.Text.Length == 0)
            {
                shop.CommoditiesPageController.First();
                this.pagenum.Text = shop.CommoditiesPageController.Now.ToString();
                this.bindcomm();
                this.nav.Visible = true;
                this.info.Visible = true;
            }
            else
            {
                this.nav.Visible = false;
                this.info.Visible = false;
                this.CommoditiesShow.DataSource = shop.DataController.SerachCommodities(this.seckey.Text);
                this.CommoditiesShow.DataBind();
            }
        }
    }
}
