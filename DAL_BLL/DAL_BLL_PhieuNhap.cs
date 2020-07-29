using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_PhieuNhap
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_PhieuNhap()
        {

        }
        public IQueryable<PhieuNhap> GetPhieuNhaps()
        {
            return qlhh.PhieuNhaps.Select(t => t);
        }
        public int AddPhieuNhaps(string qMaPN, string qMaNV, string qMaNPP, long qTongTien, DateTime qNgayNhap)
        {
            PhieuNhap phieuNhaps = qlhh.PhieuNhaps.Where(t => t.MaPhieuNhap == qMaPN).FirstOrDefault();
            if (phieuNhaps == null)
            {
                PhieuNhap pn = new PhieuNhap();
                pn.MaPhieuNhap = qMaPN;
                pn.MaNhanVien = qMaNV;
                pn.MaNhaPhanPhoi = qMaNPP;
                pn.TongTien = qTongTien;
                pn.NgayNhap = qNgayNhap;
                qlhh.PhieuNhaps.InsertOnSubmit(pn);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string GetLastMaPhieuNhaps()
        {
            PhieuNhap pn = qlhh.PhieuNhaps.Where(t => t.MaPhieuNhap == "PN001").FirstOrDefault();
            if (pn == null)
            {
                return "PN001";
            }
            return qlhh.PhieuNhaps.OrderByDescending(t => t.MaPhieuNhap).FirstOrDefault().MaPhieuNhap;
        }
    }
}
