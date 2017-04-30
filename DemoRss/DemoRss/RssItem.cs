using System;
using System.Xml.Linq;

namespace DemoRss
{
    /// <summary>
    /// Rss 項目資料
    /// </summary>
    public class RssItem
    {
        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 鏈接地址
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// 內容簡要描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 發佈時間
        /// </summary>
        public DateTime PubDate { get; set; }
        /// <summary>
        /// 目錄、類別
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
        public string Guid { get; set; }

        /// <summary>
        /// 項目節點
        /// </summary>
        public XElement Item
        {
            get
            {
                XElement item = new XElement(
                    "item",
                    new XElement("title", this.Title),
                    new XElement("link", this.Link),
                    new XElement("description",new XCData(this.Description)),
                    new XElement("pubDate", this.PubDate.ToString("r")),
                    new XElement("category", this.Category),
                    new XElement("author", this.Author),
                    new XElement("guid", this.Guid)
                    );

                    return item;
            }
        }

    }
}
