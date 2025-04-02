using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DataLayer;

namespace QLPHONGKHAM.Report
{
	public partial class ReportPK : DevExpress.XtraReports.UI.XtraReport
	{	
		public ReportPK()
		{
			InitializeComponent();
		}
        public ReportPK(PhieuKham pk)
        {
            InitializeComponent();
			lblNoiDung.Rtf = pk.noiDung;
			lblHoTen.Text = pk.hoTenBN;
			lblDiaChi.Text = pk.diaChi;
			lblChuanDoan.Text = pk.chuanDoan;
			lblDienThoai.Text = pk.dienThoai;
			lblMaPK.Text = pk.maPK.ToString();
			lblMaBN.Text = pk.maBN;
			lblNgaySinh.Text = pk.ngaySinh.Date.ToString("dd/MM/yyyy");
			lblGioiTinh.Text = pk.gioiTinh;
			lblNgayLap.Text = $"Hà Nội, ngày {pk.ngayLap.Day} tháng {pk.ngayLap.Month} năm {pk.ngayLap.Year}";
        }
    }
}
