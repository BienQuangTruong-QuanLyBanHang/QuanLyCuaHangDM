using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDM.Controllers
{
    class RegisterCtrl
    {
        public static string DangKy(string _id , string _user, string _pass)
        {
            try
            {
                Models.RegisterModel register = new Models.RegisterModel(_id , _user, _pass);
                return register.DangKy();
            }
            catch { return "error"; }
        }
        public static string CheckTonTai(string _id, string _user, string _pass)
        {
            try
            {
                Models.RegisterModel register = new Models.RegisterModel(_id, _user, _pass);
                return register.CheckTonTai();
            }
            catch { return "error"; }
        }
        public static string CheckTonTaiMaNV(string _id, string _user, string _pass)
        {
            try
            {
                Models.RegisterModel register = new Models.RegisterModel(_id, _user, _pass);
                return register.CheckTonTaiMaNV();
            }
            catch { return "error"; }
        }
    }
}
