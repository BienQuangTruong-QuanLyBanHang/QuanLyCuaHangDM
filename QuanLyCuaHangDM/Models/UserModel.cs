using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Models
{
    class UserModel
    {
        protected string ID { get; set; }
        protected string MaNhanVien { get; set; }
        protected string TenDangNhap { get; set; }
        protected string MatKhau { get; set; }
        protected string ChuThich { get; set; }
        public UserModel()
        {

        }
        public UserModel(string _ID)
        {
            ID = _ID;
        }
        public UserModel(string _ID, string _MaNhanVien, string _TenDangNhap, string _MatKhau, string _ChuThich)
        {
            ID = _ID;
            MaNhanVien = _MaNhanVien;
            TenDangNhap = _TenDangNhap;
            MatKhau = _MatKhau;
            ChuThich = _ChuThich;
        }
        public int InsertUser()
        {
            int i = 0;
            string[] para = new string[4] { "@MaNhanVien", "@TenDangNhap", "@MatKhau", "@ChuThich" };
            object[] value = new object[4] { MaNhanVien, TenDangNhap, MatKhau, ChuThich };
            i = Models.Connection.Excute_Sql("spInsertUser", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdatetUser()
        {
            int i = 0;
            string[] para = new string[5] { "@ID", "@MaNhanVien", "@TenDangNhap", "@MatKhau", "@ChuThich" };
            object[] value = new object[5] { ID, MaNhanVien, TenDangNhap, MatKhau, ChuThich };
            i = Models.Connection.Excute_Sql("spUpdateUser", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteUser()
        {
            int i = 0;
            string[] para = new string[1] { "@ID" };
            object[] value = new object[1] { ID };
            i = Models.Connection.Excute_Sql("exec spDeleteUser " + ID);
            return i;
        }
        public static DataSet FillDataSetUser()
        {
            return Models.Connection.FillDataSet("spgetUser", CommandType.StoredProcedure);
        }
    }
}
