using System;
using System.Web;

namespace DemoRss
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {

                RssController ctl = new RssController();
                ctl.RSS.LastBuildDate = DateTime.Now;
                ctl.RSS.Link = chLink.Text;
                ctl.RSS.PubDate = DateTime.Now;
                ctl.RSS.RssComment = this.RssComment.Text;
                ctl.RSS.Title = chTitle.Text;
                ctl.RSS.Description = chDescription.Text;
                ctl.Load();

                this.Response.Cache.SetNoStore();
                this.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                this.Response.Expires = -1;

                if (this.sel.SelectedIndex == 1)
                {
                    this.Response.ContentType = "text/xml";
                    ctl.RSS.Build(this.Page.Response.OutputStream);
                    this.Response.Flush();
                    this.Response.Close();
                }
                else
                {
                    ctl.RSS.Build(this.MapPath(this.RssLink.NavigateUrl));
                    this.RssLink.Visible = true;
                }

                this.MessageInfo.Text = "¥Í¦¨§¹²¦¡C";
            }
        }
    }
}
