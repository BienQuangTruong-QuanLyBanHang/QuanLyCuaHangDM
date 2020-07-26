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
        public IQueryable<ChiTietPhieuNhap> GetChiTietPhieuNhaps()
        {
            return qlhh.ChiTietPhieuNhaps.Select(t => t);
        }
        public int AddChiTietPhieuNhaps(string MaPN, string MaSP, int soLuong, int tongTien)
        {
            ChiTietPhieuNhap chiietphieunhaps = qlhh.ChiTietPhieuNhaps.Where(t => t.MaPhieuNhap == MaPN && t.MaSanPham == MaPN).FirstOrDefault();
            if(chiietphieunhaps == null)
            {
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                ctpn.MaPhieuNhap = MaPN;
                ctpn.MaSanPham = MaSP;
                ctpn.SoLuong = soLuong;
                ctpn.TongTien = tongTien;
                qlhh.ChiTietPhieuNhaps.InsertOnSubmit(ctpn);
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
