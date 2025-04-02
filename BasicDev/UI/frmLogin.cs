using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLayer;
using DataLayer;
using BasicDev;
using DevExpress.XtraRichEdit.Import.Doc;

namespace QLPHONGKHAM.UI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public string UserRole { get; set; }
        TAIKHOAN _tk;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            _tk = new TAIKHOAN();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            btnLogin.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            TaiKhoan tk = new TaiKhoan()
            {
                taiKhoan = txtTaiKhoan.Text,
                matKhau = txtMatKhau.Text
            };
            TaiKhoan user = _tk.CheckLogin(tk);
            if (user != null)
            {
                UserRole = user.role;
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}