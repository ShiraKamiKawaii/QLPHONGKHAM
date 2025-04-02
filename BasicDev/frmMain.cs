using BasicDev.UI;
using DevExpress.XtraBars;
using QLPHONGKHAM.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BasicDev {
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain(string userRole)
        {
            InitializeComponent();
            this.UserRole = userRole;
        }
        UC_BenhNhan ucBenhNhan;
        UC_TaiKhoan ucTaiKhoan;
        UC_PhieuKham ucPhieuKham;
        private string UserRole;
        private void MenuBN_Click(object sender, EventArgs e)
        {
            if (mainContener.Controls.Count > 0 && mainContener.Controls[0] is UC_BenhNhan ucBenhNhan)
            {
                ucBenhNhan.Reload();
                ucBenhNhan.BringToFront();
            }
            else
            {
                ucBenhNhan = new UC_BenhNhan();
                ucBenhNhan.Dock = DockStyle.Fill;
                mainContener.Controls.Add(ucBenhNhan);
                ucBenhNhan.BringToFront();
            }
        }

        private void MenuTK_Click(object sender, EventArgs e)
        {
            if (mainContener.Controls.Count > 0 && mainContener.Controls[0] is UC_TaiKhoan ucTaiKhoan)
            {
                ucTaiKhoan.Reload();
                ucTaiKhoan.BringToFront();
            }
            else
            {
                ucTaiKhoan = new UC_TaiKhoan();
                ucTaiKhoan.Dock = DockStyle.Fill;
                mainContener.Controls.Add(ucTaiKhoan);
                ucTaiKhoan.BringToFront();
            }
        }

        private void menuPK_Click(object sender, EventArgs e)
        {
            if (mainContener.Controls.Count > 0 && mainContener.Controls[0] is UC_PhieuKham ucPhieuKham)
            {
                ucPhieuKham.Reload();
                ucPhieuKham.BringToFront();
            }
            else
            {
                ucPhieuKham = new UC_PhieuKham();
                mainContener.Controls.Add(ucPhieuKham);
                ucPhieuKham.Dock = DockStyle.Fill;
                ucPhieuKham.BringToFront();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UserRole = UserRole.Trim().ToLower();
            if (UserRole != "admin")
            {
                menuTK.Visible = false;
            }
        }
        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
