using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangDM.Controllers
{
    class HangSanXuatCtrl
    {
        public static int InsertHSX(string _MaHangSanXuat, string _TenHangSanXuat)
        {
            try
            {
                Models.HangSanXuatModel hsx = new Models.HangSanXuatModel(_MaHangSanXuat, _TenHangSanXuat);
                return hsx.InsertHangSanXuat();
            }
            catch { return 0; }
        }
        public static int UpdatetSHSX(string _MaHangSanXuat, string _TenHangSanXuat)
        {
            try
            {
                Models.HangSanXuatModel hsx = new Models.HangSanXuatModel(_MaHangSanXuat, _TenHangSanXuat);
                return hsx.UpdatetHangSanXuat();
            }
            catch { return 0; }
        }
        public static int DeleteHSX(string _MaHangSanXuat)
        {
            try
            {
                Models.HangSanXuatModel hsx = new Models.HangSanXuatModel(_MaHangSanXuat);
                return hsx.DeleteHangSanXuat();
            }
            catch { return 0; }
        }
    }
}
