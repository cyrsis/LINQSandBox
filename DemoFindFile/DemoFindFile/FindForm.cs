using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoFindFile
{
    public partial class FindForm : Form
    {
        /// <summary>
        /// 控制器
        /// </summary>
        private FindFileController ffc;

        private string oldfrmtext;
        private delegate void updatefrmdelgage();
        private delegate void updatefrmdelgage2(Exception e);


        public FindForm()
        {
            InitializeComponent();
            this.oldfrmtext = this.Text;
            //初始化控制器
            this.ffc = new FindFileController();
        }

        /// <summary>
        /// 選擇檔案夾按鈕Click事件處理
        /// </summary>
        private void seldir_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtfolder.Text = this.folderBrowserDialog.SelectedPath;
                this.LoadFile();
            }
        }

        /// <summary>
        /// 尋找檔案框TextChanged事件處理
        /// </summary>
        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            if (this.txtfind.Text.Length > 0)
            {
                this.FilesBoxDataBind(this.ffc.FindFile(this.txtfind.Text));
            }
            else
            {
                //恢復ListBox的資料綁定
                this.filetypelst_SelectedIndexChanged(sender, e);
            }
        }

        /// <summary>
        /// 檔案夾路徑KeyDown事件處理
        /// </summary>
        private void txtfolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadFile();
        }

        /// <summary>
        /// 檔案 ListBox 綁定資料源
        /// </summary>
        private void FilesBoxDataBind(string[] files)
        {
            if (files == null)
                return;

            this.filelst.DataSource = files;
            this.labfncount.Text = string.Format("檔案數：{0}/{1}", files.Count(), this.ffc.Files.Count());
        }

        /// <summary>
        /// 檔案類型 ListBox 綁定資料源
        /// </summary>
        private void FileTypeBoxDataBind()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new updatefrmdelgage(FileTypeBoxDataBind));
                return;
            }

            string[] types = this.ffc.FileTypes();

            if (types == null)
                return;

            this.filetypelst.DataSource = types;

            if (this.filetypelst.Items.Count > 0)
                this.filetypelst.SelectedIndex = 0;

            this.labtypecount.Text = string.Format("{0}種類型", types.Length);
        }
        
        /// <summary>
        /// 更新介面資訊
        /// </summary>
        private void showinfo(Exception e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new updatefrmdelgage2(showinfo), new object[] { e });
                return;
            }

            if (e != null)
            {
                MessageBox.Show(e.Message, "加載檔案出錯，操作被取消", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Text = this.oldfrmtext;
            }
        }

        /// <summary>
        /// 尋找分組中的檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filetypelst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.filetypelst.SelectedItem == null)
                return;

            this.FilesBoxDataBind(this.ffc.GetFilesByType(this.filetypelst.SelectedItem.ToString()));
        }

        /// <summary>
        /// 開始讀取檔案線程
        /// </summary>
        private void LoadFile()
        {
            this.Text = string.Format("{0} - 正在讀取檔案夾內容...", this.oldfrmtext);
            System.Threading.Thread th = new System.Threading.Thread(new System.Threading.ThreadStart(loadfile));
            th.IsBackground = true;
            th.Start();
        }

        /// <summary>
        /// 線程中讀取檔案
        /// </summary>
        private void loadfile()
        {
            try
            {
                this.ffc.Path = this.txtfolder.Text;
                this.FileTypeBoxDataBind();
            }
            catch (Exception e)
            {
                showinfo(e);
            }

            showinfo(null);
        }
    }
}
