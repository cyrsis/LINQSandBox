using System;
using System.Linq;
using System.Windows.Forms;
using DemoEntity;

namespace DemoLog
{
    public partial class LogShow : Form
    {
        private LogTextBox logshow = new LogTextBox();
        private AddressBookDataContext abcd = new AddressBookDataContext();

        public LogShow()
        {
            InitializeComponent();
            this.Controls.Add(this.logshow);
            this.logshow.BringToFront();

            abcd.Log = this.logshow.Out;
            this.getall();
        }

        private void secbut_Click(object sender, EventArgs e)
        {
            if (this.sectext.Text.Length > 0)
            {
                var query = from g in abcd.TabAddressBook
                            where g.Name.IndexOf(this.sectext.Text) > -1 ||
                            g.Sex.IndexOf(this.sectext.Text) > -1 ||
                            g.TelphoneNumber.IndexOf(this.sectext.Text) > -1 ||
                            g.Duty.IndexOf(this.sectext.Text) > -1 ||
                            g.Company.IndexOf(this.sectext.Text) > -1 ||
                            g.Age.ToString().IndexOf(this.sectext.Text) > -1 ||
                            g.Address.IndexOf(this.sectext.Text) > -1
                            select g;

                this.dataGridView.DataSource = query;
            }
            else
            {
                this.getall();
            }

        }

        /// <summary>
        /// 獲取全部記錄
        /// </summary>
        private void getall()
        {
            var query = from g in abcd.TabAddressBook
                        select g;

            this.dataGridView.DataSource = query;
        }
    }
}
