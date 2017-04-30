using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DemoCheckWord
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///���αӷP��
            string[] wordlst = this.words.Text.Split(new char[]{(char)10,(char)13}, StringSplitOptions.RemoveEmptyEntries);
            ///�ϥΪ̶ǰe�����
            string utext = this.UserText.Text.Replace("\n","<br>");
            //�ӷP�����X
            string wordmask = "*";

            if (this.Page.IsPostBack)
            {
                //�ͦ����h��F��
                string pattern = wordlst.Aggregate("(?is)", 
                                                    (w1, w2) => string.Format("{0}|{1}",w1, w2), 
                                                    str => str.Remove(str.IndexOf("|"), 1));

                ///��X�y�l�]�t���ӷP��
                var cw = from w in wordlst
                         where utext.IndexOf(w) > -1
                         select w;

                //�]�t���ӷP���ƶq
                int icount = cw.Count();

                //�X�ֹL�o�������ӷP��
                string strwd = cw.Aggregate("<b>�]�t���ӷP���G</b>", 
                                            (w1, w2) => string.Format("{0}�B{1}", w1, w2), 
                                            str => str.Remove(str.IndexOf("�B"), 1));


                //��X���G
                this.ShowText.Text = string.Format("<b>���h��F���G</b>{0}<br><b>�L�o�᪺���e�G</b><br>{1}<br>{2}<br><b>�]�t���ӷP���ƶq�G</b>{3}", pattern, Regex.Replace(utext, pattern, wordmask), strwd, icount);

            }
        }
    }
}
