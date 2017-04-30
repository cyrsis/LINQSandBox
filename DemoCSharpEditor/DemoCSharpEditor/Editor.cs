using System;
using System.Windows.Forms;

namespace DemoCSharpEditor
{
    public partial class Editor : Form
    {
        /// <summary>
        /// 控制器
        /// </summary>
        private EditorController ec;

        public Editor()
        {
            InitializeComponent();
            //初始化控制器
            ec = new EditorController(this.richt,this.txtlog);
        }

        private void 运行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ec.Compile();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
