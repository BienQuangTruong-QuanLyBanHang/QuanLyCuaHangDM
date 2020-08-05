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
        public IQueryable GetPhanQuyenManHinhs()
        {
            return qlhh.PhanQuyenManHinhs.Select(t => t);
        }
        public IQueryable GetPhanQuyenManHinhs(string qMaCV)
        {
            return (from mh in qlhh.ManHinhs
                    join pqmh in qlhh.PhanQuyenManHinhs on mh.MaMH equals pqmh.MaMH into gj
                    from cq in gj.DefaultIfEmpty().Where(t => t.MaChucVu == qMaCV).DefaultIfEmpty()
                    select new
                    {
                        mh.MaMH,
                        mh.TenMH,
                        cq.CoQuyen
                    });
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
        public int DeletePhanQuyenManHinhs(string qMaChucVu, string qMaMH)
        {
            PhanQuyenManHinh phanQuyenManHinhs = qlhh.PhanQuyenManHinhs.Where(t => t.MaChucVu == qMaChucVu && t.MaMH == qMaMH).FirstOrDefault();
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
                phanQuyenManHinhs.CoQuyen = qCoQuyen;
                qlhh.SubmitChanges();
                return 1;
            }
            else if (phanQuyenManHinhs == null)
            {
                AddPhanQuyenManHinhs(qMaChucVu, qMaMH, qCoQuyen);
                return 1;
            }
            return 0;
        }
    }
}
