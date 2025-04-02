using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TAIKHOAN
    {
        qlPhongKhamDongYEntities db = new qlPhongKhamDongYEntities();
        public List<TaiKhoan> getList()
        {
            return db.TaiKhoan.ToList();
        }
        public TaiKhoan getItem(int ID)
        {
            return db.TaiKhoan.FirstOrDefault(x => x.ID == ID);
        }
        public TaiKhoan Add(TaiKhoan tk)
        {

            db.TaiKhoan.Add(tk);
            db.SaveChanges();
            return tk;

        }
        public TaiKhoan Update(TaiKhoan tk)
        {
            try
            {
                var _tk = db.TaiKhoan.FirstOrDefault(x => x.ID == tk.ID);
                _tk.ID = tk.ID;
                _tk.hoTen = tk.hoTen;
                _tk.matKhau = tk.matKhau;
                _tk.role = tk.role;
                db.SaveChanges();
                return tk;
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }
        public void Delete(int ID)
        {
            try
            {
                var _tk = db.TaiKhoan.FirstOrDefault(x => x.ID == ID);
                db.TaiKhoan.Remove(_tk);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }
        public  TaiKhoan CheckLogin (TaiKhoan tk)
        {
            var _tk = db.TaiKhoan.FirstOrDefault(x => x.taiKhoan == tk.taiKhoan && x.matKhau == tk.matKhau);
            return _tk;
        }
    }
}
