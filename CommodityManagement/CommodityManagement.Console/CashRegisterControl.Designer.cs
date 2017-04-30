namespace CommodityManagement.Console
{
    partial class CashRegisterControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buylst = new System.Windows.Forms.DataGridView();
            this.RaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtchg = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.labchg = new System.Windows.Forms.Label();
            this.labtotal = new System.Windows.Forms.Label();
            this.txtsec = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.buylst)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buylst
            // 
            this.buylst.AllowUserToAddRows = false;
            this.buylst.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buylst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.buylst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buylst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RaName,
            this.raPri,
            this.raAmount,
            this.raBarcode});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.buylst.DefaultCellStyle = dataGridViewCellStyle4;
            this.buylst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buylst.Location = new System.Drawing.Point(0, 0);
            this.buylst.MultiSelect = false;
            this.buylst.Name = "buylst";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buylst.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.buylst.RowTemplate.Height = 23;
            this.buylst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buylst.Size = new System.Drawing.Size(665, 196);
            this.buylst.TabIndex = 0;
            this.buylst.TabStop = false;
            this.buylst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buylst_KeyDown);
            // 
            // RaName
            // 
            this.RaName.DataPropertyName = "Name";
            this.RaName.FillWeight = 300F;
            this.RaName.HeaderText = "名称";
            this.RaName.Name = "RaName";
            this.RaName.ReadOnly = true;
            this.RaName.Width = 300;
            // 
            // raPri
            // 
            this.raPri.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.raPri.DefaultCellStyle = dataGridViewCellStyle2;
            this.raPri.FillWeight = 200F;
            this.raPri.HeaderText = "价格";
            this.raPri.Name = "raPri";
            this.raPri.Width = 200;
            // 
            // raAmount
            // 
            this.raAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.raAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.raAmount.HeaderText = "数量";
            this.raAmount.Name = "raAmount";
            this.raAmount.Width = 160;
            // 
            // raBarcode
            // 
            this.raBarcode.DataPropertyName = "Barcode";
            this.raBarcode.HeaderText = "条码";
            this.raBarcode.Name = "raBarcode";
            this.raBarcode.ReadOnly = true;
            this.raBarcode.Width = 300;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtchg);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.txtcash);
            this.panel1.Controls.Add(this.labchg);
            this.panel1.Controls.Add(this.labtotal);
            this.panel1.Controls.Add(this.txtsec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 89);
            this.panel1.TabIndex = 0;
            // 
            // txtchg
            // 
            this.txtchg.AcceptsReturn = true;
            this.txtchg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtchg.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchg.Location = new System.Drawing.Point(328, 47);
            this.txtchg.Name = "txtchg";
            this.txtchg.ReadOnly = true;
            this.txtchg.Size = new System.Drawing.Size(163, 35);
            this.txtchg.TabIndex = 3;
            this.txtchg.Text = "0";
            // 
            // txttotal
            // 
            this.txttotal.AcceptsReturn = true;
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txttotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(72, 46);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(165, 35);
            this.txttotal.TabIndex = 6;
            this.txttotal.Text = "0";
            // 
            // txtcash
            // 
            this.txtcash.AcceptsReturn = true;
            this.txtcash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcash.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcash.Location = new System.Drawing.Point(497, 46);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(156, 35);
            this.txtcash.TabIndex = 1;
            this.txtcash.TextChanged += new System.EventHandler(this.txtcash_TextChanged);
            this.txtcash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcash_KeyDown);
            this.txtcash.Enter += new System.EventHandler(this.txtcash_Enter);
            // 
            // labchg
            // 
            this.labchg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labchg.AutoSize = true;
            this.labchg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labchg.Location = new System.Drawing.Point(253, 54);
            this.labchg.Name = "labchg";
            this.labchg.Size = new System.Drawing.Size(79, 24);
            this.labchg.TabIndex = 4;
            this.labchg.Text = "找零：";
            // 
            // labtotal
            // 
            this.labtotal.AutoSize = true;
            this.labtotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtotal.Location = new System.Drawing.Point(8, 54);
            this.labtotal.Name = "labtotal";
            this.labtotal.Size = new System.Drawing.Size(79, 24);
            this.labtotal.TabIndex = 2;
            this.labtotal.Text = "总价：";
            // 
            // txtsec
            // 
            this.txtsec.AcceptsReturn = true;
            this.txtsec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsec.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsec.Location = new System.Drawing.Point(12, 6);
            this.txtsec.Name = "txtsec";
            this.txtsec.Size = new System.Drawing.Size(641, 35);
            this.txtsec.TabIndex = 0;
            this.txtsec.VisibleChanged += new System.EventHandler(this.txtsec_VisibleChanged);
            this.txtsec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsec_KeyDown);
            // 
            // CashRegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buylst);
            this.Controls.Add(this.panel1);
            this.Name = "CashRegisterControl";
            this.Size = new System.Drawing.Size(665, 285);
            ((System.ComponentModel.ISupportInitialize)(this.buylst)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView buylst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsec;
        private System.Windows.Forms.Label labtotal;
        private System.Windows.Forms.TextBox txtchg;
        private System.Windows.Forms.Label labchg;
        private System.Windows.Forms.TextBox txtcash;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn raPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn raAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn raBarcode;
    }
}
