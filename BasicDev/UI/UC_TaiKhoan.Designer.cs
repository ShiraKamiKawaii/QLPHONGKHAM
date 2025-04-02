namespace BasicDev.UI
{
    partial class UC_TaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TaiKhoan));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            label1 = new System.Windows.Forms.Label();
            panel_button = new DevExpress.Utils.Layout.StackPanel();
            btnThemTK = new DevExpress.XtraEditors.SimpleButton();
            btnSuaTK = new DevExpress.XtraEditors.SimpleButton();
            btnXoaTK = new DevExpress.XtraEditors.SimpleButton();
            gc_DanhSach = new DevExpress.XtraGrid.GridControl();
            gv_DanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            ID = new DevExpress.XtraGrid.Columns.GridColumn();
            taiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            hoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            role = new DevExpress.XtraGrid.Columns.GridColumn();
            matKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panel_button).BeginInit();
            panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gc_DanhSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gv_DanhSach).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(label1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1021, 63);
            panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.LimeGreen;
            label1.Location = new System.Drawing.Point(2, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1017, 59);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Tài Khoản";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_button
            // 
            panel_button.Controls.Add(btnThemTK);
            panel_button.Controls.Add(btnSuaTK);
            panel_button.Controls.Add(btnXoaTK);
            panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_button.Location = new System.Drawing.Point(0, 492);
            panel_button.Name = "panel_button";
            panel_button.Size = new System.Drawing.Size(1021, 75);
            panel_button.TabIndex = 1;
            panel_button.UseSkinIndents = true;
            // 
            // btnThemTK
            // 
            btnThemTK.AllowFocus = false;
            btnThemTK.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            btnThemTK.Appearance.Options.UseFont = true;
            btnThemTK.AutoWidthInLayoutControl = true;
            btnThemTK.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnThemTK.ImageOptions.Image");
            btnThemTK.Location = new System.Drawing.Point(14, 12);
            btnThemTK.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            btnThemTK.Name = "btnThemTK";
            btnThemTK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            btnThemTK.ShowToolTips = false;
            btnThemTK.Size = new System.Drawing.Size(92, 50);
            btnThemTK.TabIndex = 2;
            btnThemTK.Text = "Thêm ";
            btnThemTK.Click += btnThemTK_Click;
            // 
            // btnSuaTK
            // 
            btnSuaTK.AllowFocus = false;
            btnSuaTK.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            btnSuaTK.Appearance.Options.UseFont = true;
            btnSuaTK.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSuaTK.ImageOptions.Image");
            btnSuaTK.Location = new System.Drawing.Point(159, 12);
            btnSuaTK.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            btnSuaTK.Name = "btnSuaTK";
            btnSuaTK.Size = new System.Drawing.Size(92, 50);
            btnSuaTK.TabIndex = 1;
            btnSuaTK.Text = "Sửa";
            btnSuaTK.Click += btnSuaTK_Click;
            // 
            // btnXoaTK
            // 
            btnXoaTK.AllowFocus = false;
            btnXoaTK.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            btnXoaTK.Appearance.Options.UseFont = true;
            btnXoaTK.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnXoaTK.ImageOptions.Image");
            btnXoaTK.Location = new System.Drawing.Point(303, 12);
            btnXoaTK.Name = "btnXoaTK";
            btnXoaTK.Size = new System.Drawing.Size(92, 50);
            btnXoaTK.TabIndex = 0;
            btnXoaTK.Text = "Xóa";
            btnXoaTK.Click += btnXoaTK_Click;
            // 
            // gc_DanhSach
            // 
            gc_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            gc_DanhSach.Location = new System.Drawing.Point(0, 63);
            gc_DanhSach.MainView = gv_DanhSach;
            gc_DanhSach.Name = "gc_DanhSach";
            gc_DanhSach.Size = new System.Drawing.Size(1021, 429);
            gc_DanhSach.TabIndex = 2;
            gc_DanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gv_DanhSach });
            // 
            // gv_DanhSach
            // 
            gv_DanhSach.Appearance.FixedLine.BackColor = System.Drawing.Color.Lime;
            gv_DanhSach.Appearance.FixedLine.Options.UseBackColor = true;
            gv_DanhSach.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            gv_DanhSach.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            gv_DanhSach.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            gv_DanhSach.Appearance.HeaderPanel.Options.UseBackColor = true;
            gv_DanhSach.Appearance.HeaderPanel.Options.UseFont = true;
            gv_DanhSach.Appearance.HeaderPanel.Options.UseForeColor = true;
            gv_DanhSach.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.Lime;
            gv_DanhSach.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            gv_DanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ID, taiKhoan, matKhau, hoTen, role });
            gv_DanhSach.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gv_DanhSach.GridControl = gc_DanhSach;
            gv_DanhSach.Name = "gv_DanhSach";
            gv_DanhSach.OptionsBehavior.Editable = false;
            gv_DanhSach.OptionsEditForm.EditFormColumnCount = 2;
            gv_DanhSach.OptionsSelection.EnableAppearanceFocusedCell = false;
            gv_DanhSach.OptionsView.ShowGroupPanel = false;
            gv_DanhSach.Click += gv_DanhSach_Click;
            // 
            // ID
            // 
            ID.Caption = "ID";
            ID.FieldName = "ID";
            ID.Name = "ID";
            ID.Visible = true;
            ID.VisibleIndex = 0;
            // 
            // taiKhoan
            // 
            taiKhoan.Caption = "Tài khoản";
            taiKhoan.FieldName = "taiKhoan";
            taiKhoan.Name = "taiKhoan";
            taiKhoan.Visible = true;
            taiKhoan.VisibleIndex = 1;
            // 
            // hoTen
            // 
            hoTen.Caption = "Họ và tên";
            hoTen.FieldName = "hoTen";
            hoTen.Name = "hoTen";
            hoTen.Visible = true;
            hoTen.VisibleIndex = 3;
            // 
            // role
            // 
            role.Caption = "role";
            role.FieldName = "role";
            role.Name = "role";
            role.Visible = true;
            role.VisibleIndex = 4;
            // 
            // matKhau
            // 
            matKhau.Caption = "Mật khẩu";
            matKhau.FieldName = "matKhau";
            matKhau.Name = "matKhau";
            matKhau.Visible = true;
            matKhau.VisibleIndex = 2;
            // 
            // UC_TaiKhoan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gc_DanhSach);
            Controls.Add(panel_button);
            Controls.Add(panelControl1);
            Name = "UC_TaiKhoan";
            Size = new System.Drawing.Size(1021, 567);
            Load += UC_TaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panel_button).EndInit();
            panel_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gc_DanhSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)gv_DanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.StackPanel panel_button;
        private DevExpress.XtraEditors.SimpleButton btnThemTK;
        private DevExpress.XtraEditors.SimpleButton btnSuaTK;
        private DevExpress.XtraEditors.SimpleButton btnXoaTK;
        private DevExpress.XtraGrid.GridControl gc_DanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn taiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn hoTen;
        private DevExpress.XtraGrid.Columns.GridColumn role;
        private DevExpress.XtraGrid.Columns.GridColumn matKhau;
    }
}
