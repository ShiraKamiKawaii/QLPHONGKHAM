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
    public partial class frmAddBN : DevExpress.XtraEditors.XtraForm
    {
        public frmAddBN()
        {
            InitializeComponent();
        }
        BENHNHAN _bn;
        private void btnSaveBN_Click(object sender, EventArgs e)
        {
            TrimAllInputs();
            if (!ValidateInput())
            {
                return;
            }
            _bn = new BENHNHAN();
            BenhNhan bn = new BenhNhan();
            bn.maBN = $"BN{txtsoCCCD.Text}";
            bn.hoTenBN = txthoTenBN.Text;
            bn.ngaySinh = dateNgaySinh.Value;
            bn.gioiTinh = radioNam.Checked ? "Nam" : "Nữ";
            bn.diaChi = txtdiaChi.Text;
            bn.dienThoai = txtdienThoai.Text;
            bn.CCCD = txtsoCCCD.Text;
            _bn.Add(bn);
            this.Close();
            MessageBox.Show("Thêm bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txthoTenBN.Text) ||
                string.IsNullOrWhiteSpace(txtdiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtdienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtsoCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidName(txthoTenBN.Text))
            {
                MessageBox.Show("Họ tên không được chứa số hoặc ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(txtdienThoai.Text))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool IsValidName(string name)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[\p{L} ]+$"); // Chỉ chứa chữ cái và khoảng trắng
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d+$"); // Chỉ chứa số
        }
        private void TrimAllInputs()
        {
            txthoTenBN.Text = FormatName(txthoTenBN.Text);
            txtdiaChi.Text = txtdiaChi.Text.Trim();
            txtdienThoai.Text = txtdienThoai.Text.Trim();
            txtsoCCCD.Text = txtsoCCCD.Text.Trim();
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