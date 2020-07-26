using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangDM.Models
{
    class NhanVienModel
    {
        protected string MaNV { get; set; }
        protected string TenNV { get; set; }
        protected DateTime NgaySinh { get; set; }
        protected string GioiTinh { get; set; }
        protected string ChucVu { get; set; }
        protected string DiaChi { get; set; }
        protected string SoDT { get; set; }
        protected string GhiChu { get; set; }

        public NhanVienModel()
        {

        }
        public NhanVienModel(string _IdNhanVien)
        {
            MaNV = _IdNhanVien;
        }
        public NhanVienModel(string _IdNhanVien, string _TenNV, DateTime _NgaySinhNV, string _GioiTinhNV, string _ChucVuNV, string _DiaChiNV, string _SoDTNV, string _GhiChu)
        {
            MaNV = _IdNhanVien;
            TenNV = _TenNV;
            NgaySinh = _NgaySinhNV;
            GioiTinh = _GioiTinhNV;
            ChucVu = _ChucVuNV;
            DiaChi = _DiaChiNV;
            SoDT = _SoDTNV;
            GhiChu = _GhiChu;
        }
        public int InsertNhanVien()
        {
            int i = 0;
            string[] para = new string[7] { "@TenNhanVien", "@NgaySinh", "@GioiTinh", "@ChucVu", "@DiaChi", "@SoDT", "@GhiChu" };
            object[] value = new object[7] { TenNV, NgaySinh, GioiTinh, ChucVu, DiaChi, SoDT, GhiChu };
            i = Models.Connection.Excute_Sql("spInsertNhanVien", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdatetNhanVien()
        {
            int i = 0;
            string[] para = new string[8] {  "@MaNhanVien", "@TenNhanVien", "@NgaySinh", "@GioiTinh", "@ChucVu", "@DiaChi", "@SoDT", "@GhiChu" };
            object[] value = new object[8] {  MaNV, TenNV, NgaySinh, GioiTinh, ChucVu, DiaChi, SoDT, GhiChu };
            i = Models.Connection.Excute_Sql("spUpdateNhanVien", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteNhanVien()
        {
            int i = 0;
            string[] para = new string[1] { "@MaNhanVien" };
            object[] value = new object[1] { MaNV };
            //i = Models.Connection.Excute_Sql("spDeleteNhanVien", System.Data.CommandType.StoredProcedure, para, value);
            i = Models.Connection.Excute_Sql("exec spDeleteNhanVien " + MaNV);
            return i;
        }
        public static DataSet FillDataSetNhanVien()
        {
            return Models.Connection.FillDataSet("spgetNhanVien", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getNhanVienByMaNhanVien()
        {
            DataSet ds = new DataSet();
            string[] para = new string[1] { "@MaNhanVien" };
            object[] value = new object[1] { MaNV };
            ds = Models.Connection.FillDataSet("spgetNhanVienByIdNhanVien", CommandType.StoredProcedure, para, value);
            return ds;
        }
    }
}
