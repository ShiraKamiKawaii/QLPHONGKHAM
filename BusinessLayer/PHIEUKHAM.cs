using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PHIEUKHAM
    {
        qlPhongKhamDongYEntities db = new qlPhongKhamDongYEntities();
        public List<PhieuKham> getList()
        {
            return db.PhieuKhams.ToList();
        }
        public PhieuKham getItem(string maPK)
        {
            return db.PhieuKhams.FirstOrDefault(x => x.maPK == maPK);
        }
        public PhieuKham Add(PhieuKham pk)
        {

            db.PhieuKhams.Add(pk);
            db.SaveChanges();
            return pk;

        }
        public PhieuKham Update(PhieuKham pk)
        {
            try
            {
                var _pk = db.PhieuKhams.FirstOrDefault(x => x.maPK == pk.maPK);
                _pk.maBN = pk.maBN;
                _pk.hoTenBN = pk.hoTenBN;
                _pk.diaChi = pk.diaChi;
                _pk.ngaySinh = pk.ngaySinh;
                _pk.gioiTinh = pk.gioiTinh;
                _pk.CCCD = pk.CCCD;
                _pk.dienThoai = pk.dienThoai;
                _pk.chuanDoan = pk.chuanDoan;
                _pk.noiDung = pk.noiDung;
                db.SaveChanges();
                return pk;
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }
        public void Delete(string maPK)
        {
            try
            {
                var _pk = db.PhieuKhams.FirstOrDefault(x => x.maPK == maPK);
                db.PhieuKhams.Remove(_pk);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }
        public void Check(string maBN)
        {
            var _checkbn = db.BenhNhan.FirstOrDefault(x => x.maBN == maBN);
            if (_checkbn==null)
            {
                BENHNHAN _bn = new BENHNHAN();
            }
        }
        
    }
}
