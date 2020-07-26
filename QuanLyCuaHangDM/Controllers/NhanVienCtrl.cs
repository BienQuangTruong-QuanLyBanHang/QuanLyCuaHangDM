using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangDM.Controllers
{
    class NhanVienCtrl
    {
        public static DataSet FillDataSet_getNhanVienByMaNhanVien(string _MaNhanVien)
        {
            try
            {
                Models.NhanVienModel nv = new Models.NhanVienModel(_MaNhanVien);
                return nv.FillDataSet_getNhanVienByMaNhanVien();
            }
            catch { return null; }
        }
        public static int InsertNhanVien(string _MaNhanVien, string _TenNV, DateTime _NgaySinhNV, string _GioiTinhNV, string _ChucVuNV, string _DiaChiNV, string _SoDTNV, string _GhiChu)
        {
            try
            {
                Models.NhanVienModel _nv = new Models.NhanVienModel(_MaNhanVien, _TenNV, _NgaySinhNV, _GioiTinhNV, _ChucVuNV, _DiaChiNV, _SoDTNV, _GhiChu);
                return _nv.InsertNhanVien();
            }
            catch { return 0; }
        }
        public static int UpdateNhanVien(string _MaNhanVien, string _TenNV, DateTime _NgaySinhNV, string _GioiTinhNV, string _ChucVuNV, string _DiaChiNV, string _SoDTNV, string _GhiChu)
        {
            try
            {
                Models.NhanVienModel _nv = new Models.NhanVienModel(_MaNhanVien, _TenNV, _NgaySinhNV, _GioiTinhNV, _ChucVuNV, _DiaChiNV, _SoDTNV, _GhiChu);
                return _nv.UpdatetNhanVien();
            }
            catch { return 0; }
        }
        public static int DeleteNhanVien(string _MaNhanVien)
        {
            try
            {
                Models.NhanVienModel _nv = new Models.NhanVienModel(_MaNhanVien);
                return _nv.DeleteNhanVien();
            }
            catch { return 0; }
        }
    }
}
