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
            return db.TaiKhoans.ToList();
        }
        public TaiKhoan getItem(string ID)
        {
            return db.TaiKhoans.FirstOrDefault(x => x.ID == ID);
        }
        public TaiKhoan Add(TaiKhoan tk)
        {

            db.TaiKhoans.Add(tk);
            db.SaveChanges();
            return tk;

        }
        public TaiKhoan Update(TaiKhoan tk)
        {
            try
            {
                var _tk = db.TaiKhoans.FirstOrDefault(x => x.ID == tk.ID);
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
        public void Delete(string ID)
        {
            try
            {
                var _tk = db.TaiKhoans.FirstOrDefault(x => x.ID == ID);
                db.TaiKhoans.Remove(_tk);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }
        public bool CheckLogin(TaiKhoan tk)
        {
            var _tk = db.TaiKhoans.FirstOrDefault(x=>x.ID==tk.ID && x.matKhau==tk.matKhau);
            return _tk != null;
        }
    }
}
