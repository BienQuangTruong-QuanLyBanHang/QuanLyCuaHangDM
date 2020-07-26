using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Controllers
{
    class ChiTietHoaDonCtrl
    {
        public static DataSet FillDataSet_getCTHDByMaHD(string _MaHD)
        {
            try
            {
                Models.ChiTietHoaDonModel hd = new Models.ChiTietHoaDonModel(_MaHD);
                return hd.FillDataSet_getCTHDByMaCTHD();
            }
            catch { return null; }
        }
        public static int InsertCTHD(string _MaCTHD, string _MaHoaDon, string _MaSanPham, int _SoLuong, int _TongTien, string _GhiChu)
        {
            try
            {
                Models.ChiTietHoaDonModel _hd = new Models.ChiTietHoaDonModel(_MaCTHD, _MaHoaDon, _MaSanPham, _SoLuong, _TongTien, _GhiChu);
                return _hd.InsertCTHD();
            }
            catch { return 0; }
        }
        public static int UpdateCTHD(string _MaCTHD, string _MaHoaDon, string _MaSanPham, int _SoLuong, int _TongTien, string _GhiChu)
        {
            try
            {
                Models.ChiTietHoaDonModel _hd = new Models.ChiTietHoaDonModel(_MaCTHD, _MaHoaDon, _MaSanPham, _SoLuong, _TongTien, _GhiChu);
                return _hd.UpdateCTHD();
            }
            catch { return 0; }
        }
        public static int DeleteCTHD(string _MaCTHD, string _MaHoaDon, string _MaSanPham, int _SoLuong, int _TongTien, string _GhiChu)
        {
            try
            {
                Models.ChiTietHoaDonModel _hd = new Models.ChiTietHoaDonModel(_MaCTHD, _MaHoaDon, _MaSanPham, _SoLuong, _TongTien, _GhiChu);
                return _hd.DeleteCTHD();
            }
            catch { return 0; }
        }
    }
}
