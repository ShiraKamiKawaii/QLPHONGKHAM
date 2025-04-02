namespace QLPHONGKHAM.UI
{
    partial class frmAddTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTK));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            btnSaveTK = new DevExpress.XtraEditors.SimpleButton();
            txtHoTen = new DevExpress.XtraEditors.TextEdit();
            txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            role = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtHoTen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMatKhau.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTaiKhoan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)role.Properties).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(tablePanel1);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(399, 268);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 13.4F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 46.6F) });
            tablePanel1.Controls.Add(btnSaveTK);
            tablePanel1.Controls.Add(txtHoTen);
            tablePanel1.Controls.Add(txtMatKhau);
            tablePanel1.Controls.Add(txtTaiKhoan);
            tablePanel1.Controls.Add(labelControl4);
            tablePanel1.Controls.Add(labelControl3);
            tablePanel1.Controls.Add(labelControl2);
            tablePanel1.Controls.Add(labelControl1);
            tablePanel1.Controls.Add(role);
            tablePanel1.Location = new System.Drawing.Point(12, 12);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 39F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 39F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 39F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 39F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 39F) });
            tablePanel1.Size = new System.Drawing.Size(375, 244);
            tablePanel1.TabIndex = 4;
            tablePanel1.UseSkinIndents = true;
            // 
            // btnSaveTK
            // 
            btnSaveTK.AllowFocus = false;
            btnSaveTK.Appearance.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            btnSaveTK.Appearance.BorderColor = System.Drawing.Color.Lime;
            btnSaveTK.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            btnSaveTK.Appearance.Options.UseBackColor = true;
            btnSaveTK.Appearance.Options.UseBorderColor = true;
            btnSaveTK.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnSaveTK, 1);
            btnSaveTK.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSaveTK.ImageOptions.Image");
            btnSaveTK.Location = new System.Drawing.Point(92, 180);
            btnSaveTK.Name = "btnSaveTK";
            tablePanel1.SetRow(btnSaveTK, 10);
            btnSaveTK.Size = new System.Drawing.Size(270, 38);
            btnSaveTK.TabIndex = 21;
            btnSaveTK.Text = "Lưu";
            btnSaveTK.Click += btnSaveTK_Click;
            // 
            // txtHoTen
            // 
            tablePanel1.SetColumn(txtHoTen, 1);
            txtHoTen.Location = new System.Drawing.Point(92, 97);
            txtHoTen.Name = "txtHoTen";
            tablePanel1.SetRow(txtHoTen, 2);
            txtHoTen.Size = new System.Drawing.Size(270, 20);
            txtHoTen.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            tablePanel1.SetColumn(txtMatKhau, 1);
            txtMatKhau.Location = new System.Drawing.Point(92, 58);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Properties.UseSystemPasswordChar = true;
            tablePanel1.SetRow(txtMatKhau, 1);
            txtMatKhau.Size = new System.Drawing.Size(270, 20);
            txtMatKhau.TabIndex = 5;
            // 
            // txtTaiKhoan
            // 
            tablePanel1.SetColumn(txtTaiKhoan, 1);
            txtTaiKhoan.Location = new System.Drawing.Point(92, 19);
            txtTaiKhoan.Name = "txtTaiKhoan";
            tablePanel1.SetRow(txtTaiKhoan, 0);
            txtTaiKhoan.Size = new System.Drawing.Size(270, 20);
            txtTaiKhoan.TabIndex = 4;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            tablePanel1.SetColumn(labelControl4, 0);
            labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl4.Location = new System.Drawing.Point(13, 129);
            labelControl4.Name = "labelControl4";
            tablePanel1.SetRow(labelControl4, 3);
            labelControl4.Size = new System.Drawing.Size(75, 35);
            labelControl4.TabIndex = 3;
            labelControl4.Text = "Role";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            tablePanel1.SetColumn(labelControl3, 0);
            labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl3.Location = new System.Drawing.Point(13, 90);
            labelControl3.Name = "labelControl3";
            tablePanel1.SetRow(labelControl3, 2);
            labelControl3.Size = new System.Drawing.Size(75, 35);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "Họ và tên";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            tablePanel1.SetColumn(labelControl2, 0);
            labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl2.Location = new System.Drawing.Point(13, 51);
            labelControl2.Name = "labelControl2";
            tablePanel1.SetRow(labelControl2, 1);
            labelControl2.Size = new System.Drawing.Size(75, 35);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            tablePanel1.SetColumn(labelControl1, 0);
            labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl1.Location = new System.Drawing.Point(13, 12);
            labelControl1.Name = "labelControl1";
            tablePanel1.SetRow(labelControl1, 0);
            labelControl1.Size = new System.Drawing.Size(75, 35);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Tài khoản";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(399, 268);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = tablePanel1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(379, 248);
            layoutControlItem1.TextVisible = false;
            // 
            // role
            // 
            role.Location = new System.Drawing.Point(92, 136);
            role.Name = "role";
            role.Size = new System.Drawing.Size(270, 20);
            role.TabIndex = 7;
            // 
            // frmAddTK
            // 
            AcceptButton = btnSaveTK;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(399, 268);
            Controls.Add(layoutControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddTK";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FORM THÊM TÀI KHOẢN";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtHoTen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMatKhau.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTaiKhoan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)role.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnSaveTK;
        private DevExpress.XtraEditors.TextEdit role;
    }
}