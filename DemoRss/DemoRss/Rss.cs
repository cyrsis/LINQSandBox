using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace DemoRss
{
    /// <summary>
    /// �ͦ� RSS 2.0 
    /// </summary>
    public class Rss
    {
        public Rss()
        {
            this.Items = new List<RssItem>();
            this.Language = RssLanguageEnum.SimplifiedChinese;
        }

        /// <summary>
        /// RSS����
        /// </summary>
        public string RssComment { get; set; }
        /// <summary>
        /// �W�D���D
        /// </summary>
        public string Title{ get; set; }
        /// <summary>
        /// �W�D�`�a�}
        /// </summary>
        public string Link{ get; set; }
        /// <summary>
        /// �W�D����
        /// </summary>
        public string Description{ get; set; }
        /// <summary>
        /// �W�D�y��
        /// </summary>
        public RssLanguageEnum Language { get; set; }
        /// <summary>
        /// �W�D�o�G�ɶ�
        /// </summary>
        public DateTime PubDate { get; set; }
        /// <summary>
        /// �W�D�̲ק�s�ɶ�
        /// </summary>
        public DateTime LastBuildDate { get; set; }
        /// <summary>
        /// �� RSS ���a�}
        /// </summary>
        public string Docs { get; set; }

        /// <summary>
        /// ���ض��X
        /// </summary>
        public List<RssItem> Items { get; private set; }

        /// <summary>
        /// �ͦ�RSS�A�ë��Ӧr�Ŧꪺ�Φ���^
        /// </summary>
        /// <returns>RSS �r�Ŧ�</returns>
        public string Build()
        {
            return this.Build(null, null);
        }

        /// <summary>
        /// �ͦ�RSS�A�üg�J��@�Ӭy
        /// </summary>
        /// <param name="stream">�y</param>
        public void Build(Stream stream)
        {
            this.Build(null, stream);
        }

        /// <summary>
        /// �ͦ�RSS�üg�J���ɮ�
        /// </summary>
        /// <param name="filename">�ɮצW</param>
        public void Build(string filename)
        {
            this.Build(filename,null);
        }

        /// <summary>
        /// �ͦ�RSS
        /// </summary>
        /// <param name="filename">�x�sRSS���ɮצW</param>
        /// <param name="stream">�ݭn��RSS�g�J���y</param>
        /// <returns>RSSXML��r�Ŧ�</returns>
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
                //�x�s���ɮ�
                rssdoc.Save(filename);
            }

            if (stream != null)
            {
                //�g�J��y
                using (XmlWriter xw = XmlWriter.Create(stream))
                {
                    rssdoc.WriteTo(xw);
                    xw.Flush();
                }
            }

            string str = null;
            
            //�g�J��r�Ŧ�
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
