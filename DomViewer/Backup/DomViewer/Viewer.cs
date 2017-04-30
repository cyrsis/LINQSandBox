using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DomViewer
{

    /// <summary>
    /// RSS DOM �˵���
    /// </summary>
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ������s�ƥ�B�z
        /// </summary>
        private void butget_Click(object sender, EventArgs e)
        {
            this.getrss();
        }

        /// <summary>
        /// �a�}��J�بƥ�B�z
        /// </summary>
        private void txturl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.getrss();
        }

        /// <summary>
        /// �B�zTreeView�i�}�ƥ�
        /// </summary>
        private void tvdom_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                XElement tnel = e.Node.Tag as XElement;
                if (tnel != null)
                {
                    // �ھ�TreeView�`�I�W�x�s��XML�`�I��LINQ�d�ߨ�l�`�I
                    var els = from el in tnel.Elements()
                              select el;

                    this.appendtree(els, e.Node.Nodes, tnel);
                }
            }
        }

        /// <summary>
        /// �B�zTreeView�ƥ�A��ܸ`�I�ߧY�i�}
        /// </summary>
        private void tvdom_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.Expand();
        }

        /// <summary>
        /// ��RSS�ɮר��ഫ��XML���å[����TreeView����
        /// </summary>
        private void getrss()
        {
            try
            {
                //�q���}�[��Rss�ɮ�
                XElement doc = XElement.Load(this.txturl.Text, LoadOptions.None);

                //��LINQ�˯������l�`�I
                var els = from el in doc.Elements()
                          select el;

                this.appendtree(els, this.tvdom.Nodes, null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "�[���X��");
            }
        }

        /// <summary>
        /// ��XML�`�I����ܦbTreeView�W
        /// �p�GXML�`�I�S���l�`�I�h���XML�`�I��Value��
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
