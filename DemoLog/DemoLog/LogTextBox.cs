using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DemoLog
{
    /// <summary>
    /// 日誌顯示控件
    /// </summary>
    public class LogTextBox : TextBox
    {
        public LogTextBox()
        {
            this.ReadOnly = true;
            this.BackColor = Color.White;
            this.ForeColor = Color.Blue;
            this.Multiline = true;
            this.WordWrap = true;
            this.ScrollBars = ScrollBars.Vertical;
            this.outshow = new LogTextWriter(this);
            this.Dock = DockStyle.Fill;
        }

        private LogTextWriter outshow;
        public TextWriter Out
        {
            get
            {
                return outshow;
            }
        }

    }
}
