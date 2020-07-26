using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_ChiTietHoaDon
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_ChiTietHoaDon()
        {

        }
        public IQueryable<ChiTietHoaDon> GetChiTietHoaDons()
        {
            return qlhh.ChiTietHoaDons.Select(t => t);
        }
        public IQueryable<ChiTietHoaDon> GetChiTietHoaDons(string qMaHoaDon)
        {
            return qlhh.ChiTietHoaDons.Where(t => t.MaHoaDon == qMaHoaDon);
        }
        public int AddChiTietHoaDons(string MaPN, string MaSP, int soLuong, int tongTien)
        {
            ChiTietHoaDon chitiethoadons = qlhh.ChiTietHoaDons.Where(t => t.MaHoaDon == MaPN && t.MaSanPham == MaPN).FirstOrDefault();
            if (chitiethoadons == null)
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaHoaDon = MaPN;
                cthd.MaSanPham = MaSP;
                cthd.SoLuong = soLuong;
                cthd.TongTien = tongTien;
                qlhh.ChiTietHoaDons.InsertOnSubmit(cthd);
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
