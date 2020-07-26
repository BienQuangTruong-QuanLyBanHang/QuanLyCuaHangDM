using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDM.Controllers
{
    class LoaiKhachHangCtrl
    {
        public static int InsertLoaiKhachHang(string _MaLoaiKhachHang, string _TenLoaiKhachHang, string _GhiChu)
        {
            try
            {
                Models.LoaiKhachHangModel lkh = new Models.LoaiKhachHangModel(_MaLoaiKhachHang, _TenLoaiKhachHang, _GhiChu);
                return lkh.InsertLoaiKhachHang();
            }
            catch { return 0; }
        }
        public static int UpdateLoaiKhachHang(string _MaLoaiKhachHang, string _TenLoaiKhachHang, string _GhiChu)
        {
            try
            {
                Models.LoaiKhachHangModel lkh = new Models.LoaiKhachHangModel(_MaLoaiKhachHang, _TenLoaiKhachHang, _GhiChu);
                return lkh.UpdateLoaiKhachHang();
            }
            catch { return 0; }
        }
        public static int DeleteLoaiKhachHang(string _MaLoaiKhachHang)
        {
            try
            {
                Models.LoaiKhachHangModel lkh = new Models.LoaiKhachHangModel(_MaLoaiKhachHang);
                return lkh.DeleteLoaiKhachHang();
            }
            catch { return 0; }
        }
    }
}
