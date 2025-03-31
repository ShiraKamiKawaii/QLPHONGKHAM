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

namespace BasicDev.UI
{
    public partial class UC_TaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_TaiKhoan()
        {
            InitializeComponent();
        }
        public void Reload()
        {

        }
        private void UC_TaiKhoan_Load(object sender, EventArgs e)
        {
            gc_DanhSach.DataSource = MyClass.GetData("SELECT * FROM TaiKhoan");
        }
    }
}
