using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using DevExpress.Mvvm;
using QLPHONGKHAM.UI;

namespace BasicDev.UI
{
    public partial class UC_BenhNhan : UserControl
    {

        public UC_BenhNhan()
        {
            InitializeComponent();
        }
        BENHNHAN _bn;
        string _id;
        private void ResetValue()
        {
            txtMaBN.Text = string.Empty;
            txtHoTenBN.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtCCCD.Text = string.Empty;
        }
        public void Reload()
        {
            _bn = new BENHNHAN();
            LoadData();
        }
        private void LoadData()
        {
            gc_DanhSach.DataSource = _bn.getList();
        }
        private void UC_BenhNhan_Load(object sender, EventArgs e)
        {
            _bn = new BENHNHAN();
            LoadData();
        }
        private void btnAddBN_Click(object sender, EventArgs e)
        {
            _bn = new BENHNHAN();
            frmAddBN frmAdd = new frmAddBN();
            frmAdd.FormClosed += (s, args) => LoadData();
            ResetValue();
            frmAdd.ShowDialog();
        }
        private void btnDelBN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _bn.Delete(_id);
                ResetValue();
                LoadData();
            }
        }
        private void gv_DanhSach_Click(object sender, EventArgs e)
        {
            if (gv_DanhSach.RowCount > 0)
            {
                _id = gv_DanhSach.GetFocusedRowCellValue(maBN).ToString();
                var bn = _bn.getItem(_id);
                txtMaBN.Text = bn.maBN;
                txtHoTenBN.Text = bn.hoTenBN;
                dateNgaySinh.Value = bn.ngaySinh;
                if (bn.gioiTinh == "Nam")
                {
                    radioNam.Checked = true;

                }
                else
                {
                    radioNu.Checked = true;
                }
                txtCCCD.Text = bn.CCCD;
                txtDienThoai.Text = bn.dienThoai;
                txtDiaChi.Text = bn.diaChi;
            }
        }
        private void btnEditBN_Click(object sender, EventArgs e)
        {
            _id = gv_DanhSach.GetFocusedRowCellValue(maBN).ToString();
            var bn = _bn.getItem(_id);
            frmUpdateBN frmBN = new frmUpdateBN(bn);
            if (frmBN.ShowDialog() == DialogResult.OK)
            {
                Reload();
            }
            ResetValue();
        }
    }
}
