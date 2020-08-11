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
        public List<PhanQuyenManHinh> GetPhanQuyenManHinhs(string qMaCV)
        {
            var ls = (from mh in qlhh.ManHinhs
                      join pqmh in qlhh.PhanQuyenManHinhs on mh.MaMH equals pqmh.MaMH into gj
                      from cq in gj.DefaultIfEmpty().Where(t => t.MaChucVu == qMaCV).DefaultIfEmpty()
                      select new
                      {
                          mh.MaMH,
                          mh.TenMH,
                          cq.CoQuyen
                      });

            var kq = ls.ToList().ConvertAll(l => new PhanQuyenManHinh()
            {
                MaMH = l.MaMH,
                TenMH = l.TenMH,
                CoQuyen = l.CoQuyen
            });
            return kq;
        }
        public List<PhanQuyenManHinh> GetManHinhs(string qMaCV, bool qCoQuyen)
        {
            return qlhh.PhanQuyenManHinhs.Where(t => t.MaChucVu == qMaCV && t.CoQuyen == qCoQuyen).ToList();
        }
        public int AddPhanQuyenManHinhs(string qMaChucVu, string qMaMH, bool qCoQuyen)
        {
            try
            {
                PhanQuyenManHinh pqmh = new PhanQuyenManHinh();
                pqmh.MaChucVu = qMaChucVu;
                pqmh.MaMH = qMaMH;
                pqmh.CoQuyen = qCoQuyen;
                qlhh.PhanQuyenManHinhs.InsertOnSubmit(pqmh);
                qlhh.SubmitChanges();
                return 1;
            }
            catch
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
        public void clearData(string qMaChucVu)
        {
            var pq = from p in qlhh.PhanQuyenManHinhs where p.MaChucVu == qMaChucVu select p;
            qlhh.PhanQuyenManHinhs.DeleteAllOnSubmit(pq);
            qlhh.SubmitChanges();
        }
    }
}
