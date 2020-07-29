using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_ChucVu
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_ChucVu()
        {

        }
        public IQueryable<ChucVu> GetChucVus()
        {
            return qlhh.ChucVus.Select(t => t);
        }
        public IQueryable<ChucVu> GetChucVus(string qMaChucVu)
        {
            return qlhh.ChucVus.Where(t => t.MaChucVu == qMaChucVu);
        }
        public int addChucVu(string maChuVu, string tenChucVu)
        {
            ChucVu cv = qlhh.ChucVus.Where(t => t.MaChucVu == maChuVu).FirstOrDefault();
            if(cv == null)
            {
                ChucVu cv1 = new ChucVu();
                cv1.MaChucVu = maChuVu;
                cv1.TenChucVu = tenChucVu;
                qlhh.ChucVus.InsertOnSubmit(cv1);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int updateChucVu(string maChuVu, string tenChucVu)
        {
            ChucVu cv = qlhh.ChucVus.Where(t => t.MaChucVu == maChuVu).FirstOrDefault();
            if(cv != null)
            {
                cv.TenChucVu = tenChucVu;
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int deleteChucVu(string maChucVu)
        {
            ChucVu cv = qlhh.ChucVus.Where(t => t.MaChucVu == maChucVu).FirstOrDefault();
            if (cv != null)
            {
                qlhh.ChucVus.DeleteOnSubmit(cv);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string GetLastMaChucVus()
        {
            ChucVu cv = qlhh.ChucVus.Where(t => t.MaChucVu == "CV001").FirstOrDefault();
            if (cv == null)
            {
                return "CV001";
            }
            return qlhh.ChucVus.OrderByDescending(t => t.MaChucVu).FirstOrDefault().MaChucVu;
        }
    }
}
