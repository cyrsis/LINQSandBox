namespace DomViewer
{
    partial class Viewer
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
            this.tvdom = new System.Windows.Forms.TreeView();
            this.txturl = new System.Windows.Forms.TextBox();
            this.butget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvdom
            // 
            this.tvdom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvdom.Location = new System.Drawing.Point(0, 27);
            this.tvdom.Name = "tvdom";
            this.tvdom.Size = new System.Drawing.Size(252, 199);
            this.tvdom.TabIndex = 0;
            this.tvdom.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvdom_AfterSelect);
            this.tvdom.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvdom_AfterExpand);
            // 
            // txturl
            // 
            this.txturl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txturl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txturl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txturl.Location = new System.Drawing.Point(2, 3);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(199, 21);
            this.txturl.TabIndex = 1;
            this.txturl.Text = "http://rss.sina.com.cn/news/marquee/ddt.xml";
            this.txturl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txturl_KeyDown);
            // 
            // butget
            // 
            this.butget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butget.Location = new System.Drawing.Point(204, 1);
            this.butget.Name = "butget";
            this.butget.Size = new System.Drawing.Size(47, 23);
            this.butget.TabIndex = 2;
            this.butget.Text = "獲取";
            this.butget.UseVisualStyleBackColor = true;
            this.butget.Click += new System.EventHandler(this.butget_Click);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 226);
            this.Controls.Add(this.butget);
            this.Controls.Add(this.tvdom);
            this.Controls.Add(this.txturl);
            this.Name = "Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS DOM檢視器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvdom;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button butget;
    }
}

