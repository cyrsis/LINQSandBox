using System.Collections.Generic;
using System.Xml.Linq;
using CommodityManagement.Model;

namespace CommodityManagement.Web
{
    /// <summary>
    /// 商品列表显示控件
    /// </summary>
    public partial class CommoditiesShow : System.Web.UI.UserControl
    {
               /// <summary>
        /// 利用LINQ to XML 生成HTML 元素
        /// </summary>
        private void genshow()
        {
            if (this.dataSource == null)
                return;

            XElement div = new XElement("div");

            foreach (CommodityList r in this.dataSource)
            {
                XElement name = new XElement("div",
                    new XAttribute("style",
                        "font-size:16px;color:blue;font-weight:bold;text-indent:12px;"),
                        string.Format("商品名称：{0}", r.Name));

                div.Add(name);
                XElement item = new XElement("div",
                   new XAttribute("style",
                       "font-size:14px;text-indent:12px;"),
                       "单价:", new XElement("b", r.Price.ToString("c")),
                       " 编号:", new XElement("b", r.Id),
                       " 库存数量:", new XElement("b", r.Amount),
                       " 进货日期:", new XElement("b", r.Date.ToString()),
                   new XElement("p")
                       );

                div.Add(item);
            }

            this.show.Text = div.ToString();
        }

        private IEnumerable<CommodityList> dataSource;
        /// <summary>
        /// 数据源
        /// </summary>
        public IEnumerable<CommodityList> DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        public override void DataBind()
        {
            genshow();
        }

    }
}