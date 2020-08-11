using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_ChiTietPhieuNhap
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_ChiTietPhieuNhap()
        {

        }
        public IQueryable GetChiTietPhieuNhaps()
        {
            return qlhh.ChiTietPhieuNhaps.Select(t => t);
        }
        public IQueryable GetChiTietPhieuNhaps(string qMaPN)
        {
            return (from ctpn in qlhh.ChiTietPhieuNhaps
                    join sp in qlhh.SanPhams on ctpn.MaSanPham equals sp.MaSanPham
                    where ctpn.MaPhieuNhap == qMaPN
                    select new
                    {
                        ctpn.MaPhieuNhap,
                        ctpn.MaSanPham,
                        sp.TenSanPham,
                        ctpn.SoLuong,
                        ctpn.GiaNhap,
                        ctpn.TongTien
                    });
        }
        public int AddChiTietPhieuNhaps(string MaPN, string MaSP, int soLuong, int gianhap, int tongTien)
        {
            ChiTietPhieuNhap chiietphieunhaps = qlhh.ChiTietPhieuNhaps.Where(t => t.MaPhieuNhap == MaPN && t.MaSanPham == MaPN).FirstOrDefault();
            if(chiietphieunhaps == null)
            {
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                ctpn.MaPhieuNhap = MaPN;
                ctpn.MaSanPham = MaSP;
                ctpn.SoLuong = soLuong;
                ctpn.GiaNhap = gianhap;
                ctpn.TongTien = tongTien;
                qlhh.ChiTietPhieuNhaps.InsertOnSubmit(ctpn);
                qlhh.SubmitChanges();

                UpdateGiaNhap(MaSP, gianhap);
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void UpdateGiaNhap(string MaSP, int GiaNhap)
        {
            SanPham sp = qlhh.SanPhams.Where(t => t.MaSanPham == MaSP).FirstOrDefault();
            if(sp != null)
            {
                sp.GiaNhap = GiaNhap;
            }
            qlhh.SubmitChanges();
        }
    }
}
