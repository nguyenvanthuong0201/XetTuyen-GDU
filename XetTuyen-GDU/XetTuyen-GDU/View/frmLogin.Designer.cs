namespace XetTuyen_GDU.View
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnQuenMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.btnComback = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            this.laNotice = new System.Windows.Forms.Label();
            this.laTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.splitContainerControl1.Panel2.Controls.Add(this.btnQuenMatKhau);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnComback);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLogout);
            this.splitContainerControl1.Panel2.Controls.Add(this.laNotice);
            this.splitContainerControl1.Panel2.Controls.Add(this.laTitle);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtPassword);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtUserName);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnExit);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLogin);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(489, 348);
            this.splitContainerControl1.SplitterPosition = 116;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // btnQuenMatKhau
            // 
            this.btnQuenMatKhau.Location = new System.Drawing.Point(81, 287);
            this.btnQuenMatKhau.Name = "btnQuenMatKhau";
            this.btnQuenMatKhau.Size = new System.Drawing.Size(201, 23);
            this.btnQuenMatKhau.TabIndex = 18;
            this.btnQuenMatKhau.Text = "Quên mật khẩu ?";
            // 
            // btnComback
            // 
            this.btnComback.Location = new System.Drawing.Point(102, 91);
            this.btnComback.Name = "btnComback";
            this.btnComback.Size = new System.Drawing.Size(154, 32);
            this.btnComback.TabIndex = 10;
            this.btnComback.Text = "Quay lại";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(102, 138);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 32);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Đăng xuất";
            // 
            // laNotice
            // 
            this.laNotice.AutoSize = true;
            this.laNotice.Location = new System.Drawing.Point(115, 77);
            this.laNotice.Name = "laNotice";
            this.laNotice.Size = new System.Drawing.Size(0, 13);
            this.laNotice.TabIndex = 17;
            // 
            // laTitle
            // 
            this.laTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.Appearance.Options.UseFont = true;
            this.laTitle.Location = new System.Drawing.Point(131, 36);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(104, 25);
            this.laTitle.TabIndex = 16;
            this.laTitle.Text = "Đăng nhập";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(81, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(201, 20);
            this.txtPassword.TabIndex = 14;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(81, 103);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 20);
            this.txtUserName.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(81, 198);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Đăng nhập";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 348);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuenMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnComback;
        private DevExpress.XtraEditors.SimpleButton btnLogout;
        private System.Windows.Forms.Label laNotice;
        private DevExpress.XtraEditors.LabelControl laTitle;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}