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
using DevExpress.Mvvm.Native;
using DevExpress.Utils.Extensions;
using BusinessLayer;
using DataLayer;

namespace BasicDev.UI
{
    public partial class frmUpdateBN : DevExpress.XtraEditors.XtraForm
    {

        public frmUpdateBN(BenhNhan bn)
        {
            InitializeComponent();
            txthoTenBN.Text = bn.hoTenBN;
            dateNgaySinh.Value = bn.ngaySinh;
            if (bn.gioiTinh == "Nam")
            {
                radioNam.Checked = true;

            }
            else
            {
                radioNu.Checked = true;
            }
            txtsoCCCD.Text = bn.CCCD;
            txtdienThoai.Text = bn.dienThoai;
            txtdiaChi.Text = bn.diaChi;
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
            _bn.Update(bn);
            this.Close();
        }
    }
}