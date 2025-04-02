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

namespace QLPHONGKHAM.UI
{
    public partial class frmUpdateTK : DevExpress.XtraEditors.XtraForm
    {
        public frmUpdateTK(TaiKhoan tk)
        {
            InitializeComponent();
            txtID.Text = tk.ID.ToString();
            txtTaiKhoan.Text = tk.taiKhoan;
            txtMatKhau.Text = tk.matKhau;
            txtHoTen.Text = tk.hoTen;
            role.Text = tk.role;
        }
        TAIKHOAN _tk;

        private void btnSaveTK_Click(object sender, EventArgs e)
        {
            TrimAllInputs();
            if (!ValidateInput())
            {
                return;
            }
            _tk = new TAIKHOAN();
            TaiKhoan tk = new TaiKhoan()
            {
                ID = int.Parse(txtID.Text),
                taiKhoan = txtTaiKhoan.Text,
                matKhau = txtMatKhau.Text,
                hoTen = txtHoTen.Text,
                role = role.Text
            };
            _tk.Update(tk);
            this.Close();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(role.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!IsValidName(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được chứa số hoặc ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool IsValidName(string name)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[\p{L} ]+$"); // Chỉ chứa chữ cái và khoảng trắng
        }
        private void TrimAllInputs()
        {
            txtTaiKhoan.Text = txtTaiKhoan.Text.Trim();
            txtMatKhau.Text = txtMatKhau.Text.Trim();
            txtHoTen.Text = txtHoTen.Text.Trim();
            role.Text = role.Text.Trim();
        }
    }
}