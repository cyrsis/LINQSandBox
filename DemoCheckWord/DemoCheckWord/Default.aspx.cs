using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DemoCheckWord
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///分割敏感詞
            string[] wordlst = this.words.Text.Split(new char[]{(char)10,(char)13}, StringSplitOptions.RemoveEmptyEntries);
            ///使用者傳送的資料
            string utext = this.UserText.Text.Replace("\n","<br>");
            //敏感詞掩碼
            string wordmask = "*";

            if (this.Page.IsPostBack)
            {
                //生成正則表達式
                string pattern = wordlst.Aggregate("(?is)", 
                                                    (w1, w2) => string.Format("{0}|{1}",w1, w2), 
                                                    str => str.Remove(str.IndexOf("|"), 1));

                ///找出句子包含的敏感詞
                var cw = from w in wordlst
                         where utext.IndexOf(w) > -1
                         select w;

                //包含的敏感詞數量
                int icount = cw.Count();

                //合併過濾掉的的敏感詞
                string strwd = cw.Aggregate("<b>包含的敏感詞：</b>", 
                                            (w1, w2) => string.Format("{0}、{1}", w1, w2), 
                                            str => str.Remove(str.IndexOf("、"), 1));


                //輸出結果
                this.ShowText.Text = string.Format("<b>正則表達式：</b>{0}<br><b>過濾後的內容：</b><br>{1}<br>{2}<br><b>包含的敏感詞數量：</b>{3}", pattern, Regex.Replace(utext, pattern, wordmask), strwd, icount);

            }
        }
    }
}
