using System;
using System.Windows.Forms;
using System.Threading;

namespace DemoDelegate2
{
    public partial class EventDemo : Form
    {
        /// <summary>
        /// 定義事件
        /// </summary>
        public event EventHandler<MyEnentArgs> Half;

        /// <summary>
        /// 定義一個用於更新介面的委託
        /// </summary>
        /// <param name="?"></param>
        private delegate void UpdateCtlDelegate(int data, bool evt, bool over);

        public EventDemo()
        {
            InitializeComponent();

            //掛載事件處理函數
            this.Half += new EventHandler<MyEnentArgs>(EventDemo_Half);
        }

        /// <summary>
        /// 自定義事件處理函數
        /// </summary>
        void EventDemo_Half(object sender, MyEnentArgs e)
        {
            MessageBox.Show(string.Format("參數資料:{0}", e.Number), "事件成功被引發");
        }

        /// <summary>
        /// 開始按鈕Click事件處理
        /// </summary>
        private void but_Click(object sender, EventArgs e)
        {
            this.but.Enabled = false;
            //啟動工作線程
            Thread th = new Thread(new ThreadStart(progress));
            th.IsBackground = true;
            th.Start();
        }

        /// <summary>
        /// 介面更新及事件引發
        /// </summary>
        private void update(int data, bool evt, bool over)
        {
            //檢測是否需要返回介面線程
            if (this.InvokeRequired)
            {
                //透過委託返回介面線程
                this.BeginInvoke(new UpdateCtlDelegate(update), new object[] { data, evt, over });
                return;
            }

            //循環結束修改Button顯示
            if (over)
            {
                this.but.Enabled = true;
                return;
            }

            if (evt)
            {
                //引發事件
                this.Half(this, new MyEnentArgs(data));
            }
            else
            {
                //更新進度條
                this.progressBar.Value = data;
            }
        }

        /// <summary>
        /// 工作線程處理方法
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

                //延時
                System.Threading.Thread.Sleep(10);
            }

            this.update(0, false, true);
        }
    }
}
