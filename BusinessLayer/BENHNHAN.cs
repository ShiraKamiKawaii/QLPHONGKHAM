using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class BENHNHAN
    {
        qlPhongKhamDongYEntities db = new qlPhongKhamDongYEntities();
        public List<BenhNhan> getList()
        {
            return db.BenhNhan.ToList();
        }
        public BenhNhan getItem(string maBN)
        {
            return db.BenhNhan.FirstOrDefault(x=>x.maBN==maBN);
        }
        public BenhNhan Add(BenhNhan bn)
        {

                db.BenhNhan.Add(bn);
                db.SaveChanges();
                return bn;

        }
        public BenhNhan Update(BenhNhan bn)
        {
            try
            {
                var _bn = db.BenhNhan.FirstOrDefault(x=>x.maBN==bn.maBN);
                _bn.hoTenBN = bn.hoTenBN;
                _bn.diaChi = bn.diaChi;
                _bn.ngaySinh = bn.ngaySinh;
                _bn.gioiTinh = bn.gioiTinh;
                _bn.CCCD = bn.CCCD;
                _bn.dienThoai = bn.dienThoai;
                db.SaveChanges();
                return bn;
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }
        public void Delete(string maBN)
        {
            try
            {
                var _bn = db.BenhNhan.FirstOrDefault(x => x.maBN == maBN);
                var _pk = db.PhieuKhams.Where(x => x.maBN == maBN);
                db.PhieuKhams.RemoveRange(_pk);
                db.BenhNhan.Remove(_bn);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }
    }
}
