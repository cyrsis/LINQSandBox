using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace DemoRss
{
    /// <summary>
    /// 生成 RSS 2.0 
    /// </summary>
    public class Rss
    {
        public Rss()
        {
            this.Items = new List<RssItem>();
            this.Language = RssLanguageEnum.SimplifiedChinese;
        }

        /// <summary>
        /// RSS註釋
        /// </summary>
        public string RssComment { get; set; }
        /// <summary>
        /// 頻道標題
        /// </summary>
        public string Title{ get; set; }
        /// <summary>
        /// 頻道總地址
        /// </summary>
        public string Link{ get; set; }
        /// <summary>
        /// 頻道說明
        /// </summary>
        public string Description{ get; set; }
        /// <summary>
        /// 頻道語言
        /// </summary>
        public RssLanguageEnum Language { get; set; }
        /// <summary>
        /// 頻道發佈時間
        /// </summary>
        public DateTime PubDate { get; set; }
        /// <summary>
        /// 頻道最終更新時間
        /// </summary>
        public DateTime LastBuildDate { get; set; }
        /// <summary>
        /// 此 RSS 文件地址
        /// </summary>
        public string Docs { get; set; }

        /// <summary>
        /// 項目集合
        /// </summary>
        public List<RssItem> Items { get; private set; }

        /// <summary>
        /// 生成RSS，並按照字符串的形式返回
        /// </summary>
        /// <returns>RSS 字符串</returns>
        public string Build()
        {
            return this.Build(null, null);
        }

        /// <summary>
        /// 生成RSS，並寫入到一個流
        /// </summary>
        /// <param name="stream">流</param>
        public void Build(Stream stream)
        {
            this.Build(null, stream);
        }

        /// <summary>
        /// 生成RSS並寫入到檔案
        /// </summary>
        /// <param name="filename">檔案名</param>
        public void Build(string filename)
        {
            this.Build(filename,null);
        }

        /// <summary>
        /// 生成RSS
        /// </summary>
        /// <param name="filename">儲存RSS的檔案名</param>
        /// <param name="stream">需要把RSS寫入的流</param>
        /// <returns>RSSXML樹字符串</returns>
        public string Build(string filename,Stream stream)
        {

            XElement channel = new XElement(
                "channel",
                 new XElement("title", this.Title),
                 new XElement("link", this.Link),
                 new XElement("description", this.Description),
                 new XElement("language", RssLanguage.Language(this.Language)),
                 new XElement("pubDate", this.PubDate.ToString("r")),
                 new XElement("lastBuildDate", this.LastBuildDate.ToString("r")),
                 new XElement("docs", this.Docs)
                 );

            XElement rss = new XElement("rss", new XAttribute("version", "2.0"), channel);

            XDocument rssdoc = new XDocument(
                new XDeclaration("1.0", "utf8", null),
                new XComment(this.RssComment),
                rss
                );


            foreach (RssItem i in this.Items)
                channel.Add(i.Item);

            if (filename != null)
            {
                //儲存到檔案
                rssdoc.Save(filename);
            }

            if (stream != null)
            {
                //寫入到流
                using (XmlWriter xw = XmlWriter.Create(stream))
                {
                    rssdoc.WriteTo(xw);
                    xw.Flush();
                }
            }

            string str = null;
            
            //寫入到字符串
            using (StringWriter sw = new StringWriter())
            {
                rssdoc.Save(sw, SaveOptions.None);
                sw.Flush();
                str = sw.ToString();
            }

            return str;
        }
    }
}
