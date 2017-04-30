using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DemoLog
{
    /// <summary>
    /// 用於日誌輸出的TextWriter物件
    /// </summary>
    public class LogTextWriter : TextWriter
    {
        private TextBox logbox;

        public LogTextWriter(TextBox box)
        {
            this.logbox = box;
            this.CoreNewLine = new char[] { '\r', '\n' };
        }

        public override void WriteLine(string value)
        {
            this.logbox.AppendText(value);
            this.logbox.AppendText(this.NewLine);
            if (value.IndexOf("SqlProvider") > -1)
            {
                this.logbox.AppendText(new string('*', 80));
                this.logbox.AppendText(this.NewLine);
            }
            this.logbox.ScrollToCaret();
        }

        private Encoding encoding = Encoding.UTF8;
        public override Encoding Encoding
        {
            get { return encoding; }
        }
    }
}
