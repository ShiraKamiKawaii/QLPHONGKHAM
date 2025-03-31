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
            _bn = new BENHNHAN();
            BenhNhan bn = new BenhNhan();
            bn.maBN = $"BN{txtsoCCCD.Text}";
            bn.hoTenBN = txthoTenBN.Text;
            bn.ngaySinh = dateNgaySinh.Value;
            if (radioNam.Checked == true)
            {
                bn.gioiTinh = "Nam";
            }
            else
            {
                bn.gioiTinh = "Nữ";
            }
            bn.diaChi = txtdiaChi.Text;
            bn.dienThoai = txtdienThoai.Text;
            bn.CCCD = txtsoCCCD.Text;
            _bn.Add(bn);
            this.Close();
        }
    }
}