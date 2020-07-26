using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCuaHangDM.Controllers
{
    class SanPhamCtrl
    {
        public static DataSet FillDataSet_getSanPhamByMaSanPham(string _MaSanPham)
        {
            try
            {
                Models.SanPhamModel sp = new Models.SanPhamModel(_MaSanPham);
                return sp.FillDataSet_getSanPhamByMaSanPham();
            }
            catch { return null; }
        }
        public static int InsertSanPham(string _MaSanPham, string _TenSanPham, string _LoaiSanPham, string _HangSanXuat, int _GiaNhap, int _GiaBan, int _TonKho, string _TrangThai, string _HinhSanPham, string _ChuThich)
        {
            try
            {
                Models.SanPhamModel _sp = new Models.SanPhamModel(_MaSanPham, _TenSanPham, _LoaiSanPham, _HangSanXuat, _GiaNhap, _GiaBan, _TonKho, _TrangThai, _HinhSanPham, _ChuThich);
                return _sp.InsertSanPham();
            }
            catch { return 0; }
        }
        public static int UpdateSanPham(string _MaSanPham, string _TenSanPham, string _LoaiSanPham, string _HangSanXuat, int _GiaNhap, int _GiaBan, int _TonKho, string _TrangThai, string _HinhSanPham, string _ChuThich)
        {
            try
            {
                Models.SanPhamModel _sp = new Models.SanPhamModel(_MaSanPham, _TenSanPham, _LoaiSanPham, _HangSanXuat, _GiaNhap, _GiaBan, _TonKho, _TrangThai, _HinhSanPham, _ChuThich);
                return _sp.UpdateSanPham();
            }
            catch { return 0; }
        }
        public static int DeleteSanPham(string _MaSanPham)
        {
            try
            {
                Models.SanPhamModel _sp = new Models.SanPhamModel(_MaSanPham);
                return _sp.DeleteSanPham();
            }
            catch { return 0; }
        }
        public static string GetGiaNhapByMaSanPham(string _MaSanPham)
        {
            try
            {
                Models.SanPhamModel _pn = new Models.SanPhamModel(_MaSanPham);
                return _pn.GetGiaNhapByMaSanPham();
            }
            catch { return ""; }
        }
        public static string GetGiaBanByMaSanPham(string _MaSanPham)
        {
            try
            {
                Models.SanPhamModel _pn = new Models.SanPhamModel(_MaSanPham);
                return _pn.GetGiaBanByMaSanPham();
            }
            catch { return ""; }
        }
        public static int GetTonKho(string _MaSanPham)
        {
            try
            {
                Models.SanPhamModel _sp = new Models.SanPhamModel(_MaSanPham);
                return _sp.GetTonKho();
            }
            catch { return 0; }
        }
    }
}
