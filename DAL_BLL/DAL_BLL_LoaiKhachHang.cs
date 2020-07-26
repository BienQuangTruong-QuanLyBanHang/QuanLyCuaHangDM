using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_LoaiKhachHang
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_LoaiKhachHang()
        {

        }
        public IQueryable<LoaiKhachHang> GetLoaiKhachHangs()
        {
            return qlhh.LoaiKhachHangs.Select(t => t);
        }
        public int AddLoaiKhachHangs(string qMaLoaiKH, string qTenLoai)
        {
            LoaiKhachHang loaiKhachHangs = qlhh.LoaiKhachHangs.Where(t => t.MaLoaiKhachHang == qMaLoaiKH).FirstOrDefault();
            if (loaiKhachHangs == null)
            {
                LoaiKhachHang lkh = new LoaiKhachHang();
                lkh.MaLoaiKhachHang = qMaLoaiKH;
                lkh.TenLoaiKhachHang = qTenLoai;
                qlhh.LoaiKhachHangs.InsertOnSubmit(lkh);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeleteLoaiKhachHangs(string qMaLoaiKH)
        {
            LoaiKhachHang loaiKhachHangs = qlhh.LoaiKhachHangs.Where(t => t.MaLoaiKhachHang == qMaLoaiKH).FirstOrDefault();
            if (loaiKhachHangs != null)
            {
                qlhh.LoaiKhachHangs.DeleteOnSubmit(loaiKhachHangs);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int UpdateLoaiKhachHangs(string qMaLoaiKH, string qTenLoaiKH)
        {
            LoaiKhachHang loaiKhachHangs = qlhh.LoaiKhachHangs.Where(t => t.MaLoaiKhachHang == qMaLoaiKH).FirstOrDefault();
            if (loaiKhachHangs != null)
            {
                loaiKhachHangs.TenLoaiKhachHang = qTenLoaiKH;
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int kiemTraKhoaNgoai(string qMaLoaiKH)
        {
            KhachHang khachhangs = qlhh.KhachHangs.Where(t => t.LoaiKhachHang == qMaLoaiKH).FirstOrDefault();
            if (khachhangs == null)
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
