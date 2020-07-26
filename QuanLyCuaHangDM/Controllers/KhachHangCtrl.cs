using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Controllers
{
    class KhachHangCtrl
    {
        public static DataSet FillDataSet_getKhachHangByMaKhachHang(string _MaKhachHang)
        {
            try
            {
                Models.KhachHangModel kh = new Models.KhachHangModel(_MaKhachHang);
                return kh.FillDataSet_getKhachHangByMaKhachHang();
            }
            catch { return null; }
        }
        public static int InsertKhachHang(string _MaKhachHang, string _TenKhachHang, DateTime _NgaySinh, string _GioiTinh, string _DiaChi, string _SDT, string _LoaiKhachHang, string _GhiChu)
        {
            try
            {
                Models.KhachHangModel _kh = new Models.KhachHangModel(_MaKhachHang, _TenKhachHang, _NgaySinh, _GioiTinh, _DiaChi, _SDT, _LoaiKhachHang, _GhiChu);
                return _kh.InsertKhachHang();
            }
            catch { return 0; }
        }
        public static int UpdateKhachHang(string _MaKhachHang, string _TenKhachHang, DateTime _NgaySinh, string _GioiTinh, string _DiaChi, string _SDT, string _LoaiKhachHang, string _GhiChu)
        {
            try
            {
                Models.KhachHangModel _kh = new Models.KhachHangModel(_MaKhachHang, _TenKhachHang, _NgaySinh, _GioiTinh, _DiaChi, _SDT, _LoaiKhachHang, _GhiChu);
                return _kh.UpdateKhachHang();
            }
            catch { return 0; }
        }
        public static int DeleteKhachHang(string _MaKhachHang)
        {
            try
            {
                Models.KhachHangModel _kh = new Models.KhachHangModel(_MaKhachHang);
                return _kh.DeleteKhachHang();
            }
            catch { return 0; }
        }
    }
}
