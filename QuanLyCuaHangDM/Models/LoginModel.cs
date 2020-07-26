using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace QuanLyCuaHangDM.Models
{
    class LoginModel
    {
        protected string user { get; set; }
        protected string pass { get; set; }

        public LoginModel(string _user, string _pass)
        {
            this.user = _user;
            this.pass = _pass;
        }

        public string CheckDangnhap()
        {
            string str = "";
            string[] para = new string[2] { "@TenDangNhap", "@MatKhau" };
            object[] value = new object[2] { user, pass };
            str = Models.Connection.ExcuteScalar("spCheckDangNhap", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetIdUser()
        {
            string str = "";
            string[] para = new string[1] { "@TenDangNhap" };
            object[] value = new object[1] { user };
            str = Models.Connection.ExcuteScalar("spGetIdUser", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetChucVu()
        {
            string str = "";
            string[] para = new string[1] { "@TenDangNhap" };
            object[] value = new object[1] { user };
            str = Models.Connection.ExcuteScalar("getChucVu", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
    }
}
