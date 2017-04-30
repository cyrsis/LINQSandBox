using System;
using System.Linq;
using System.Text;
using DemoOrder;

namespace DemoRss
{
    /// <summary>
    /// ���
    /// </summary>
    public class RssController
    {
        public RssController()
        {
            this.RSS = new Rss();
        }

        /// <summary>
        /// RSS �ͦ���
        /// </summary>
        public Rss RSS { get; private set; }

        /// <summary>
        /// �[�����
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
                    item.Title = string.Format("{0} ���q��",row.Row.Name);
                    item.Author = row.Row.Name;
                    item.Category = "�q��";
                    item.Link = "#";
                    item.PubDate = DateTime.Now;
                    item.Guid = row.Row.TelphoneNumber;
                    StringBuilder sb = new StringBuilder(string.Format("<p><b>{0}</b> {1} {2} �p�p�G{3} </p><p><b>�q�ʡG</b></p>", row.Row.Name, row.Row.Sex, row.Row.TelphoneNumber, row.Count.ToString("c")));
                    foreach(var lst in row.Row.TabShoppingListEntity)
                        sb.AppendFormat("<p>{0} {2} {3} ����G{1} �@�p�G{4}</p>", lst.Product, lst.Price.ToString("c"), lst.Amount, lst.Unit, (lst.Price * lst.Amount).ToString("c"));

                    item.Description = sb.ToString();

                    this.RSS.Items.Add(item);
                }
            }
        }

    }
}
