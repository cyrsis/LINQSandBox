namespace DemoFindFile
{
    partial class FindForm
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
            this.txtfolder = new System.Windows.Forms.TextBox();
            this.seldir = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.filelst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.filetypelst = new System.Windows.Forms.ListBox();
            this.labtypecount = new System.Windows.Forms.Label();
            this.labfncount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfolder
            // 
            this.txtfolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfolder.Location = new System.Drawing.Point(71, 12);
            this.txtfolder.Name = "txtfolder";
            this.txtfolder.Size = new System.Drawing.Size(395, 21);
            this.txtfolder.TabIndex = 0;
            this.txtfolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfolder_KeyDown);
            // 
            // seldir
            // 
            this.seldir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seldir.Location = new System.Drawing.Point(475, 9);
            this.seldir.Name = "seldir";
            this.seldir.Size = new System.Drawing.Size(31, 23);
            this.seldir.TabIndex = 1;
            this.seldir.Text = "...";
            this.seldir.UseVisualStyleBackColor = true;
            this.seldir.Click += new System.EventHandler(this.seldir_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // filelst
            // 
            this.filelst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filelst.FormattingEnabled = true;
            this.filelst.HorizontalScrollbar = true;
            this.filelst.ItemHeight = 12;
            this.filelst.Location = new System.Drawing.Point(87, 72);
            this.filelst.Name = "filelst";
            this.filelst.Size = new System.Drawing.Size(419, 268);
            this.filelst.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "檔案夾：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "查詢：";
            // 
            // txtfind
            // 
            this.txtfind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfind.Location = new System.Drawing.Point(71, 39);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(431, 21);
            this.txtfind.TabIndex = 6;
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged);
            // 
            // filetypelst
            // 
            this.filetypelst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.filetypelst.FormattingEnabled = true;
            this.filetypelst.ItemHeight = 12;
            this.filetypelst.Location = new System.Drawing.Point(9, 72);
            this.filetypelst.Name = "filetypelst";
            this.filetypelst.Size = new System.Drawing.Size(72, 268);
            this.filetypelst.TabIndex = 7;
            this.filetypelst.SelectedIndexChanged += new System.EventHandler(this.filetypelst_SelectedIndexChanged);
            // 
            // labtypecount
            // 
            this.labtypecount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labtypecount.AutoSize = true;
            this.labtypecount.Location = new System.Drawing.Point(13, 349);
            this.labtypecount.Name = "labtypecount";
            this.labtypecount.Size = new System.Drawing.Size(0, 12);
            this.labtypecount.TabIndex = 8;
            // 
            // labfncount
            // 
            this.labfncount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labfncount.AutoSize = true;
            this.labfncount.Location = new System.Drawing.Point(85, 349);
            this.labfncount.Name = "labfncount";
            this.labfncount.Size = new System.Drawing.Size(0, 12);
            this.labfncount.TabIndex = 9;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 373);
            this.Controls.Add(this.labfncount);
            this.Controls.Add(this.labtypecount);
            this.Controls.Add(this.filetypelst);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filelst);
            this.Controls.Add(this.seldir);
            this.Controls.Add(this.txtfolder);
            this.Name = "FindForm";
            this.Text = "檔案尋找與分組";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfolder;
        private System.Windows.Forms.Button seldir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox filelst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.ListBox filetypelst;
        private System.Windows.Forms.Label labtypecount;
        private System.Windows.Forms.Label labfncount;
    }
}

