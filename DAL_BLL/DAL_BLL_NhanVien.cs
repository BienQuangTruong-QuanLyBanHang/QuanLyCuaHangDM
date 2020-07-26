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
        public DAL_BLL_NhanVien()
        {

        }
        public IQueryable<NhanVien> GetNhanViens()
        {
            return qlhh.NhanViens.Select(t => t);
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
    }
}
