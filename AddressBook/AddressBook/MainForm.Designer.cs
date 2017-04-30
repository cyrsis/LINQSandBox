namespace AddressBook
{
    partial class MainForm
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
            this.addlst = new System.Windows.Forms.ListBox();
            this.txtsec = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.cbsex = new System.Windows.Forms.ComboBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.labname = new System.Windows.Forms.Label();
            this.labsex = new System.Windows.Forms.Label();
            this.labage = new System.Windows.Forms.Label();
            this.labadd = new System.Windows.Forms.Label();
            this.labcom = new System.Windows.Forms.Label();
            this.txtcom = new System.Windows.Forms.TextBox();
            this.labtel = new System.Windows.Forms.Label();
            this.labsec = new System.Windows.Forms.Label();
            this.butnew = new System.Windows.Forms.Button();
            this.butdel = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.labdub = new System.Windows.Forms.Label();
            this.txtdub = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addlst
            // 
            this.addlst.FormattingEnabled = true;
            this.addlst.ItemHeight = 12;
            this.addlst.Location = new System.Drawing.Point(23, 44);
            this.addlst.Name = "addlst";
            this.addlst.Size = new System.Drawing.Size(92, 304);
            this.addlst.TabIndex = 10;
            // 
            // txtsec
            // 
            this.txtsec.Location = new System.Drawing.Point(74, 12);
            this.txtsec.Name = "txtsec";
            this.txtsec.Size = new System.Drawing.Size(240, 22);
            this.txtsec.TabIndex = 0;
            this.txtsec.TextChanged += new System.EventHandler(this.txtsec_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(179, 40);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(135, 22);
            this.txtname.TabIndex = 1;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(134, 260);
            this.txttel.Multiline = true;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(182, 89);
            this.txttel.TabIndex = 7;
            // 
            // cbsex
            // 
            this.cbsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsex.FormattingEnabled = true;
            this.cbsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbsex.Location = new System.Drawing.Point(179, 101);
            this.cbsex.Name = "cbsex";
            this.cbsex.Size = new System.Drawing.Size(56, 20);
            this.cbsex.TabIndex = 3;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(179, 169);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(135, 22);
            this.txtadd.TabIndex = 5;
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(132, 44);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(41, 12);
            this.labname.TabIndex = 7;
            this.labname.Text = "姓名：";
            // 
            // labsex
            // 
            this.labsex.AutoSize = true;
            this.labsex.Location = new System.Drawing.Point(132, 105);
            this.labsex.Name = "labsex";
            this.labsex.Size = new System.Drawing.Size(41, 12);
            this.labsex.TabIndex = 8;
            this.labsex.Text = "性别：";
            // 
            // labage
            // 
            this.labage.AutoSize = true;
            this.labage.Location = new System.Drawing.Point(132, 139);
            this.labage.Name = "labage";
            this.labage.Size = new System.Drawing.Size(41, 12);
            this.labage.TabIndex = 9;
            this.labage.Text = "年齡：";
            // 
            // labadd
            // 
            this.labadd.AutoSize = true;
            this.labadd.Location = new System.Drawing.Point(132, 173);
            this.labadd.Name = "labadd";
            this.labadd.Size = new System.Drawing.Size(41, 12);
            this.labadd.TabIndex = 10;
            this.labadd.Text = "住址：";
            // 
            // labcom
            // 
            this.labcom.AutoSize = true;
            this.labcom.Location = new System.Drawing.Point(132, 207);
            this.labcom.Name = "labcom";
            this.labcom.Size = new System.Drawing.Size(41, 12);
            this.labcom.TabIndex = 12;
            this.labcom.Text = "單位：";
            // 
            // txtcom
            // 
            this.txtcom.Location = new System.Drawing.Point(179, 203);
            this.txtcom.Name = "txtcom";
            this.txtcom.Size = new System.Drawing.Size(135, 22);
            this.txtcom.TabIndex = 6;
            // 
            // labtel
            // 
            this.labtel.AutoSize = true;
            this.labtel.Location = new System.Drawing.Point(132, 241);
            this.labtel.Name = "labtel";
            this.labtel.Size = new System.Drawing.Size(41, 12);
            this.labtel.TabIndex = 13;
            this.labtel.Text = "電話：";
            // 
            // labsec
            // 
            this.labsec.AutoSize = true;
            this.labsec.Location = new System.Drawing.Point(27, 21);
            this.labsec.Name = "labsec";
            this.labsec.Size = new System.Drawing.Size(41, 12);
            this.labsec.TabIndex = 14;
            this.labsec.Text = "搜索：";
            this.labsec.Click += new System.EventHandler(this.labsec_Click);
            // 
            // butnew
            // 
            this.butnew.Location = new System.Drawing.Point(158, 372);
            this.butnew.Name = "butnew";
            this.butnew.Size = new System.Drawing.Size(75, 23);
            this.butnew.TabIndex = 8;
            this.butnew.Text = "新建";
            this.butnew.UseVisualStyleBackColor = true;
            this.butnew.Click += new System.EventHandler(this.butnew_Click);
            // 
            // butdel
            // 
            this.butdel.Location = new System.Drawing.Point(23, 372);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(75, 23);
            this.butdel.TabIndex = 11;
            this.butdel.Text = "刪除";
            this.butdel.UseVisualStyleBackColor = true;
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(239, 372);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(75, 23);
            this.butsave.TabIndex = 9;
            this.butsave.Text = "修改/保存";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // labdub
            // 
            this.labdub.AutoSize = true;
            this.labdub.Location = new System.Drawing.Point(132, 74);
            this.labdub.Name = "labdub";
            this.labdub.Size = new System.Drawing.Size(29, 12);
            this.labdub.TabIndex = 19;
            this.labdub.Text = "職務";
            // 
            // txtdub
            // 
            this.txtdub.Location = new System.Drawing.Point(179, 70);
            this.txtdub.Name = "txtdub";
            this.txtdub.Size = new System.Drawing.Size(135, 22);
            this.txtdub.TabIndex = 2;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(179, 136);
            this.txtage.MaxLength = 3;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(135, 22);
            this.txtage.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 407);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.labdub);
            this.Controls.Add(this.txtdub);
            this.Controls.Add(this.butsave);
            this.Controls.Add(this.butdel);
            this.Controls.Add(this.butnew);
            this.Controls.Add(this.labsec);
            this.Controls.Add(this.labtel);
            this.Controls.Add(this.labcom);
            this.Controls.Add(this.txtcom);
            this.Controls.Add(this.labadd);
            this.Controls.Add(this.labage);
            this.Controls.Add(this.labsex);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.cbsex);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtsec);
            this.Controls.Add(this.addlst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "電話簿";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox addlst;
        private System.Windows.Forms.TextBox txtsec;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.ComboBox cbsex;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labsex;
        private System.Windows.Forms.Label labage;
        private System.Windows.Forms.Label labadd;
        private System.Windows.Forms.Label labcom;
        private System.Windows.Forms.TextBox txtcom;
        private System.Windows.Forms.Label labtel;
        private System.Windows.Forms.Label labsec;
        private System.Windows.Forms.Button butnew;
        private System.Windows.Forms.Button butdel;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.Label labdub;
        private System.Windows.Forms.TextBox txtdub;
        private System.Windows.Forms.TextBox txtage;
    }
}

