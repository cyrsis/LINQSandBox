using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace DemoOrder
{
    public partial class OrderForm : Form
    {
        /// <summary>
        /// 初始化控制器
        /// </summary>
        private OrderController ctl = new OrderController();

        public OrderForm()
        {
            InitializeComponent();
            this.guests.DataSource = this.ctl.Guests.GetNewBindingList();
        }

        /// <summary>
        /// 點擊客戶名單更新所屬訂單列表
        /// </summary>
        private void guests_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ProductListBind();
        }

        /// <summary>
        /// 從勾選的DataGridView行得到綁定的實體
        /// </summary>
        private TabAddressBookEntity GetSelectEntity()
        {
            if (this.guests.SelectedRows.Count > 0)
            {
                TabAddressBookEntity t = this.guests.SelectedRows[0].DataBoundItem as TabAddressBookEntity;
                return t;
            }

            return null;
        }

        /// <summary>
        /// 綁定訂單到DataGridView，並統計訂單
        /// </summary>
        private void ProductListBind()
        {
            if (this.guests.SelectedRows.Count > 0)
            {
                TabAddressBookEntity t = GetSelectEntity();

                if (t != null)
                {
                    this.plst.Enabled = true;

                    if (t.TabShoppingListEntity != null)
                    {
                        this.plst.DataSource = t.TabShoppingListEntity.GetNewBindingList();
                        CountArgs carg = OrderController.Count(t);
                        this.labamcount.Text = carg.AmountCount.ToString();
                        this.labprcount.Text = carg.Count.ToString("C");
                    }
                }
                else
                {
                    this.plst.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 搜索客戶表
        /// </summary>
        private void tTxtBoxsec_TextChanged(object sender, EventArgs e)
        {
            if (this.tTxtBoxsec.Text.Length > 0)
            {
                this.guests.DataSource = this.ctl.Search(tTxtBoxsec.Text);
            }
            else
            {
                this.guests.DataSource = this.ctl.Guests.GetNewBindingList();
            }

            if (this.guests.RowCount == 1)
            {
                this.plst.Enabled = false;
            }
            else
            {
                ProductListBind();
            }
        }

        private void guests_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ProductListBind();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.ctl.Save();
        }

        /// <summary>
        /// 匯出訂單
        /// </summary>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TabAddressBookEntity t = GetSelectEntity();
            if (t != null)
            {
                this.saveFileDialog1.FileName = string.Format("{0}.xml", t.Name);
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    OrderSerializer.Serializer(t, this.saveFileDialog1.FileName);
                }
            }
        }

        /// <summary>
        /// 匯入訂單
        /// </summary>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UnserializerResult result = this.ctl.Serializer.Unserializer(this.openFileDialog1.FileName);

                if (result != null)
                {
                    if (result.Entity != null)
                    {
                        if (result.IsNew)
                        {
                            this.guests.DataSource = this.ctl.Guests.GetNewBindingList();
                        }

                        TabAddressBookEntity t = result.Entity;
                        var query = from DataGridViewRow row in this.guests.Rows
                                    where row.DataBoundItem == null ? false : ((TabAddressBookEntity)row.DataBoundItem).MainID == t.MainID
                                    select row;

                        if (query.Count() == 1)
                        {
                            DataGridViewRow sel = query.First();
                            sel.Selected = true;
                            this.guests.FirstDisplayedScrollingRowIndex = sel.Index;
                        }

                        ProductListBind();
                    }
                }

            }
        }

        /// <summary>
        /// 退出時刻檢測是否需要儲存資料
        /// </summary>
        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeSet chg = this.ctl.GetChangeSet();
            if (chg.Deletes.Count > 0 || chg.Inserts.Count > 0 || chg.Updates.Count > 0)
            {
                if (MessageBox.Show("檢測到資料已經改變，是否儲存到資料庫？", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    this.ctl.Save();

            }
        }

        /// <summary>
        /// 更新並重新綁定
        /// </summary>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.ctl.Refresh();
            this.guests.DataSource = this.ctl.Guests.GetNewBindingList();
            ProductListBind();
        }

        /// <summary>
        /// 刪除客戶資料時刻刪除所屬的訂單
        /// </summary>
        private void guests_KeyDown(object sender, KeyEventArgs e)
        {
            //行刪除前刪除訂單
            if (e.KeyCode == Keys.Delete)
            {
                TabAddressBookEntity t = this.GetSelectEntity();

                if (t != null)
                {
                    t.TabShoppingListEntity.Clear();
                }
            }
        }

        private void guests_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int index = e.RowIndex - 1;

            if (index < 0)
                index = 0;

            if (index < this.guests.Rows.Count)
                this.guests.Rows[index].Selected = true;

            ProductListBind();
        }


    }
}
