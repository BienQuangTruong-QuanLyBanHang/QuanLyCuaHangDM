using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_KhachHang
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_KhachHang()
        {

        }
        public IQueryable<KhachHang> GetKhachHangs()
        {
            return qlhh.KhachHangs.Select(t => t);
        }
        public int addKhachHang(string maKH, string tenKH, DateTime NgaySinh, string gioiTinh, string diaChi, string loaiKH)
        {
            KhachHang kh = qlhh.KhachHangs.Where(t => t.MaKhachHang == maKH).FirstOrDefault();
            if(kh == null)
            {
                KhachHang kh1 = new KhachHang();
                kh1.MaKhachHang = maKH;
                kh1.TenKhachHang = tenKH;
                kh1.NgaySinh = NgaySinh;
                kh1.GioiTinh = gioiTinh;
                kh1.DiaChi = diaChi;
                kh1.LoaiKhachHang = loaiKH;
                qlhh.KhachHangs.InsertOnSubmit(kh1);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int updateKhachHang(string maKH, string tenKH, DateTime NgaySinh, string gioiTinh, string diaChi, string loaiKH)
        {
            KhachHang kh = qlhh.KhachHangs.Where(t => t.MaKhachHang == maKH).FirstOrDefault();
            if (kh != null)
            {
                kh.TenKhachHang = tenKH;
                kh.NgaySinh = NgaySinh;
                kh.GioiTinh = gioiTinh;
                kh.DiaChi = diaChi;
                kh.LoaiKhachHang = loaiKH;
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int deleteKhachHang(string maKH)
        {
            KhachHang kh = qlhh.KhachHangs.Where(t => t.MaKhachHang == maKH).FirstOrDefault();
            if (kh != null)
            {
                qlhh.KhachHangs.DeleteOnSubmit(kh);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int kiemTraKhoaNgoai(string qMaKH)
        {
            HoaDon hoadons = qlhh.HoaDons.Where(t => t.MaKhachHang == qMaKH).FirstOrDefault();
            if (hoadons == null)
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
