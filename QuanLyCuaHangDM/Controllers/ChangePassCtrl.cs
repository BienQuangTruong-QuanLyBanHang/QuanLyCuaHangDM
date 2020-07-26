using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDM.Controllers
{
    class ChangePassCtrl
    {
        public static string CheckTaiKhoan(string _user, string _pass)
        {
            try
            {
                Models.ChangePassModel login = new Models.ChangePassModel( _user, _pass);
                return login.CheckTaiKhoan();
            }
            catch { return "error"; }
        }
        public static int ChangePass(string _user, string _pass)
        {
            try
            {
                Models.ChangePassModel login = new Models.ChangePassModel(_user, _pass);
                return login.ChangePass();
            }
            catch { return 0; }
        }
    }
}
