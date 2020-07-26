using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;

namespace QuanLyCuaHangDM.Models
{
    class RegisterModel
    {
        protected string user { get; set; }
        protected string pass { get; set; }
        protected string id { get; set; }


        public RegisterModel(string _id , string _user, string _pass)
        {
            this.user = _user;
            this.pass = _pass;
            this.id = _id;
        }
        public string DangKy()
        {
            string str = "";
            string[] para = new string[3] { "@MaNhanVien", "@TenDangNhap" , "@MatKhau"};
            object[] value = new object[3] { id, user, pass};
            str = Models.Connection.insertData("spInsertDangNhap", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string CheckTonTai()
        {
            string str = "";
            string[] para = new string[2] { "@MaNhanVien", "@TenDangNhap" };
            object[] value = new object[2] { id, user };
            str = Models.Connection.ExcuteScalar("spCheckTonTai", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string CheckTonTaiMaNV()
        {
            string str = "";
            string[] para = new string[1] { "@MaNhanVien" };
            object[] value = new object[1] { id };
            str = Models.Connection.ExcuteScalar("spCheckTonTaiMNV", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
    }
}
