using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_HoaDon
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_HoaDon() { }
        public IQueryable<HoaDon> GetHoaDons()
        {
            return qlhh.HoaDons.Select(t => t);
        }
        public IQueryable<HoaDon> GetHoaDons(string qMaHD)
        {
            return qlhh.HoaDons.Where(t => t.MaHoaDon == qMaHD);
        }
        public int addHoaDon(string maHD, string maKH, string maNV, DateTime ngayLap, int tongTien)
        {
            HoaDon hd = qlhh.HoaDons.Where(t => t.MaHoaDon == maHD).FirstOrDefault();
            if(hd == null)
            {
                HoaDon hd1 = new HoaDon();
                hd1.MaHoaDon = maHD;
                hd1.MaKhachHang = maKH;
                hd1.MaNhanVien = maNV;
                hd1.NgayLapHoaDon = ngayLap;
                hd1.TongTien = tongTien;
                qlhh.HoaDons.InsertOnSubmit(hd1);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string GetLastHoaDons()
        {
            return qlhh.HoaDons.OrderByDescending(t => t.MaHoaDon).FirstOrDefault().MaHoaDon;
        }
    }
}
