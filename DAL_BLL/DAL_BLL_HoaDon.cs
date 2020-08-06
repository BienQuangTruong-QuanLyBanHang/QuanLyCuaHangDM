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
        private string maHD;
        List<HoaDon> lstHD = new List<HoaDon>();
        

        public string MaHD { get => maHD; set => maHD = value; }

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
            HoaDon hd = qlhh.HoaDons.Where(t => t.MaHoaDon == "HD001").FirstOrDefault();
            if(hd == null)
            {
                return "HD001";
            }
            return qlhh.HoaDons.OrderByDescending(t => t.MaHoaDon).FirstOrDefault().MaHoaDon;
        }
        public List<HoaDon> InHoaDon()
        {
            var lst = (from hd in qlhh.HoaDons
                    join cthd in qlhh.ChiTietHoaDons on hd.MaHoaDon equals cthd.MaHoaDon
                    join sp in qlhh.SanPhams on cthd.MaSanPham equals sp.MaSanPham
                    join nv in qlhh.NhanViens on hd.MaNhanVien equals nv.MaNhanVien
                    join kh in qlhh.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                    where hd.MaHoaDon == MaHD
                       select new
                      {
                          hd.MaHoaDon,
                          hd.MaKhachHang,
                          hd.NgayLapHoaDon,
                          cthd.SoLuong,
                          cthd.TongTien,
                          sp.TenSanPham,
                          sp.DVT,
                          sp.GiaBan,
                          nv.TenNhanVien,
                          kh.TenKhachHang,
                          kh.DiaChi
                      });
            var kq = lst.ToList().ConvertAll(l => new HoaDon()
            {
                MaHoaDon = l.MaHoaDon,
                MaKhachHang = l.MaKhachHang,
                NgayLapHoaDon = l.NgayLapHoaDon,
                SoLuong = l.SoLuong,
                TongTien = l.TongTien,
                TenSP = l.TenSanPham,
                DVT = l.DVT,
                GiaBan = Convert.ToInt32(l.GiaBan),
                TenNV = l.TenNhanVien,
                TenKH = l.TenKhachHang,
                DiaChi = l.DiaChi
            });
            return kq;
        }
        public List<HoaDon> InDanhSachHoaDon()
        {
            var lst = (from hd in qlhh.HoaDons
                       join cthd in qlhh.ChiTietHoaDons on hd.MaHoaDon equals cthd.MaHoaDon
                       join sp in qlhh.SanPhams on cthd.MaSanPham equals sp.MaSanPham
                       join nv in qlhh.NhanViens on hd.MaNhanVien equals nv.MaNhanVien
                       join kh in qlhh.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                       select new
                       {
                           hd.MaHoaDon,
                           hd.MaKhachHang,
                           hd.NgayLapHoaDon,
                           hd.TongTien,
                           cthd.SoLuong,
                           sp.TenSanPham,
                           sp.DVT,
                           sp.GiaBan,
                           nv.TenNhanVien,
                           kh.TenKhachHang,
                           kh.DiaChi
                       });
            var kq = lst.ToList().ConvertAll(l => new HoaDon()
            {
                MaHoaDon = l.MaHoaDon,
                MaKhachHang = l.MaKhachHang,
                NgayLapHoaDon = l.NgayLapHoaDon,
                SoLuong = l.SoLuong,
                TongTien = l.TongTien,
                TenSP = l.TenSanPham,
                DVT = l.DVT,
                GiaBan = Convert.ToInt32(l.GiaBan),
                TenNV = l.TenNhanVien,
                TenKH = l.TenKhachHang,
                DiaChi = l.DiaChi
            });
            return kq;
        }
    }
}
