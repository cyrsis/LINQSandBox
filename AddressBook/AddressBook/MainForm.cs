using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 定义并初始化控制器
        /// </summary>
        private AddressBookController abctl = new AddressBookController();

        /// <summary>
        /// 窗体状态枚举
        /// </summary>
        private enum FormStatus { Show, Modition, New, NoData, LoadError };

        /// <summary>
        /// 定义并初始化窗体状态
        /// </summary>
        private FormStatus fs = FormStatus.Show;

        /// <summary>
        /// 暂存正在操作的数据
        /// </summary>
        private TabAddressBook nowItem = null;

        public MainForm()
        {
            InitializeComponent();
            bind();
        }

        /// <summary>
        /// 重新绑定ListBox
        /// </summary>
        private void rebindlstbox()
        {
            this.rebindlstbox(abctl.BookBindingList);
        }
        private void rebindlstbox(object datasource)
        {
            this.addlst.DataSource = null;
            this.addlst.DataSource = datasource;
            this.addlst.DisplayMember = "ab_name";
        }

        /// <summary>
        /// 控件数据绑定
        /// </summary>
        private void bindctl(object datasource)
        {
            this.txtage.DataBindings.Clear();
            this.txtage.DataBindings.Add(new Binding("Text", datasource, "ab_age", true));
            this.txtname.DataBindings.Clear();
            this.txtname.DataBindings.Add(new Binding("Text", datasource, "ab_name"));
            this.txtadd.DataBindings.Clear();
            this.txtadd.DataBindings.Add(new Binding("Text", datasource, "ab_add"));
            this.txtcom.DataBindings.Clear();
            this.txtcom.DataBindings.Add(new Binding("Text", datasource, "ab_com"));
            this.txtdub.DataBindings.Clear();
            this.txtdub.DataBindings.Add(new Binding("Text", datasource, "ab_dub"));
            this.txttel.DataBindings.Clear();
            this.txttel.DataBindings.Add(new Binding("Text", datasource, "ab_tel"));
            this.cbsex.DataBindings.Clear();
            this.cbsex.DataBindings.Add(new Binding("Text", datasource, "ab_sex"));
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void bind()
        {
            //数据绑定到控件
            this.rebindlstbox();
            this.bindctl(abctl.BookBindingList);

            if (abctl.BookBindingList.Count == 0)
                this.fs = FormStatus.NoData;

            this.swControls();
        }

        /// <summary>
        /// 根据状态修改控件显示
        /// </summary>
        private void swControls()
        {
            this.SuspendLayout();
            switch (this.fs)
            {
                case FormStatus.Show:
                    this.edCtl(false);
                    this.addlst.Enabled = true;
                    this.txtsec.ReadOnly = false;
                    this.butdel.Enabled = true;
                    this.butnew.Enabled = true;
                    this.butnew.Text = "新建";
                    this.butsave.Enabled = true;
                    break;

                case FormStatus.Modition:
                case FormStatus.New:
                    this.edCtl(true);
                    this.butdel.Enabled = false;
                    this.butnew.Enabled = true;
                    this.butnew.Text = "放弃";
                    this.addlst.Enabled = false;
                    this.txtsec.ReadOnly = true;
                    break;

                case FormStatus.NoData:
                    this.edCtl(false);
                    this.butnew.Enabled = true;
                    break;

                case FormStatus.LoadError:
                    this.edCtl(false);
                    break;
            }

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        /// <summary>
        /// 控制控件Enabled状态
        /// </summary>
        /// <param name="op"></param>
        private void edCtl(bool op)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctl).ReadOnly = !op;
                }
                else if (ctl.GetType() != typeof(Label))
                {
                    ctl.Enabled = op;
                }
            }
        }

        /// <summary>
        ///  新建、放弃按钮事件处理
        /// </summary>
        private void butnew_Click(object sender, EventArgs e)
        {
            if (this.fs == FormStatus.Show)
            {
                //新建处理
                this.fs = FormStatus.New;
                TabAddressBook tb = new TabAddressBook() { ab_name = "新建用户", ab_sex = "女" };
                this.nowItem = tb;
                this.abctl.New(tb);
                this.BindingContext[this.abctl.BookBindingList].Position = this.abctl.BookBindingList.Count;

            }
            else
            {
                //放弃处理
                if (this.fs == FormStatus.New)
                {
                    this.abctl.Delete(this.nowItem);
                    this.BindingContext[this.abctl.BookBindingList].Position = this.abctl.BookBindingList.Count;
                }

                this.fs = FormStatus.Show;
            }

            //重新绑定数据
            this.bind();

            this.txtname.Focus();
        }

        /// <summary>
        /// 修改、保存按钮事件处理
        /// </summary>
        private void butsave_Click(object sender, EventArgs e)
        {
            if (this.fs == FormStatus.Show)
            {
                if (this.addlst.SelectedItem != null)
                {
                    //修改处理
                    this.nowItem = this.addlst.SelectedItem as TabAddressBook;
                    this.fs = FormStatus.Modition;
                }
            }
            else
            {
                //保存处理
                //转到控制器中使用LINQ to SQL 保存修改到数据库
                this.abctl.Update(this.nowItem);

                this.fs = FormStatus.Show;
            }

            //控制控件状态
            this.swControls();
            this.txtname.Focus();
        }

        /// <summary>
        /// 删除按钮事件处理
        /// </summary>
        private void butdel_Click(object sender, EventArgs e)
        {
            //转到控制器中使用LINQ to SQL 从数据库删除
            if (this.addlst.SelectedItem != null)
            {
                this.abctl.Delete((TabAddressBook)this.addlst.SelectedItem);
                this.bind();
            }
        }

        /// <summary>
        /// 搜索框事件处理
        /// </summary>
        private void txtsec_TextChanged(object sender, EventArgs e)
        {
            if (this.fs == FormStatus.Show)
            {
                if (this.abctl.BookBindingList.Count > 0)
                {
                    if (this.txtsec.Text.Length > 0)
                    {
                        //转到控制器中使用LINQ搜索
                        IEnumerable<TabAddressBook> book = this.abctl.Search(this.txtsec.Text);

                        //将查询结果绑定到控件
                        this.rebindlstbox(book);
                        this.bindctl(book);
                    }
                    else
                    {
                        //恢复ListBox的数据绑定
                        this.bind();
                    }
                }
            }
        }

        private void labsec_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
