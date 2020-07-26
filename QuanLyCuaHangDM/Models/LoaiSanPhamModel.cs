using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Models
{
    class LoaiSanPhamModel
    {
        protected string MaLoaiSanPham { get; set; }
        protected string TenLoaiSanPham { get; set; }
        public LoaiSanPhamModel()
        {

        }
        public LoaiSanPhamModel(string _MaLoaiSanPham)
        {
            MaLoaiSanPham = _MaLoaiSanPham;
        }
        public LoaiSanPhamModel(string _MaLoaiSanPham, string _TenLoaiSanPham)
        {
            MaLoaiSanPham = _MaLoaiSanPham;
            TenLoaiSanPham = _TenLoaiSanPham;
        }
        public int InserLoaiSanPham()
        {
            int i = 0;
            string[] para = new string[1] { "@TenLoaiSanPham" };
            object[] value = new object[1] { TenLoaiSanPham };
            i = Models.Connection.Excute_Sql("spInsertLoaiSanPham", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdatetLoaiSanPham()
        {
            int i = 0;
            string[] para = new string[2] { "@MaLoaiSanPham", "@TenLoaiSanPham" };
            object[] value = new object[2] { MaLoaiSanPham, TenLoaiSanPham };
            i = Models.Connection.Excute_Sql("spUpdateLoaiSanPham", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteLoaiSanPham()
        {
            int i = 0;
            string[] para = new string[1] { "@MaLoaiSanPham" };
            object[] value = new object[1] { MaLoaiSanPham };
            i = Models.Connection.Excute_Sql("exec spDeleteLoaiSanPham " + MaLoaiSanPham);
            return i;
        }
        public static DataSet FillDataSetLoaiSanPham()
        {
            return Models.Connection.FillDataSet("spgetLoaiSanPham", CommandType.StoredProcedure);
        }
    }
}
