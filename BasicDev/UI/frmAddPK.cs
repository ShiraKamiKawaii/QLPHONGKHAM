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
using DevExpress.Utils.DirectXPaint;

namespace QLPHONGKHAM.UI
{
    public partial class frmAddPK : DevExpress.XtraEditors.XtraForm
    {
        public frmAddPK()
        {
            InitializeComponent();
        }
        PHIEUKHAM _pk;
        BENHNHAN _bn;
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaBN.Text) ||
                string.IsNullOrWhiteSpace(txtHoTenBN.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtMaPK.Text) ||
                string.IsNullOrWhiteSpace(txtChuanDoan.Text) ||
                string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidName(txtHoTenBN.Text))
            {
                MessageBox.Show("Họ tên không được chứa số hoặc ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(txtDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
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
            txtMaBN.Text = txtMaBN.Text.Trim();
            txtHoTenBN.Text = txtHoTenBN.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
            txtDienThoai.Text = txtDienThoai.Text.Trim();
            txtCCCD.Text = txtCCCD.Text.Trim();
            txtMaPK.Text = txtMaPK.Text.Trim();
            txtChuanDoan.Text = txtChuanDoan.Text.Trim();
            txtNoiDung.Text = txtNoiDung.Text.Trim();
        }
        private void UpdateMaBN()
        {
            txtMaBN.Text = $"BN{txtCCCD.Text}";
        }
        private void btnSavePK_Click(object sender, EventArgs e)
        {
            TrimAllInputs();
            if (!ValidateInput())
            {
                return;
            }
            string maBN = txtMaBN.Text;
            _bn = new BENHNHAN();
            var check = _bn.getItem(maBN);
            if (check == null)
            {
                BenhNhan bn = new BenhNhan();
                bn.maBN = txtMaBN.Text;
                bn.hoTenBN = txtHoTenBN.Text;
                bn.ngaySinh = dateNgaySinh.Value;
                bn.gioiTinh = radioNam.Checked ? "Nam" : "Nữ";
                bn.diaChi = txtDiaChi.Text;
                bn.dienThoai = txtDienThoai.Text;
                bn.CCCD = txtCCCD.Text;
                _bn.Add(bn);
            }
            _pk = new PHIEUKHAM();
            PhieuKham pk = new PhieuKham();
            pk.maPK = txtMaPK.Text;
            pk.maBN = txtMaBN.Text;
            pk.hoTenBN = txtHoTenBN.Text;
            pk.ngaySinh = dateNgaySinh.Value;
            pk.gioiTinh = radioNam.Checked ? "Nam" : "Nữ";
            pk.diaChi = txtDiaChi.Text;
            pk.dienThoai = txtDienThoai.Text;
            pk.CCCD = txtCCCD.Text;
            pk.chuanDoan = txtChuanDoan.Text;
            pk.noiDung = txtNoiDung.Rtf;
            _pk.Add(pk);
            this.Close();
        }
        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            UpdateMaBN();
        }
    }
}