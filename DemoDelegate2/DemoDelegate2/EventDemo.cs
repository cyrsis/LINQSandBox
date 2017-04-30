using System;
using System.Windows.Forms;
using System.Threading;

namespace DemoDelegate2
{
    public partial class EventDemo : Form
    {
        /// <summary>
        /// �w�q�ƥ�
        /// </summary>
        public event EventHandler<MyEnentArgs> Half;

        /// <summary>
        /// �w�q�@�ӥΩ��s�������e�U
        /// </summary>
        /// <param name="?"></param>
        private delegate void UpdateCtlDelegate(int data, bool evt, bool over);

        public EventDemo()
        {
            InitializeComponent();

            //�����ƥ�B�z���
            this.Half += new EventHandler<MyEnentArgs>(EventDemo_Half);
        }

        /// <summary>
        /// �۩w�q�ƥ�B�z���
        /// </summary>
        void EventDemo_Half(object sender, MyEnentArgs e)
        {
            MessageBox.Show(string.Format("�ѼƸ��:{0}", e.Number), "�ƥ󦨥\�Q�޵o");
        }

        /// <summary>
        /// �}�l���sClick�ƥ�B�z
        /// </summary>
        private void but_Click(object sender, EventArgs e)
        {
            this.but.Enabled = false;
            //�Ұʤu�@�u�{
            Thread th = new Thread(new ThreadStart(progress));
            th.IsBackground = true;
            th.Start();
        }

        /// <summary>
        /// ������s�Ψƥ�޵o
        /// </summary>
        private void update(int data, bool evt, bool over)
        {
            //�˴��O�_�ݭn��^�����u�{
            if (this.InvokeRequired)
            {
                //�z�L�e�U��^�����u�{
                this.BeginInvoke(new UpdateCtlDelegate(update), new object[] { data, evt, over });
                return;
            }

            //�`�������ק�Button���
            if (over)
            {
                this.but.Enabled = true;
                return;
            }

            if (evt)
            {
                //�޵o�ƥ�
                this.Half(this, new MyEnentArgs(data));
            }
            else
            {
                //��s�i�ױ�
                this.progressBar.Value = data;
            }
        }

        /// <summary>
        /// �u�@�u�{�B�z��k
        /// </summary>
        private void progress()
        {
            for (int i = 0; i < 100; i++)
            {
                this.update(i, false, false);

                if (i == 50)
                {
                    if (this.Half != null)
                        this.update(i, true, false);
                }

                //����
                System.Threading.Thread.Sleep(10);
            }

            this.update(0, false, true);
        }
    }
}
