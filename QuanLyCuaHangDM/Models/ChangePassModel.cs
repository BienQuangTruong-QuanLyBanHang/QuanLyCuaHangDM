using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDM.Models
{
    class ChangePassModel
    {
        protected string user { get; set; }
        protected string pass { get; set; }
        public ChangePassModel(string _user, string _pass)
        {
            this.user = _user;
            this.pass = _pass;
        }
        public string CheckTaiKhoan()
        {
            string str = "";
            string[] para = new string[2] { "@TenDangNhap", "@MatKhau" };
            object[] value = new object[2] { user, pass };
            str = Models.Connection.ExcuteScalar("spCheckTaiKhoan", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public int ChangePass()
        {
            int str = 0;
            string[] para = new string[2] { "@TenDangNhap", "@MatKhau" };
            object[] value = new object[2] { user, pass };
            str = Models.Connection.Excute_Sql("spChangePass", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
    }
}
