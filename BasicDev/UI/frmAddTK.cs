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
    public partial class frmAddTK : DevExpress.XtraEditors.XtraForm
    {
        public frmAddTK()
        {
            InitializeComponent();
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
                taiKhoan = txtTaiKhoan.Text,
                matKhau = txtMatKhau.Text,
                hoTen = txtHoTen.Text,
                role = role.Text
            };
            _tk.Add(tk);
            this.Close();
            MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtHoTen.Text = FormatName(txtHoTen.Text);
            role.Text = role.Text.Trim();
        }
        private string FormatName(string name)
        {
            name = System.Text.RegularExpressions.Regex.Replace(name.Trim(), @"\s+", " "); // Loại bỏ khoảng trắng thừa giữa các từ
            string[] words = name.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            return string.Join(" ", words);
        }
    }
}