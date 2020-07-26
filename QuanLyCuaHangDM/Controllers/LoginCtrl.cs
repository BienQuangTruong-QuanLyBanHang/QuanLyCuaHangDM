using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDM.Controllers
{
    class LoginCtrl
    {
        public static string CheckDangNhap(string _user, string _pass)
        {
            try
            {
                Models.LoginModel login = new Models.LoginModel(_user, _pass);
                return login.CheckDangnhap();
            }
            catch { return ""; }
        }
        public static string GetIdUser(string _user, string _pass)
        {
            try
            {
                Models.LoginModel login = new Models.LoginModel(_user, _pass);
                return login.GetIdUser();
            }
            catch { return ""; }
        }
        public static string GetChucVu(string _user, string _pass)
        {
            try
            {
                Models.LoginModel login = new Models.LoginModel(_user, _pass);
                return login.GetChucVu();
            }
            catch { return ""; }
        }
    }
}
