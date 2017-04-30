using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoFindFile
{
    public partial class FindForm : Form
    {
        /// <summary>
        /// ���
        /// </summary>
        private FindFileController ffc;

        private string oldfrmtext;
        private delegate void updatefrmdelgage();
        private delegate void updatefrmdelgage2(Exception e);


        public FindForm()
        {
            InitializeComponent();
            this.oldfrmtext = this.Text;
            //��l�Ʊ��
            this.ffc = new FindFileController();
        }

        /// <summary>
        /// ����ɮק����sClick�ƥ�B�z
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
        /// �M���ɮ׮�TextChanged�ƥ�B�z
        /// </summary>
        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            if (this.txtfind.Text.Length > 0)
            {
                this.FilesBoxDataBind(this.ffc.FindFile(this.txtfind.Text));
            }
            else
            {
                //��_ListBox����Ƹj�w
                this.filetypelst_SelectedIndexChanged(sender, e);
            }
        }

        /// <summary>
        /// �ɮק����|KeyDown�ƥ�B�z
        /// </summary>
        private void txtfolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadFile();
        }

        /// <summary>
        /// �ɮ� ListBox �j�w��Ʒ�
        /// </summary>
        private void FilesBoxDataBind(string[] files)
        {
            if (files == null)
                return;

            this.filelst.DataSource = files;
            this.labfncount.Text = string.Format("�ɮ׼ơG{0}/{1}", files.Count(), this.ffc.Files.Count());
        }

        /// <summary>
        /// �ɮ����� ListBox �j�w��Ʒ�
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

            this.labtypecount.Text = string.Format("{0}������", types.Length);
        }
        
        /// <summary>
        /// ��s������T
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
                MessageBox.Show(e.Message, "�[���ɮץX���A�ާ@�Q����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Text = this.oldfrmtext;
            }
        }

        /// <summary>
        /// �M����դ����ɮ�
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
        /// �}�lŪ���ɮ׽u�{
        /// </summary>
        private void LoadFile()
        {
            this.Text = string.Format("{0} - ���bŪ���ɮק����e...", this.oldfrmtext);
            System.Threading.Thread th = new System.Threading.Thread(new System.Threading.ThreadStart(loadfile));
            th.IsBackground = true;
            th.Start();
        }

        /// <summary>
        /// �u�{��Ū���ɮ�
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
