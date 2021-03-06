﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_SanPham
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_SanPham()
        {

        }
        public IQueryable GetSanPhams()
        {
            return (from sp in qlhh.SanPhams
                    join lsp in qlhh.LoaiSanPhams on sp.LoaiSanPham equals lsp.MaLoaiSanPham
                    join hsx in qlhh.HangSanXuats on sp.HangSanXuat equals hsx.MaHangSanXuat
                    join m in qlhh.BangMaus on sp.MaMau equals m.MaMau
                    select new
                    {
                        sp.MaSanPham,
                        sp.TenSanPham,
                        lsp.TenLoaiSanPham,
                        hsx.TenHangSanXuat,
                        sp.GiaNhap,
                        sp.GiaBan,
                        sp.TonKho,
                        m.TenMau,
                        sp.DVT,
                        sp.Image
                    });
        }
        public int AddSanPhams(string qMaSP, string qTenSP, string qLoaiSP, string qHangSX, long qGiaNhap, long qGiaBan, string qDVT, int qTonKho, string qMaMau, string qImage)
        {
            SanPham sanphams = qlhh.SanPhams.Where(t => t.MaSanPham == qMaSP).FirstOrDefault();
            if(sanphams == null)
            {
                SanPham sp = new SanPham();
                sp.MaSanPham = qMaSP;
                sp.TenSanPham = qTenSP;
                sp.LoaiSanPham = qLoaiSP;
                sp.HangSanXuat = qHangSX;
                sp.GiaNhap = qGiaNhap;
                sp.GiaBan = qGiaBan;
                sp.TonKho = qTonKho;
                sp.MaMau = qMaMau;
                sp.DVT = qDVT;
                sp.Image = qImage;
                qlhh.SanPhams.InsertOnSubmit(sp);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeleteSanPhams(string qMaSP)
        {
            SanPham sanphams = qlhh.SanPhams.Where(t => t.MaSanPham == qMaSP).FirstOrDefault();
            if (sanphams != null)
            {
                qlhh.SanPhams.DeleteOnSubmit(sanphams);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int UpdateSanPhams(string qMaSP, string qTenSP, string qLoaiSP, string qHangSX, long qGiaNhap, long qGiaBan, string qDVT, int qTonKho, string qMaMau, string qImage)
        {
            SanPham sanphams = qlhh.SanPhams.Where(t => t.MaSanPham == qMaSP).FirstOrDefault();
            if (sanphams != null)
            {
                sanphams.TenSanPham = qTenSP;
                sanphams.LoaiSanPham = qLoaiSP;
                sanphams.HangSanXuat = qHangSX;
                sanphams.GiaNhap = qGiaNhap;
                sanphams.GiaBan = qGiaBan;
                sanphams.TonKho = qTonKho;
                sanphams.Image = qImage;
                sanphams.MaMau = qMaMau;
                sanphams.DVT = qDVT;
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int kiemTraKhoaNgoai(string qMaSP)
        {
            ChiTietHoaDon chiTietHoaDons = qlhh.ChiTietHoaDons.Where(t => t.MaSanPham == qMaSP).FirstOrDefault();
            ChiTietPhieuNhap chiTietPhieuNhaps = qlhh.ChiTietPhieuNhaps.Where(t => t.MaSanPham == qMaSP).FirstOrDefault();
            if (chiTietHoaDons == null && chiTietPhieuNhaps == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int GetSoLuongTonKho(string qMaSP)
        {
            return qlhh.SanPhams.Where(t => t.MaSanPham == qMaSP).FirstOrDefault().TonKho;
        }
        public long GetGiaban(string qMaSP)
        {
            return qlhh.SanPhams.Where(t => t.MaSanPham == qMaSP).FirstOrDefault().GiaBan;
        }
        public string GetLastMaSanPhams()
        {
            SanPham sp = qlhh.SanPhams.Where(t => t.MaSanPham == "SP001").FirstOrDefault();
            if (sp == null)
            {
                return "SP001";
            }
            return qlhh.SanPhams.OrderByDescending(t => t.MaSanPham).FirstOrDefault().MaSanPham;
        }
        public string GetMaSanPhamByTen(string qTenSP)
        {
            return qlhh.SanPhams.Where(t => Equals(t.TenSanPham, qTenSP.Trim())).FirstOrDefault().MaSanPham;
        }
    }
}
