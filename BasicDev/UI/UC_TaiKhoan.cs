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
using QLPHONGKHAM.UI;

namespace BasicDev.UI
{
    public partial class UC_TaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_TaiKhoan()
        {
            InitializeComponent();
        }
        TAIKHOAN _tk;
        string _id;
        public void Reload()
        {
            LoadData();
        }
        private void LoadData()
        {
            gc_DanhSach.DataSource = _tk.getList();
        }
        private void UC_TaiKhoan_Load(object sender, EventArgs e)
        {
            _tk = new TAIKHOAN();
            LoadData();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            _tk = new TAIKHOAN();
            frmAddTK frmAdd = new frmAddTK();
            frmAdd.FormClosed += (s, args) => LoadData();
            frmAdd.ShowDialog();
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            _id = gv_DanhSach.GetFocusedRowCellValue(ID).ToString();
            var tk = _tk.getItem(int.Parse(_id));
            frmUpdateTK frmTk = new frmUpdateTK(tk);
            frmTk.FormClosed += (s, args) => Reload();
            frmTk.ShowDialog();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tk.Delete(int.Parse(_id));
                LoadData();
            }
        }

        private void gv_DanhSach_Click(object sender, EventArgs e)
        {
            if (gv_DanhSach.RowCount > 0)
            {
                _id = gv_DanhSach.GetFocusedRowCellValue(ID).ToString();
                var tk = _tk.getItem(int.Parse(_id));
            }
        }
    }
}
