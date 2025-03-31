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
            btnThemBN = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            gc_DanhSach = new DevExpress.XtraGrid.GridControl();
            gv_DanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            panel_button.Controls.Add(btnThemBN);
            panel_button.Controls.Add(simpleButton2);
            panel_button.Controls.Add(simpleButton1);
            panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_button.Location = new System.Drawing.Point(0, 492);
            panel_button.Name = "panel_button";
            panel_button.Size = new System.Drawing.Size(1021, 75);
            panel_button.TabIndex = 1;
            panel_button.UseSkinIndents = true;
            // 
            // btnThemBN
            // 
            btnThemBN.AllowFocus = false;
            btnThemBN.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            btnThemBN.Appearance.Options.UseFont = true;
            btnThemBN.AutoWidthInLayoutControl = true;
            btnThemBN.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnThemBN.ImageOptions.Image");
            btnThemBN.Location = new System.Drawing.Point(14, 12);
            btnThemBN.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            btnThemBN.Name = "btnThemBN";
            btnThemBN.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            btnThemBN.ShowToolTips = false;
            btnThemBN.Size = new System.Drawing.Size(92, 50);
            btnThemBN.TabIndex = 2;
            btnThemBN.Text = "Thêm ";
            // 
            // simpleButton2
            // 
            simpleButton2.AllowFocus = false;
            simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            simpleButton2.Location = new System.Drawing.Point(159, 12);
            simpleButton2.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(92, 50);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "Sửa";
            // 
            // simpleButton1
            // 
            simpleButton1.AllowFocus = false;
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(303, 12);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(92, 50);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "Xóa";
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
            gv_DanhSach.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gv_DanhSach.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            gv_DanhSach.Appearance.HeaderPanel.Options.UseBackColor = true;
            gv_DanhSach.Appearance.HeaderPanel.Options.UseFont = true;
            gv_DanhSach.Appearance.HeaderPanel.Options.UseForeColor = true;
            gv_DanhSach.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.Lime;
            gv_DanhSach.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            gv_DanhSach.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gv_DanhSach.GridControl = gc_DanhSach;
            gv_DanhSach.Name = "gv_DanhSach";
            gv_DanhSach.OptionsBehavior.Editable = false;
            gv_DanhSach.OptionsEditForm.EditFormColumnCount = 2;
            gv_DanhSach.OptionsSelection.EnableAppearanceFocusedCell = false;
            gv_DanhSach.OptionsView.ShowGroupPanel = false;
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
        private DevExpress.XtraEditors.SimpleButton btnThemBN;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gc_DanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DanhSach;
    }
}
