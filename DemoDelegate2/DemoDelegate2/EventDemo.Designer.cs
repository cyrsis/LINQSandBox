namespace DemoDelegate2
{
    partial class EventDemo
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
            this.but = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(172, 35);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(75, 23);
            this.but.TabIndex = 0;
            this.but.Text = "�}�l";
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 95);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(235, 23);
            this.progressBar.TabIndex = 1;
            // 
            // EventDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 149);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.but);
            this.Name = "EventDemo";
            this.Text = "�۩w�q�ƥ�ܽd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

