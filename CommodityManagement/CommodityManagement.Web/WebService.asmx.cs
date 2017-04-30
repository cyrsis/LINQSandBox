using System.Linq;
using System.Web.Services;
using CommodityManagement.Model;

namespace CommodityManagement.Web
{
    /// <summary>
    /// 商品管理WebService耦合数据层
    /// </summary>
    [WebService(Namespace = "http://tiyor.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService : System.Web.Services.WebService
    {
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            ///释放商店模型占用的资源
            if (shop != null)
                shop.Dispose();
        }

        /// <summary>
        /// 商店模型，xml序列化时刻
        /// 不能释放实体对象
        /// </summary>
        private Shop shop = new Shop(true);

        /// <summary>
        /// 获取商品及其销售信息
        /// </summary>
        /// <param name="barcode">条码或品名</param>
        /// <returns>CommodityList实体</returns>
        [WebMethod]
        public CommodityList GetCommodities(string barcode)
        {
            CommodityList e = null;

            var query = shop.DataController.SerachCommodities(barcode);

            if (query.Any())
                e = query.First();

            return e;
        }
    }
}
