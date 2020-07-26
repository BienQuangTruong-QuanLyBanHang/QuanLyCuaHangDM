using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Controllers
{
    class HoaDonCtrl
    {
        public static DataSet FillDataSet_getHoaDonByMaHoaDon(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonModel pn = new Models.HoaDonModel(_MaHoaDon);
                return pn.FillDataSet_getHoaDonByMaHoaDon();
            }
            catch { return null; }
        }
        public static int InsertHoaDon(string _MaHoaDon, string _MaKhachHang, string _MaNhanVien, DateTime _NgayLapHoaDon, int _TongTien, string _TinhTrang)
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel(_MaHoaDon, _MaKhachHang, _MaNhanVien, _NgayLapHoaDon, _TongTien, _TinhTrang);
                return _hd.InsertHoaDon();
            }
            catch { return 0; }
        }
        public static int UpdateHoaDon(string _MaHoaDon, string _MaKhachHang, string _MaNhanVien, DateTime _NgayLapHoaDon, int _TongTien, string _TinhTrang)
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel(_MaHoaDon, _MaKhachHang, _MaNhanVien, _NgayLapHoaDon, _TongTien, _TinhTrang);
                return _hd.UpdateHoaDon();
            }
            catch { return 0; }
        }
        public static int UpdateTinhTrangHoaDon(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel(_MaHoaDon);
                return _hd.UpdateTinhTrangHoaDon();
            }
            catch { return 0; }
        }
        public static int DeleteHoaDon(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel(_MaHoaDon);
                return _hd.DeleteHoaDon();
            }
            catch { return 0; }
        }
        public static string CheckTinhTrangHoaDon(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel(_MaHoaDon);
                return _hd.CheckTinhTrangHoaDon();
            }
            catch { return ""; }
        }
        public static string GetMaNVByMaHoaDon(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel(_MaHoaDon);
                return _hd.GetMaNVByMaHoaDon();
            }
            catch { return ""; }
        }
        public static string GetMaKHByMaHoaDon(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel(_MaHoaDon);
                return _hd.GetMaKHByMaHoaDon();
            }
            catch { return ""; }
        }
        public static string GetTongTienByMaHoaDon(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel(_MaHoaDon);
                return _hd.GetTongTienByMaHoaDon();
            }
            catch { return ""; }
        }
        public static string GetNgayNhapByMaHoaDon(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel(_MaHoaDon);
                return _hd.GetNgayNhapByMaHoaDon();
            }
            catch { return ""; }
        }
        public static string GetTinhTrangByMaHoaDon(string _MaHoaDon)
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel(_MaHoaDon);
                return _hd.GetTinhTrangByMaHoaDon();
            }
            catch { return ""; }
        }
        public static int InsertViewHoaDon()
        {
            try
            {
                Models.HoaDonModel _hd = new Models.HoaDonModel();
                return _hd.InsertViewHoaDon();
            }
            catch { return 0; }
        }
    }
}
