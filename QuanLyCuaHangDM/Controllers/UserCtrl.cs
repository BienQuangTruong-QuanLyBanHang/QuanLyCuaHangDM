using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Controllers
{
    class UserCtrl
    {
        public static int InsertUser(string _ID, string _MaNhanVien, string _TenDangNhap, string _MatKhau, string _ChuThich)
        {
            try
            {
                Models.UserModel _us = new Models.UserModel(_ID, _MaNhanVien, _TenDangNhap, _MatKhau, _ChuThich);
                return _us.InsertUser();
            }
            catch { return 0; }
        }
        public static int UpdateUser(string _ID, string _MaNhanVien, string _TenDangNhap, string _MatKhau, string _ChuThich)
        {
            try
            {
                Models.UserModel _us = new Models.UserModel(_ID, _MaNhanVien, _TenDangNhap, _MatKhau, _ChuThich);
                return _us.UpdatetUser();
            }
            catch { return 0; }
        }
        public static int DeleteNhanVien(string _ID)
        {
            try
            {
                Models.UserModel _us = new Models.UserModel(_ID);
                return _us.DeleteUser();
            }
            catch { return 0; }
        }
    }
}
