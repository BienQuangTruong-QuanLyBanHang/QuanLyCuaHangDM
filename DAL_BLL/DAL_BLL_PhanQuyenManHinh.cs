using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_PhanQuyenManHinh
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_PhanQuyenManHinh()
        {

        }
        public IQueryable<PhanQuyenManHinh> GetPhanQuyenManHinhs()
        {
            return qlhh.PhanQuyenManHinhs.Select(t => t);
        }
        public int AddPhanQuyenManHinhs(string qMaChucVu, string qMaMH, bool qCoQuyen)
        {
            PhanQuyenManHinh phanQuyenManHinhs = qlhh.PhanQuyenManHinhs.Where(t => t.MaChucVu == qMaChucVu).FirstOrDefault();
            if (phanQuyenManHinhs == null)
            {
                PhanQuyenManHinh pqmh = new PhanQuyenManHinh();
                pqmh.MaChucVu = qMaChucVu;
                pqmh.MaMH = qMaMH;
                pqmh.CoQuyen = qCoQuyen;
                qlhh.PhanQuyenManHinhs.InsertOnSubmit(pqmh);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeletePhanQuyenManHinhs(string qMaChucVu)
        {
            PhanQuyenManHinh phanQuyenManHinhs = qlhh.PhanQuyenManHinhs.Where(t => t.MaChucVu == qMaChucVu).FirstOrDefault();
            if (phanQuyenManHinhs != null)
            {
                qlhh.PhanQuyenManHinhs.DeleteOnSubmit(phanQuyenManHinhs);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int UpdatePhanQuyenManHinhs(string qMaChucVu, string qMaMH, bool qCoQuyen)
        {
            PhanQuyenManHinh phanQuyenManHinhs = qlhh.PhanQuyenManHinhs.Where(t => t.MaChucVu == qMaChucVu).FirstOrDefault();
            if (phanQuyenManHinhs != null)
            {
                phanQuyenManHinhs.MaMH = qMaMH;
                phanQuyenManHinhs.CoQuyen = qCoQuyen;
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
