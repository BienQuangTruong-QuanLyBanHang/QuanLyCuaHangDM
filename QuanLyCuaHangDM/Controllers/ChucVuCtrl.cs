using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDM.Controllers
{
    class ChucVuCtrl
    {
        public static int InsertChucVu(string _MaChucVu, string _TenChucVu, string _GhiChu)
        {
            try
            {
                Models.ChucVuModel cv = new Models.ChucVuModel(_MaChucVu, _TenChucVu, _GhiChu);
                return cv.InsertChucVu();
            }
            catch { return 0; }
        }
        public static int UpdateChucVu(string _MaChucVu, string _TenChuVu, string _GhiChu)
        {
            try
            {
                Models.ChucVuModel cv = new Models.ChucVuModel(_MaChucVu, _TenChuVu, _GhiChu);
                return cv.UpdateChucVu();
            }
            catch { return 0; }
        }
        public static int DeleteChucVu(string _MaChucVu)
        {
            try
            {
                Models.ChucVuModel cv = new Models.ChucVuModel(_MaChucVu);
                return cv.DeleteChucVu();
            }
            catch { return 0; }
        }
    }
}
