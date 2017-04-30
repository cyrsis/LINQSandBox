using System;
using System.Xml.Linq;

namespace DemoRss
{
    /// <summary>
    /// Rss ���ظ��
    /// </summary>
    public class RssItem
    {
        /// <summary>
        /// ���D
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// �챵�a�}
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// ���e²�n�y�z
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// �o�G�ɶ�
        /// </summary>
        public DateTime PubDate { get; set; }
        /// <summary>
        /// �ؿ��B���O
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// �@��
        /// </summary>
        public string Author { get; set; }
        public string Guid { get; set; }

        /// <summary>
        /// ���ظ`�I
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
