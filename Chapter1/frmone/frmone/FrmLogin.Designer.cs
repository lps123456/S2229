namespace frmone
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btndeng = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmail.Location = new System.Drawing.Point(57, 136);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(97, 15);
            this.lblmail.TabIndex = 1;
            this.lblmail.Text = "电子邮件地址";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpwd.Location = new System.Drawing.Point(57, 236);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(37, 15);
            this.lblpwd.TabIndex = 2;
            this.lblpwd.Text = "密码";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(60, 182);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(601, 25);
            this.txtmail.TabIndex = 3;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(60, 269);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(601, 25);
            this.txtpwd.TabIndex = 4;
            // 
            // btndeng
            // 
            this.btndeng.Location = new System.Drawing.Point(60, 341);
            this.btndeng.Name = "btndeng";
            this.btndeng.Size = new System.Drawing.Size(75, 31);
            this.btndeng.TabIndex = 5;
            this.btndeng.Text = "登录";
            this.btndeng.UseVisualStyleBackColor = true;
            this.btndeng.Click += new System.EventHandler(this.btndeng_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(232, 402);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "注册";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "还没有通行证？现在就";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(728, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btndeng);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button btndeng;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

