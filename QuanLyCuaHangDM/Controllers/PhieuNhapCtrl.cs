using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Controllers
{
    class PhieuNhapCtrl
    {
        public static DataSet FillDataSet_getPhieuNhapByMaPhieuNhap(string _MaPhieuNhap)
        {
            try
            {
                Models.PhieuNhapModel pn = new Models.PhieuNhapModel(_MaPhieuNhap);
                return pn.FillDataSet_getPhieuNhapByMaPhieuNhap();
            }
            catch { return null; }
        }
        public static int InsertPhieuNhap(string _MaPhieuNhap, string _MaNhanVien, string _MaNhaPhanPhoi, int _TongTien, DateTime _NgayNhap, string _TinhTrang)
        {
            try
            {
                Models.PhieuNhapModel _pn = new Models.PhieuNhapModel(_MaPhieuNhap, _MaNhanVien, _MaNhaPhanPhoi, _TongTien, _NgayNhap, _TinhTrang);
                return _pn.InsertPhieuNhap();
            }
            catch { return 0; }
        }
        public static int UpdatePhieuNhap(string _MaPhieuNhap, string _MaNhanVien, string _MaNhaPhanPhoi, int _TongTien, DateTime _NgayNhap, string _TinhTrang)
        {
            try
            {
                Models.PhieuNhapModel _pn = new Models.PhieuNhapModel(_MaPhieuNhap, _MaNhanVien, _MaNhaPhanPhoi, _TongTien, _NgayNhap, _TinhTrang);
                return _pn.UpdatePhieuNhap();
            }
            catch { return 0; }
        }
        public static int UpdateTinhTrangPhieuNhap(string _MaPhieuNhap)
        {
            try
            {
                Models.PhieuNhapModel _pn = new Models.PhieuNhapModel(_MaPhieuNhap);
                return _pn.UpdateTinhTrangPhieuNhap();
            }
            catch { return 0; }
        }
        public static int DeletePhieuNhap(string _MaPhieuNhap)
        {
            try
            {
                Models.PhieuNhapModel _pn = new Models.PhieuNhapModel(_MaPhieuNhap);
                return _pn.DeletePhieuNhap();
            }
            catch { return 0; }
        }
        public static string CheckTinhTrangPhieuNhap(string _MaPhieuNhap)
        {
            try
            {
                Models.PhieuNhapModel _pn = new Models.PhieuNhapModel(_MaPhieuNhap);
                return _pn.CheckTinhTrangPhieuNhap();
            }
            catch { return ""; }
        }
        public static string GetMaNVByMaPhieuNhap(string _MaPhieuNhap)
        {
            try
            {
                Models.PhieuNhapModel _pn = new Models.PhieuNhapModel(_MaPhieuNhap);
                return _pn.GetMaNVByMaPhieuNhap();
            }
            catch { return ""; }
        }
        public static string GetMaNPPByMaPhieuNhap(string _MaPhieuNhap)
        {
            try
            {
                Models.PhieuNhapModel _pn = new Models.PhieuNhapModel(_MaPhieuNhap);
                return _pn.GetMaNPPByMaPhieuNhap();
            }
            catch { return ""; }
        }
        public static string GetTongTienByMaPhieuNhap(string _MaPhieuNhap)
        {
            try
            {
                Models.PhieuNhapModel _pn = new Models.PhieuNhapModel(_MaPhieuNhap);
                return _pn.GetTongTienByMaPhieuNhap();
            }
            catch { return ""; }
        }
        public static string GetNgayNhapByMaPhieuNhap(string _MaPhieuNhap)
        {
            try
            {
                Models.PhieuNhapModel _pn = new Models.PhieuNhapModel(_MaPhieuNhap);
                return _pn.GetNgayNhapByMaPhieuNhap();
            }
            catch { return ""; }
        }
        public static string GetTinhTrangByMaPhieuNhap(string _MaPhieuNhap)
        {
            try
            {
                Models.PhieuNhapModel _pn = new Models.PhieuNhapModel(_MaPhieuNhap);
                return _pn.GetTinhTrangByMaPhieuNhap();
            }
            catch { return ""; }
        }
    }
}
