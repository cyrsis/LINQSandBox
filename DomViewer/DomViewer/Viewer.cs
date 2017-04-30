using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DomViewer
{

    /// <summary>
    /// RSS DOM 檢視器
    /// </summary>
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 獲取按鈕事件處理
        /// </summary>
        private void butget_Click(object sender, EventArgs e)
        {
            this.getrss();
        }

        /// <summary>
        /// 地址輸入框事件處理
        /// </summary>
        private void txturl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.getrss();
        }

        /// <summary>
        /// 處理TreeView展開事件
        /// </summary>
        private void tvdom_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                XElement tnel = e.Node.Tag as XElement;
                if (tnel != null)
                {
                    // 根據TreeView節點上儲存的XML節點用LINQ查詢其子節點
                    var els = from el in tnel.Elements()
                              select el;

                    this.appendtree(els, e.Node.Nodes, tnel);
                }
            }
        }

        /// <summary>
        /// 處理TreeView事件，選擇節點立即展開
        /// </summary>
        private void tvdom_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.Expand();
        }

        /// <summary>
        /// 或RSS檔案並轉換為XML文件並加載到TreeView控件中
        /// </summary>
        private void getrss()
        {
            try
            {
                //從網址加載Rss檔案
                XElement doc = XElement.Load(this.txturl.Text, LoadOptions.None);

                //用LINQ檢索全部子節點
                var els = from el in doc.Elements()
                          select el;

                this.appendtree(els, this.tvdom.Nodes, null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "加載出錯");
            }
        }

        /// <summary>
        /// 把XML節點的顯示在TreeView上
        /// 如果XML節點沒有子節點則顯示XML節點的Value值
        /// </summary>
        private void appendtree(IEnumerable<XElement> els, TreeNodeCollection tnc, XElement tnel)
        {
            tnc.Clear();
            if (els.Count<XElement>() == 0 && tnel != null)
            {
                tnc.Add(new TreeNode(tnel.Value));
                return;
            }
            foreach (var el in els)
            {
                TreeNode tn = new TreeNode(el.Name.LocalName, new TreeNode[] { new TreeNode(string.Empty) });
                tn.Tag = el;
                tnc.Add(tn);
            }
        }

    }
}
