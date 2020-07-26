using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_LoaiSanPham
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_LoaiSanPham()
        {

        }
        public IQueryable<LoaiSanPham> GetLoaiSanPhams()
        {
            return qlhh.LoaiSanPhams.Select(t => t);
        }
        public int AddLoaiSanPhams(string qMaLoaiSP, string qTenLoai)
        {
            LoaiSanPham loaiSanPhams = qlhh.LoaiSanPhams.Where(t => t.MaLoaiSanPham == qMaLoaiSP).FirstOrDefault();
            if (loaiSanPhams == null)
            {
                LoaiSanPham lsp = new LoaiSanPham();
                lsp.MaLoaiSanPham = qMaLoaiSP;
                lsp.TenLoaiSanPham = qTenLoai;
                qlhh.LoaiSanPhams.InsertOnSubmit(lsp);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeleteLoaiSanPhams(string qMaLoaiSP)
        {
            LoaiSanPham loaiSanPhams = qlhh.LoaiSanPhams.Where(t => t.MaLoaiSanPham == qMaLoaiSP).FirstOrDefault();
            if (loaiSanPhams != null)
            {
                qlhh.LoaiSanPhams.DeleteOnSubmit(loaiSanPhams);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int UpdateLoaiSanPhams(string qMaLoaiSP, string qTenLoaiSP)
        {
            LoaiSanPham loaiSanPhams = qlhh.LoaiSanPhams.Where(t => t.MaLoaiSanPham == qMaLoaiSP).FirstOrDefault();
            if (loaiSanPhams != null)
            {
                loaiSanPhams.TenLoaiSanPham = qTenLoaiSP;
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int kiemTraKhoaNgoai(string qMaLoaiSP)
        {
            SanPham sanphams = qlhh.SanPhams.Where(t => t.LoaiSanPham == qMaLoaiSP).FirstOrDefault();
            if (sanphams == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
