using System;
using System.Linq;
using System.Text;
using DemoOrder;

namespace DemoRss
{
    /// <summary>
    /// 控制器
    /// </summary>
    public class RssController
    {
        public RssController()
        {
            this.RSS = new Rss();
        }

        /// <summary>
        /// RSS 生成器
        /// </summary>
        public Rss RSS { get; private set; }

        /// <summary>
        /// 加載資料
        /// </summary>
        public void Load()
        {
            this.RSS.Items.Clear();

            using (AddressBookDataContext abdc = new AddressBookDataContext())
            {
                var count = from item in abdc.TabAddressBook
                        let cc = (from l in item.TabShoppingListEntity let c = l.Price*l.Amount select c).Sum()
                        where cc > 0
                        orderby cc descending
                        select new { Count = cc, Row = item };
                
                foreach (var row in count)
                {
                    RssItem item = new RssItem();
                    item.Title = string.Format("{0} 的訂單",row.Row.Name);
                    item.Author = row.Row.Name;
                    item.Category = "訂單";
                    item.Link = "#";
                    item.PubDate = DateTime.Now;
                    item.Guid = row.Row.TelphoneNumber;
                    StringBuilder sb = new StringBuilder(string.Format("<p><b>{0}</b> {1} {2} 小計：{3} </p><p><b>訂購：</b></p>", row.Row.Name, row.Row.Sex, row.Row.TelphoneNumber, row.Count.ToString("c")));
                    foreach(var lst in row.Row.TabShoppingListEntity)
                        sb.AppendFormat("<p>{0} {2} {3} 單價：{1} 共計：{4}</p>", lst.Product, lst.Price.ToString("c"), lst.Amount, lst.Unit, (lst.Price * lst.Amount).ToString("c"));

                    item.Description = sb.ToString();

                    this.RSS.Items.Add(item);
                }
            }
        }

    }
}
