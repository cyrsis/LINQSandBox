namespace CommodityManagement.Console
{
    partial class ConsoleView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cashPage = new System.Windows.Forms.TabPage();
            this.accountPage = new System.Windows.Forms.TabPage();
            this.acclst = new System.Windows.Forms.DataGridView();
            this.raname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolseldate = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.commPage = new System.Windows.Forms.TabPage();
            this.comlst = new System.Windows.Forms.DataGridView();
            this.cmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmiprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.tb = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.accountPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acclst)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.commPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comlst)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.tb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cashPage);
            this.tabControl1.Controls.Add(this.accountPage);
            this.tabControl1.Controls.Add(this.commPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // cashPage
            // 
            this.cashPage.Location = new System.Drawing.Point(4, 21);
            this.cashPage.Name = "cashPage";
            this.cashPage.Padding = new System.Windows.Forms.Padding(3);
            this.cashPage.Size = new System.Drawing.Size(669, 345);
            this.cashPage.TabIndex = 0;
            this.cashPage.Text = "收银台";
            this.cashPage.UseVisualStyleBackColor = true;
            // 
            // accountPage
            // 
            this.accountPage.Controls.Add(this.acclst);
            this.accountPage.Controls.Add(this.toolStrip1);
            this.accountPage.Location = new System.Drawing.Point(4, 21);
            this.accountPage.Name = "accountPage";
            this.accountPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountPage.Size = new System.Drawing.Size(562, 319);
            this.accountPage.TabIndex = 1;
            this.accountPage.Text = "流水帐";
            this.accountPage.UseVisualStyleBackColor = true;
            // 
            // acclst
            // 
            this.acclst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acclst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raname,
            this.rabarcode,
            this.rapr,
            this.raamount,
            this.radate});
            this.acclst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acclst.Location = new System.Drawing.Point(3, 28);
            this.acclst.Name = "acclst";
            this.acclst.RowTemplate.Height = 23;
            this.acclst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.acclst.Size = new System.Drawing.Size(556, 288);
            this.acclst.TabIndex = 0;
            // 
            // raname
            // 
            this.raname.DataPropertyName = "Name";
            this.raname.HeaderText = "名称";
            this.raname.Name = "raname";
            // 
            // rabarcode
            // 
            this.rabarcode.DataPropertyName = "Barcode";
            this.rabarcode.HeaderText = "条码";
            this.rabarcode.Name = "rabarcode";
            // 
            // rapr
            // 
            this.rapr.DataPropertyName = "Price";
            this.rapr.HeaderText = "单价";
            this.rapr.Name = "rapr";
            // 
            // raamount
            // 
            this.raamount.DataPropertyName = "Amount";
            this.raamount.HeaderText = "数量";
            this.raamount.Name = "raamount";
            // 
            // radate
            // 
            this.radate.DataPropertyName = "Date";
            this.radate.HeaderText = "日期";
            this.radate.Name = "radate";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolseldate,
            this.toolStripButton15,
            this.toolStripSeparator3,
            this.toolStripButton16});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton3.Text = "首页";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Enabled = false;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton4.Text = "前页";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton5.Text = "后页";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Enabled = false;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton6.Text = "末页";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
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
            this.toolStripLabel1.Text = "选择日期：";
            // 
            // toolseldate
            // 
            this.toolseldate.Name = "toolseldate";
            this.toolseldate.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton15.Text = "日期";
            this.toolStripButton15.ToolTipText = "按照选择的日期筛选";
            this.toolStripButton15.Click += new System.EventHandler(this.toolStripButton15_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton16.Text = "全部";
            this.toolStripButton16.ToolTipText = "全部记录分页显示";
            this.toolStripButton16.Click += new System.EventHandler(this.toolStripButton16_Click);
            // 
            // commPage
            // 
            this.commPage.Controls.Add(this.comlst);
            this.commPage.Controls.Add(this.toolStrip3);
            this.commPage.Location = new System.Drawing.Point(4, 21);
            this.commPage.Name = "commPage";
            this.commPage.Padding = new System.Windows.Forms.Padding(3);
            this.commPage.Size = new System.Drawing.Size(562, 319);
            this.commPage.TabIndex = 2;
            this.commPage.Text = "库存商品";
            this.commPage.UseVisualStyleBackColor = true;
            // 
            // comlst
            // 
            this.comlst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comlst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmname,
            this.cmbarcode,
            this.cmamount,
            this.cmuint,
            this.cmprice,
            this.cmiprice,
            this.cmdate});
            this.comlst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comlst.Location = new System.Drawing.Point(3, 28);
            this.comlst.Name = "comlst";
            this.comlst.RowTemplate.Height = 23;
            this.comlst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.comlst.Size = new System.Drawing.Size(556, 288);
            this.comlst.TabIndex = 0;
            // 
            // cmname
            // 
            this.cmname.DataPropertyName = "Name";
            this.cmname.HeaderText = "名称";
            this.cmname.Name = "cmname";
            // 
            // cmbarcode
            // 
            this.cmbarcode.DataPropertyName = "Barcode";
            this.cmbarcode.HeaderText = "条码";
            this.cmbarcode.Name = "cmbarcode";
            // 
            // cmamount
            // 
            this.cmamount.DataPropertyName = "Amount";
            this.cmamount.HeaderText = "进货数量";
            this.cmamount.Name = "cmamount";
            // 
            // cmuint
            // 
            this.cmuint.DataPropertyName = "Unit";
            this.cmuint.HeaderText = "单位";
            this.cmuint.Name = "cmuint";
            // 
            // cmprice
            // 
            this.cmprice.DataPropertyName = "Price";
            this.cmprice.HeaderText = "零售价";
            this.cmprice.Name = "cmprice";
            // 
            // cmiprice
            // 
            this.cmiprice.DataPropertyName = "ImportPrice";
            this.cmiprice.HeaderText = "进货价";
            this.cmiprice.Name = "cmiprice";
            // 
            // cmdate
            // 
            this.cmdate.DataPropertyName = "Date";
            this.cmdate.HeaderText = "进货日期";
            this.cmdate.Name = "cmdate";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripButton11,
            this.toolStripButton14});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(556, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton12.Enabled = false;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton12.Text = "首页";
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton13.Enabled = false;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton13.Text = "前页";
            this.toolStripButton13.Click += new System.EventHandler(this.toolStripButton13_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton11.Enabled = false;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton11.Text = "后页";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton14.Enabled = false;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton14.Text = "末页";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // tb
            // 
            this.tb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.tb.Location = new System.Drawing.Point(0, 0);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(677, 25);
            this.tb.TabIndex = 1;
            this.tb.Text = "保存";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton1.Text = "保存";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton2.Text = "刷新";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton7.Text = "首页";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton8.Text = "前页";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton9.Text = "后页";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton10.Text = "末页";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(235, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(120, 21);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Visible = false;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 395);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb);
            this.Name = "ConsoleView";
            this.Text = "商品管理 - 控制台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsoleView_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.accountPage.ResumeLayout(false);
            this.accountPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acclst)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.commPage.ResumeLayout(false);
            this.commPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comlst)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tb.ResumeLayout(false);
            this.tb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cashPage;
        private System.Windows.Forms.TabPage accountPage;
        private System.Windows.Forms.TabPage commPage;
        private System.Windows.Forms.DataGridView acclst;
        private System.Windows.Forms.ToolStrip tb;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView comlst;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolseldate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn raname;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn rapr;
        private System.Windows.Forms.DataGridViewTextBoxColumn raamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn radate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmuint;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmiprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdate;


    }
}

