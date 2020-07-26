using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Controllers
{
    class ChiTietPhieuNhapCtrl
    {
        public static DataSet FillDataSet_getCTPNByMaPN(string _MaPN)
        {
            try
            {
                Models.ChiTietPhieuNhapModel pn = new Models.ChiTietPhieuNhapModel(_MaPN);
                return pn.FillDataSet_getCTPNByMaPN();
            }
            catch { return null; }
        }
        public static int InsertCTPN(string _MaCTPN, string _MaPhieuNhap, string _MaSanPham, int _SoLuong, int _TongTien, string _ChuThich)
        {
            try
            {
                Models.ChiTietPhieuNhapModel _pn = new Models.ChiTietPhieuNhapModel(_MaCTPN, _MaPhieuNhap, _MaSanPham, _SoLuong, _TongTien, _ChuThich);
                return _pn.InsertCTPN();
            }
            catch { return 0; }
        }
        public static int UpdateCTPN(string _MaCTPN, string _MaPhieuNhap, string _MaSanPham, int _SoLuong, int _TongTien, string _ChuThich)
        {
            try
            {
                Models.ChiTietPhieuNhapModel _pn = new Models.ChiTietPhieuNhapModel(_MaCTPN, _MaPhieuNhap, _MaSanPham, _SoLuong, _TongTien, _ChuThich);
                return _pn.UpdateCTPN();
            }
            catch { return 0; }
        }
        public static int DeleteCTPN(string _MaCTPN, string _MaPhieuNhap, string _MaSanPham, int _SoLuong, int _TongTien, string _ChuThich)
        {
            try
            {
                Models.ChiTietPhieuNhapModel _pn = new Models.ChiTietPhieuNhapModel(_MaCTPN, _MaPhieuNhap, _MaSanPham, _SoLuong, _TongTien, _ChuThich);
                return _pn.DeleteCTPN();
            }
            catch { return 0; }
        }
    }
}
