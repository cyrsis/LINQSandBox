namespace DemoLog
{
    partial class LogShow
    {
        /// <summary>
        /// ���ݪ��]�p���ܶq�C
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// �M�z�Ҧ����b�ϥΪ��귽�C
        /// </summary>
        /// <param name="disposing">�p�G�����񦫺޸귽�A�� true�F�_�h�� false�C</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows ����]�p���ͦ����{���X

        /// <summary>
        /// �]�p���䴩�һݪ���k - ���n
        /// �ϥε{���X�s�边�ק惡��k�����e�C
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sectext = new System.Windows.Forms.TextBox();
            this.secbut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(2, 32);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(505, 118);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.secbut);
            this.panel1.Controls.Add(this.sectext);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 150);
            this.panel1.TabIndex = 1;
            // 
            // sectext
            // 
            this.sectext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sectext.Location = new System.Drawing.Point(8, 6);
            this.sectext.Name = "sectext";
            this.sectext.Size = new System.Drawing.Size(404, 21);
            this.sectext.TabIndex = 1;
            // 
            // secbut
            // 
            this.secbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.secbut.Location = new System.Drawing.Point(421, 4);
            this.secbut.Name = "secbut";
            this.secbut.Size = new System.Drawing.Size(75, 23);
            this.secbut.TabIndex = 2;
            this.secbut.Text = "�j��";
            this.secbut.UseVisualStyleBackColor = true;
            this.secbut.Click += new System.EventHandler(this.secbut_Click);
            // 
            // LogShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 281);
            this.Controls.Add(this.panel1);
            this.Name = "LogShow";
            this.Text = "��� LINQ to SQL �ާ@��x";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button secbut;
        private System.Windows.Forms.TextBox sectext;
    }
}

