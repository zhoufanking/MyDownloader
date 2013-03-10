namespace Frank.MyDownloader
{
    partial class Form1
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
            this.lblLink = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFileDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.ForeColor = System.Drawing.Color.Red;
            this.lblLink.Location = new System.Drawing.Point(40, 23);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(101, 12);
            this.lblLink.TabIndex = 0;
            this.lblLink.Text = "请输入下载链接：";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(42, 52);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(393, 21);
            this.txtLink.TabIndex = 1;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.ForeColor = System.Drawing.Color.Red;
            this.lblFilename.Location = new System.Drawing.Point(42, 94);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(113, 12);
            this.lblFilename.TabIndex = 2;
            this.lblFilename.Text = "请输入文件存储名：";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(42, 123);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(296, 21);
            this.txtFilename.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(44, 187);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开始下载";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(120, 233);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(181, 186);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "打开文件";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFileDir
            // 
            this.btnOpenFileDir.Location = new System.Drawing.Point(321, 185);
            this.btnOpenFileDir.Name = "btnOpenFileDir";
            this.btnOpenFileDir.Size = new System.Drawing.Size(94, 23);
            this.btnOpenFileDir.TabIndex = 6;
            this.btnOpenFileDir.Text = "打开文件位置";
            this.btnOpenFileDir.UseVisualStyleBackColor = true;
            this.btnOpenFileDir.Click += new System.EventHandler(this.btnOpenFileDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "下载进度：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFileDir);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblLink);
            this.Name = "Form1";
            this.Text = "MyDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenFileDir;
        private System.Windows.Forms.Label label1;
    }
}

