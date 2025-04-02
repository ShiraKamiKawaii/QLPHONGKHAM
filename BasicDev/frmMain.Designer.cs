namespace BasicDev
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            formManager = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            MenuBar = new DevExpress.XtraBars.Navigation.AccordionControl();
            menuPK = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            menuBN = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            menuTK = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            menuDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            frm = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            mainContener = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)formManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MenuBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frm).BeginInit();
            SuspendLayout();
            // 
            // formManager
            // 
            formManager.Form = this;
            // 
            // MenuBar
            // 
            MenuBar.AllowElementDragging = true;
            MenuBar.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Spline;
            MenuBar.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MenuBar.Appearance.AccordionControl.Options.UseFont = true;
            MenuBar.Appearance.Item.Default.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            MenuBar.Appearance.Item.Default.Options.UseFont = true;
            MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            MenuBar.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { menuPK, menuBN, menuTK, menuDangXuat });
            MenuBar.ItemHeight = 80;
            MenuBar.Location = new System.Drawing.Point(0, 31);
            MenuBar.Name = "MenuBar";
            MenuBar.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            MenuBar.Size = new System.Drawing.Size(245, 565);
            MenuBar.TabIndex = 1;
            MenuBar.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // menuPK
            // 
            menuPK.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("menuPK.ImageOptions.SvgImage");
            menuPK.Name = "menuPK";
            menuPK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            menuPK.Text = "Phiếu Khám Bệnh";
            menuPK.Click += menuPK_Click;
            // 
            // menuBN
            // 
            menuBN.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("menuBN.ImageOptions.SvgImage");
            menuBN.Name = "menuBN";
            menuBN.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            menuBN.Text = "Quản Lý Bệnh Nhân";
            menuBN.Click += MenuBN_Click;
            // 
            // menuTK
            // 
            menuTK.AccessibleName = "menuTK";
            menuTK.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("menuTK.ImageOptions.SvgImage");
            menuTK.Name = "menuTK";
            menuTK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            menuTK.Text = "Quản lý tài khoản";
            menuTK.Click += MenuTK_Click;
            // 
            // menuDangXuat
            // 
            menuDangXuat.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("menuDangXuat.ImageOptions.SvgImage");
            menuDangXuat.Name = "menuDangXuat";
            menuDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            menuDangXuat.Text = "Đăng xuất";
            menuDangXuat.Click += menuDangXuat_Click;
            // 
            // frm
            // 
            frm.FluentDesignForm = this;
            frm.Location = new System.Drawing.Point(0, 0);
            frm.Manager = formManager;
            frm.Name = "frm";
            frm.Size = new System.Drawing.Size(1227, 31);
            frm.TabIndex = 2;
            frm.TabStop = false;
            frm.Text = "Phòng Khám Đông Y Long Chi";
            // 
            // mainContener
            // 
            mainContener.Dock = System.Windows.Forms.DockStyle.Fill;
            mainContener.Location = new System.Drawing.Point(245, 31);
            mainContener.Name = "mainContener";
            mainContener.Size = new System.Drawing.Size(982, 565);
            mainContener.TabIndex = 3;
            // 
            // frmMain
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1227, 596);
            Controls.Add(mainContener);
            Controls.Add(MenuBar);
            Controls.Add(frm);
            FluentDesignFormControl = frm;
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            Name = "frmMain";
            NavigationControl = MenuBar;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Phòng Khám Đông Y Long Chi";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)formManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)MenuBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)frm).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl MenuBar;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl frm;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuBN;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager formManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuPK;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuTK;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuDangXuat;
        private System.Windows.Forms.Panel mainContener;
    }
}