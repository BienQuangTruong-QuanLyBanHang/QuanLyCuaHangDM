using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_NhaPhanPhoi
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_NhaPhanPhoi()
        {

        }
        public IQueryable<NhaPhanPhoi> GetPhanPhois()
        {
            return qlhh.NhaPhanPhois.Select(t => t);
        }
        public int AddNhaPhanPhois(string qMaNPP, string qTenNPP, string qDiaChi, string qDienThoai, string qEmail)
        {
            NhaPhanPhoi nhaPhanPhois = qlhh.NhaPhanPhois.Where(t => t.MaNhaPhanPhoi == qMaNPP).FirstOrDefault();
            if (nhaPhanPhois == null)
            {
                NhaPhanPhoi npp = new NhaPhanPhoi();
                npp.MaNhaPhanPhoi = qMaNPP;
                npp.TenNhaPhanPhoi = qTenNPP;
                npp.DiaChi = qDiaChi;
                npp.SDT = qDienThoai;
                npp.Email = qEmail;
                qlhh.NhaPhanPhois.InsertOnSubmit(npp);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeleteNhaPhanPhois(string qMaNPP)
        {
            NhaPhanPhoi nhaPhanPhois = qlhh.NhaPhanPhois.Where(t => t.MaNhaPhanPhoi == qMaNPP).FirstOrDefault();
            if (nhaPhanPhois != null)
            {
                qlhh.NhaPhanPhois.DeleteOnSubmit(nhaPhanPhois);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int UpdateNhaPhanPhois(string qMaNPP, string qTenNPP, string qDiaChi, string qDienThoai, string qEmail)
        {
            NhaPhanPhoi nhaPhanPhois = qlhh.NhaPhanPhois.Where(t => t.MaNhaPhanPhoi == qMaNPP).FirstOrDefault();
            if (nhaPhanPhois != null)
            {
                nhaPhanPhois.TenNhaPhanPhoi = qTenNPP;
                nhaPhanPhois.DiaChi = qDiaChi;
                nhaPhanPhois.SDT = qDienThoai;
                nhaPhanPhois.Email = qEmail;
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int KiemTraKhoaNgoai(string qMaNPP)
        {
            PhieuNhap phieunhaps = qlhh.PhieuNhaps.Where(t => t.MaNhaPhanPhoi == qMaNPP).FirstOrDefault();
            if (phieunhaps == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string GetLastMaNhaPhanPhois()
        {
            NhaPhanPhoi npp = qlhh.NhaPhanPhois.Where(t => t.MaNhaPhanPhoi == "NPP001").FirstOrDefault();
            if (npp == null)
            {
                return "NPP001";
            }
            return qlhh.NhaPhanPhois.OrderByDescending(t => t.MaNhaPhanPhoi).FirstOrDefault().MaNhaPhanPhoi;
        }
    }
}
