namespace Chatting
{
    partial class Login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelaccount = new System.Windows.Forms.Label();
            this.labelpwd = new System.Windows.Forms.Label();
            this.textBoxaccount = new System.Windows.Forms.TextBox();
            this.textBoxpwd = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelregister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelaccount
            // 
            this.labelaccount.AutoSize = true;
            this.labelaccount.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelaccount.Location = new System.Drawing.Point(58, 58);
            this.labelaccount.Name = "labelaccount";
            this.labelaccount.Size = new System.Drawing.Size(69, 20);
            this.labelaccount.TabIndex = 0;
            this.labelaccount.Text = "用户名：";
            // 
            // labelpwd
            // 
            this.labelpwd.AutoSize = true;
            this.labelpwd.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelpwd.Location = new System.Drawing.Point(58, 125);
            this.labelpwd.Name = "labelpwd";
            this.labelpwd.Size = new System.Drawing.Size(62, 20);
            this.labelpwd.TabIndex = 1;
            this.labelpwd.Text = "密  码：";
            // 
            // textBoxaccount
            // 
            this.textBoxaccount.Font = new System.Drawing.Font("微软雅黑", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxaccount.Location = new System.Drawing.Point(142, 47);
            this.textBoxaccount.Name = "textBoxaccount";
            this.textBoxaccount.Size = new System.Drawing.Size(231, 38);
            this.textBoxaccount.TabIndex = 2;
            // 
            // textBoxpwd
            // 
            this.textBoxpwd.Font = new System.Drawing.Font("微软雅黑", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxpwd.Location = new System.Drawing.Point(142, 114);
            this.textBoxpwd.Name = "textBoxpwd";
            this.textBoxpwd.PasswordChar = '*';
            this.textBoxpwd.Size = new System.Drawing.Size(231, 38);
            this.textBoxpwd.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Location = new System.Drawing.Point(193, 180);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(121, 45);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "登陆";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelregister
            // 
            this.labelregister.AutoSize = true;
            this.labelregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelregister.Font = new System.Drawing.Font("微软雅黑", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelregister.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelregister.Location = new System.Drawing.Point(403, 17);
            this.labelregister.Name = "labelregister";
            this.labelregister.Size = new System.Drawing.Size(52, 27);
            this.labelregister.TabIndex = 5;
            this.labelregister.Text = "注册";
            this.labelregister.Click += new System.EventHandler(this.labelregister_Click);
            this.labelregister.MouseLeave += new System.EventHandler(this.labelregister_MouseLeave);
            this.labelregister.MouseHover += new System.EventHandler(this.labelregister_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 251);
            this.Controls.Add(this.labelregister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxpwd);
            this.Controls.Add(this.textBoxaccount);
            this.Controls.Add(this.labelpwd);
            this.Controls.Add(this.labelaccount);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelaccount;
        private System.Windows.Forms.Label labelpwd;
        private System.Windows.Forms.TextBox textBoxaccount;
        private System.Windows.Forms.TextBox textBoxpwd;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelregister;
    }
}

