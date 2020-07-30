using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_NhanVien
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public NhanVien NhanVien1 { get; set; }
        public DAL_BLL_NhanVien()
        {

        }
        public IQueryable GetNhanViens()
        {
            //return qlhh.NhanViens.Select(t => t);
            //return (from nv in qlhh.NhanViens
            //        join cv in qlhh.ChucVus on nv.ChucVu equals cv.MaChucVu
            //        select new
            //        {
            //            nv.MaNhanVien,
            //            nv.TenNhanVien,
            //            nv.NgaySinh,
            //            nv.GioiTinh,
            //            nv.NgayVaoLam,
            //            cv.TenChucVu,
            //            nv.DiaChi,
            //            nv.SDT
            //        });
            return qlhh.NhanViens.Join(qlhh.ChucVus, nv => nv.ChucVu, cv => cv.MaChucVu, (nv, cv) => new {
                nv.MaNhanVien,
                nv.TenNhanVien,
                nv.NgaySinh,
                nv.GioiTinh,
                nv.NgayVaoLam,
                cv.TenChucVu,
                nv.DiaChi,
                nv.SDT
            });
        }
        public int AddNhanViens(string qMaNV, string qTenNV, DateTime qNgaySinh, string qGioiTinh, DateTime qNgayVaoLam, string qChucVu, string qDiaChi, string qDienThoai)
        {
            NhanVien nhanViens = qlhh.NhanViens.Where(t => t.MaNhanVien == qMaNV).FirstOrDefault();
            if (nhanViens == null)
            {
                NhanVien nv = new NhanVien();
                nv.MaNhanVien = qMaNV;
                nv.TenNhanVien = qTenNV;
                nv.NgaySinh = qNgaySinh;
                nv.GioiTinh = qGioiTinh;
                nv.NgayVaoLam = qNgayVaoLam;
                nv.ChucVu = qChucVu;
                nv.DiaChi = qDiaChi;
                nv.SDT = qDienThoai;
                qlhh.NhanViens.InsertOnSubmit(nv);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeleteNhanViens(string qMaNV)
        {
            NhanVien nhanViens = qlhh.NhanViens.Where(t => t.MaNhanVien == qMaNV).FirstOrDefault();
            if (nhanViens != null)
            {
                qlhh.NhanViens.DeleteOnSubmit(nhanViens);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int UpdateNhanViens(string qMaNV, string qTenNV, DateTime qNgaySinh, string qGioiTinh, string qChucVu, string qDiaChi, string qDienThoai)
        {
            NhanVien nhanViens = qlhh.NhanViens.Where(t => t.MaNhanVien == qMaNV).FirstOrDefault();
            if (nhanViens != null)
            {
                nhanViens.TenNhanVien = qTenNV;
                nhanViens.NgaySinh = qNgaySinh;
                nhanViens.GioiTinh = qGioiTinh;
                nhanViens.ChucVu = qChucVu;
                nhanViens.DiaChi = qDiaChi;
                nhanViens.SDT = qDienThoai;
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int kiemTraKhoaNgoai(string qMaNV)
        {
            HoaDon hoadons = qlhh.HoaDons.Where(t => t.MaNhanVien == qMaNV).FirstOrDefault();
            PhieuNhap phieunhaps = qlhh.PhieuNhaps.Where(t => t.MaNhanVien == qMaNV).FirstOrDefault();
            if (hoadons == null && phieunhaps == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string GetTenNhanVien(string qId)
        {
            return qlhh.NhanViens.Where(t => t.MaNhanVien == qId).FirstOrDefault().TenNhanVien;
        }
        public string GetLastMaNhanViens()
        {
            NhanVien nv = qlhh.NhanViens.Where(t => t.MaNhanVien == "NV001").FirstOrDefault();
            if (nv == null)
            {
                return "NV001";
            }
            return qlhh.NhanViens.OrderByDescending(t => t.MaNhanVien).FirstOrDefault().MaNhanVien;
        }
    }
}
