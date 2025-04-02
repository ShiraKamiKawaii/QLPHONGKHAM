using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLayer;
using DevExpress.CodeParser;
using System.Data.Entity;
using DataLayer;
using QLPHONGKHAM.Report;
using DevExpress.XtraReports.UI;

namespace QLPHONGKHAM.UI
{
    public partial class UC_PhieuKham : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_PhieuKham()
        {
            InitializeComponent();
        }
        PHIEUKHAM _pk;
        string _id;
        public void Reload()
        {
            _pk = new PHIEUKHAM();
            LoadData();
        }
        private void LoadData()
        {
            gc_DanhSach.DataSource = _pk.getList();
        }
        private void ResetValue()
        {
            txtMaBN.Text = string.Empty;
            txtHoTenBN.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtMaPK.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            txtChuanDoan.Text = string.Empty;
        }
        private void UC_PhieuKham_Load(object sender, EventArgs e)
        {
            _pk = new PHIEUKHAM();
            LoadData();
        }
        private void btnAddPK_Click(object sender, EventArgs e)
        {
            frmAddPK frmAdd = new frmAddPK();
            frmAdd.FormClosed += (s, args) => LoadData();
            ResetValue();
            frmAdd.ShowDialog();
        }

        private void btnEditPK_Click(object sender, EventArgs e)
        {
            _id = gv_DanhSach.GetFocusedRowCellValue(maPK).ToString();
            var pk = _pk.getItem(int.Parse(_id));
            frmUpdatePK frmPK = new frmUpdatePK(pk);
            frmPK.FormClosed += (s, args) => Reload();
            ResetValue();
            frmPK.ShowDialog();
        }

        private void btnDelPK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _pk.Delete(int.Parse(_id));
                ResetValue();
                LoadData();
            }
        }
        private void gv_DanhSach_Click(object sender, EventArgs e)
        {
            if (gv_DanhSach.RowCount > 0)
            {
                _id = gv_DanhSach.GetFocusedRowCellValue(maPK).ToString();
                var pk = _pk.getItem(int.Parse(_id));
                txtMaPK.Text = pk.maPK.ToString();
                txtMaBN.Text = pk.maBN;
                txtHoTenBN.Text = pk.hoTenBN;
                dateNgaySinh.Value = pk.ngaySinh;
                if (pk.gioiTinh == "Nam")
                {
                    radioNam.Checked = true;

                }
                else
                {
                    radioNu.Checked = true;
                }
                txtCCCD.Text = pk.CCCD;
                txtDienThoai.Text = pk.dienThoai;
                txtDiaChi.Text = pk.diaChi;
                txtChuanDoan.Text = pk.chuanDoan;
                txtNoiDung.Rtf = pk.noiDung;
            }
        }

        private void btnInPK_Click(object sender, EventArgs e)
        {
            if (gv_DanhSach.RowCount > 0)
            {
                _id = gv_DanhSach.GetFocusedRowCellValue(maPK).ToString();
                var pk = _pk.getItem(int.Parse(_id));
                ReportPK rptPK = new ReportPK(pk);
                rptPK.ShowRibbonPreview();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu khám để in", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
