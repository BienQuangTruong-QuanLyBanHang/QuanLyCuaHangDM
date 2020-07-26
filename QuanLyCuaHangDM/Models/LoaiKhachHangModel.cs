using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Models
{
    class LoaiKhachHangModel
    {
        protected string MaLoaiKhachHang { get; set; }
        protected string TenLoaiKhachHang { get; set; }
        protected string GhiChu { get; set; }
        public LoaiKhachHangModel()
        {

        }
        public LoaiKhachHangModel(string _MaLoaiKhachHang)
        {
            MaLoaiKhachHang = _MaLoaiKhachHang;
        }
        public LoaiKhachHangModel(string _MaLoaiKhachHang, string _TenLoaiKhachHang, string _GhiChu)
        {
            MaLoaiKhachHang = _MaLoaiKhachHang;
            TenLoaiKhachHang = _TenLoaiKhachHang;
            GhiChu = _GhiChu;
        }
        public int InsertLoaiKhachHang()
        {
            int i = 0;
            string[] para = new string[2] { "@TenLoaiKhachHang", "@GhiChu" };
            object[] value = new object[2] { TenLoaiKhachHang, GhiChu };
            i = Models.Connection.Excute_Sql("spInsertLoaiKhachHang", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdateLoaiKhachHang()
        {
            int i = 0;
            string[] para = new string[3] { "@MaLoaiKhachHang", "@TenLoaiKhachHang", "@GhiChu" };
            object[] value = new object[3] { MaLoaiKhachHang, TenLoaiKhachHang, GhiChu };
            i = Models.Connection.Excute_Sql("spUpdateLoaiKhachHang", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteLoaiKhachHang()
        {
            int i = 0;
            string[] para = new string[1] { "@MaLoaiKhachHang" };
            object[] value = new object[1] { MaLoaiKhachHang };
            i = Models.Connection.Excute_Sql("exec spDeleteLoaiKhachHang " + MaLoaiKhachHang);
            return i;
        }
        public static DataSet FillDataSetLoaiKhachHang()
        {
            return Models.Connection.FillDataSet("spgetLoaiKhachHang", CommandType.StoredProcedure);
        }
    }
}
