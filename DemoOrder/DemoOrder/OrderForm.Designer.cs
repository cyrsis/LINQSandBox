namespace DemoOrder
{
    partial class OrderForm
    {
        /// <summary>
        /// 必需的設計器變量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放托管資源，為 true；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗體設計器生成的程式碼

        /// <summary>
        /// 設計器支援所需的方法 - 不要
        /// 使用程式碼編輯器修改此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guests = new System.Windows.Forms.DataGridView();
            this.gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telphoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plst = new System.Windows.Forms.DataGridView();
            this.tabAddressBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter = new System.Windows.Forms.Splitter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tTxtBoxsec = new System.Windows.Forms.ToolStripTextBox();
            this.infopanel = new System.Windows.Forms.Panel();
            this.labprcount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labamcount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.guests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plst)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.infopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guests
            // 
            this.guests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gname,
            this.duty,
            this.sex,
            this.age,
            this.address,
            this.company,
            this.telphoneNumber,
            this.mainid});
            this.guests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guests.Location = new System.Drawing.Point(0, 25);
            this.guests.MultiSelect = false;
            this.guests.Name = "guests";
            this.guests.RowTemplate.Height = 23;
            this.guests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guests.Size = new System.Drawing.Size(535, 144);
            this.guests.TabIndex = 1;
            this.guests.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.guests_RowEnter);
            this.guests.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.guests_RowsAdded);
            this.guests.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guests_KeyDown);
            this.guests.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.guests_RowsRemoved);
            // 
            // gname
            // 
            this.gname.DataPropertyName = "Name";
            this.gname.HeaderText = "姓名";
            this.gname.Name = "gname";
            // 
            // duty
            // 
            this.duty.DataPropertyName = "Duty";
            this.duty.HeaderText = "職務";
            this.duty.Name = "duty";
            // 
            // sex
            // 
            this.sex.DataPropertyName = "Sex";
            dataGridViewCellStyle1.NullValue = null;
            this.sex.DefaultCellStyle = dataGridViewCellStyle1;
            this.sex.HeaderText = "性別";
            this.sex.Name = "sex";
            // 
            // age
            // 
            this.age.DataPropertyName = "Age";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.age.DefaultCellStyle = dataGridViewCellStyle2;
            this.age.HeaderText = "年齡";
            this.age.Name = "age";
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            // 
            // company
            // 
            this.company.DataPropertyName = "Company";
            this.company.HeaderText = "單位";
            this.company.Name = "company";
            // 
            // telphoneNumber
            // 
            this.telphoneNumber.DataPropertyName = "TelphoneNumber";
            this.telphoneNumber.HeaderText = "電話";
            this.telphoneNumber.Name = "telphoneNumber";
            // 
            // mainid
            // 
            this.mainid.DataPropertyName = "MainID";
            this.mainid.HeaderText = "ID";
            this.mainid.Name = "mainid";
            this.mainid.Visible = false;
            // 
            // plst
            // 
            this.plst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabAddressBook,
            this.id,
            this.addressBookID,
            this.product,
            this.price,
            this.amount,
            this.unit,
            this.pdate});
            this.plst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plst.Location = new System.Drawing.Point(0, 172);
            this.plst.Name = "plst";
            this.plst.RowTemplate.Height = 23;
            this.plst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plst.Size = new System.Drawing.Size(535, 150);
            this.plst.TabIndex = 3;
            // 
            // tabAddressBook
            // 
            this.tabAddressBook.DataPropertyName = "TabAddressBook";
            this.tabAddressBook.HeaderText = "TabAddressBook";
            this.tabAddressBook.Name = "tabAddressBook";
            this.tabAddressBook.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // addressBookID
            // 
            this.addressBookID.DataPropertyName = "AddressBookID";
            this.addressBookID.HeaderText = "AddressBookID";
            this.addressBookID.Name = "addressBookID";
            this.addressBookID.Visible = false;
            // 
            // product
            // 
            this.product.DataPropertyName = "Product";
            this.product.HeaderText = "產品";
            this.product.Name = "product";
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.HeaderText = "單價";
            this.price.Name = "price";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.amount.HeaderText = "數量";
            this.amount.Name = "amount";
            // 
            // unit
            // 
            this.unit.DataPropertyName = "Unit";
            this.unit.HeaderText = "單位";
            this.unit.Name = "unit";
            // 
            // pdate
            // 
            this.pdate.DataPropertyName = "Date";
            dataGridViewCellStyle5.Format = "F";
            dataGridViewCellStyle5.NullValue = null;
            this.pdate.DefaultCellStyle = dataGridViewCellStyle5;
            this.pdate.HeaderText = "日期";
            this.pdate.Name = "pdate";
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter.Location = new System.Drawing.Point(0, 169);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(535, 3);
            this.splitter.TabIndex = 2;
            this.splitter.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tTxtBoxsec});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(535, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton1.Text = "儲存";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton4.Text = "更新";
            this.toolStripButton4.ToolTipText = "重新從資料庫讀取資料";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton2.Text = "匯出訂單";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton3.Text = "匯入訂單";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "查詢使用者：";
            // 
            // tTxtBoxsec
            // 
            this.tTxtBoxsec.Name = "tTxtBoxsec";
            this.tTxtBoxsec.Size = new System.Drawing.Size(200, 25);
            this.tTxtBoxsec.ToolTipText = "輸入查詢關鍵字";
            this.tTxtBoxsec.TextChanged += new System.EventHandler(this.tTxtBoxsec_TextChanged);
            // 
            // infopanel
            // 
            this.infopanel.Controls.Add(this.labprcount);
            this.infopanel.Controls.Add(this.label3);
            this.infopanel.Controls.Add(this.labamcount);
            this.infopanel.Controls.Add(this.label1);
            this.infopanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infopanel.Location = new System.Drawing.Point(0, 322);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(535, 32);
            this.infopanel.TabIndex = 6;
            // 
            // labprcount
            // 
            this.labprcount.AutoSize = true;
            this.labprcount.Location = new System.Drawing.Point(281, 11);
            this.labprcount.Name = "labprcount";
            this.labprcount.Size = new System.Drawing.Size(0, 12);
            this.labprcount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "金額合計：";
            // 
            // labamcount
            // 
            this.labamcount.AutoSize = true;
            this.labamcount.Location = new System.Drawing.Point(83, 11);
            this.labamcount.Name = "labamcount";
            this.labamcount.Size = new System.Drawing.Size(0, 12);
            this.labamcount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "數量合計：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "(XML格式的訂單檔案 *.XML)|*.xml";
            this.openFileDialog1.Title = "選擇需要匯入的訂單";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "(XML格式的訂單檔案 *.XML)|*.xml";
            this.saveFileDialog1.Title = "選擇匯出的檔案名";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 354);
            this.Controls.Add(this.guests);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.plst);
            this.Controls.Add(this.infopanel);
            this.Name = "OrderForm";
            this.Text = "訂單管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.guests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plst)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView guests;
        private System.Windows.Forms.DataGridView plst;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn duty;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn telphoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabAddressBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdate;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.Label labamcount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labprcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tTxtBoxsec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;

    }
}

