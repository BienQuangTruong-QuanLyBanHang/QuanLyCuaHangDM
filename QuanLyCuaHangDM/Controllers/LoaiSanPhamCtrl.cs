using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Controllers
{
    class LoaiSanPhamCtrl
    {
        public static int InsertLoaiSanPham(string _MaLoaiSanPham, string _TenLoaiSanPham)
        {
            try
            {
                Models.LoaiSanPhamModel lsp = new Models.LoaiSanPhamModel(_MaLoaiSanPham, _TenLoaiSanPham);
                return lsp.InserLoaiSanPham();
            }
            catch { return 0; }
        }
        public static int UpdatetLoaiSanPham(string _MaLoaiSanPham, string _TenLoaiSanPham)
        {
            try
            {
                Models.LoaiSanPhamModel lsp = new Models.LoaiSanPhamModel(_MaLoaiSanPham, _TenLoaiSanPham);
                return lsp.UpdatetLoaiSanPham();
            }
            catch { return 0; }
        }
        public static int DeleteLoaiSanPham(string _MaLoaiSanPham)
        {
            try
            {
                Models.LoaiSanPhamModel lsp = new Models.LoaiSanPhamModel(_MaLoaiSanPham);
                return lsp.DeleteLoaiSanPham();
            }
            catch { return 0; }
        }
    }
}
