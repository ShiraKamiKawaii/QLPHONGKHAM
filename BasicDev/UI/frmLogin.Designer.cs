namespace QLPHONGKHAM.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            btnCLose = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new System.Windows.Forms.Panel();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtTaiKhoan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMatKhau.Properties).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AllowFocus = false;
            btnLogin.Appearance.BackColor = System.Drawing.Color.Transparent;
            btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.Appearance.Options.UseBackColor = true;
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.AppearanceDisabled.Options.UseBackColor = true;
            btnLogin.AppearanceHovered.Options.UseBackColor = true;
            btnLogin.AppearancePressed.Options.UseBackColor = true;
            btnLogin.AutoSize = true;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnLogin.ImageOptions.SvgImage");
            btnLogin.Location = new System.Drawing.Point(132, 189);
            btnLogin.Name = "btnLogin";
            btnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            btnLogin.Size = new System.Drawing.Size(112, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtTaiKhoan.Location = new System.Drawing.Point(151, 70);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new System.Drawing.Size(180, 20);
            txtTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtMatKhau.Location = new System.Drawing.Point(151, 126);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Properties.UseSystemPasswordChar = true;
            txtMatKhau.Size = new System.Drawing.Size(180, 20);
            txtMatKhau.TabIndex = 2;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.Chartreuse;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(51, 127);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(76, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "PASSWORD";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.Chartreuse;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(51, 71);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(71, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "USERNAME";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(123, 19);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(171, 33);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "ĐĂNG NHẬP";
            // 
            // btnCLose
            // 
            btnCLose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCLose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCLose.ImageOptions.SvgImage");
            btnCLose.Location = new System.Drawing.Point(812, 12);
            btnCLose.Name = "btnCLose";
            btnCLose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnCLose.Size = new System.Drawing.Size(36, 36);
            btnCLose.TabIndex = 0;
            btnCLose.Click += btnCLose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(labelControl1);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(labelControl2);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Controls.Add(labelControl3);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new System.Drawing.Point(200, 129);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(415, 248);
            panel1.TabIndex = 0;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(128, 255, 128);
            labelControl4.Appearance.Options.UseBackColor = true;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            labelControl4.Location = new System.Drawing.Point(138, 48);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(590, 42);
            labelControl4.TabIndex = 1;
            labelControl4.Text = "PHÒNG KHÁM ĐÔNG Y LONG CHI";
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            Appearance.BackColor = System.Drawing.Color.Transparent;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            BackgroundImageStore = Properties.Resources.DongY;
            ClientSize = new System.Drawing.Size(860, 485);
            Controls.Add(labelControl4);
            Controls.Add(panel1);
            Controls.Add(btnCLose);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            IconOptions.Image = (System.Drawing.Image)resources.GetObject("frmLogin.IconOptions.Image");
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)txtTaiKhoan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMatKhau.Properties).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCLose;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}