using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Models
{
    class KhachHangModel
    {
        protected string MaKhachHang { get; set; }
        protected string TenKhachHang { get; set; }
        protected DateTime NgaySinh { get; set; }
        protected string GioiTinh { get; set; }
        protected string DiaChi { get; set; }
        protected string SDT { get; set; }
        protected string LoaiKhachHang { get; set; }
        protected string GhiChu { get; set; }

        public KhachHangModel()
        {

        }
        public KhachHangModel(string _MaKhachHang)
        {
            MaKhachHang = _MaKhachHang;
        }
        public KhachHangModel(string _MaKhachHang, string _TenKhachHang, DateTime _NgaySinh, string _GioiTinh, string _DiaChi, string _SDT, string _LoaiKhachHang, string _GhiChu)
        {
            MaKhachHang = _MaKhachHang;
            TenKhachHang = _TenKhachHang;
            NgaySinh = _NgaySinh;
            GioiTinh = _GioiTinh;
            DiaChi = _DiaChi;
            SDT = _SDT;
            LoaiKhachHang = _LoaiKhachHang;
            GhiChu = _GhiChu;
        }
        public int InsertKhachHang()
        {
            int i = 0;
            string[] para = new string[7] { "@TenKhachHang", "@NgaySinh", "@GioiTinh", "@DiaChi", "@SDT", "@LoaiKhachHang", "@GhiChu" };
            object[] value = new object[7] { TenKhachHang, NgaySinh, GioiTinh, DiaChi, SDT, LoaiKhachHang, GhiChu };
            i = Models.Connection.Excute_Sql("spInsertKhachHang", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdateKhachHang()
        {
            int i = 0;
            string[] para = new string[8] { "@MaKhachHang", "@TenKhachHang", "@NgaySinh", "@GioiTinh", "@DiaChi", "@SDT", "@LoaiKhachHang", "@GhiChu" };
            object[] value = new object[8] { MaKhachHang, TenKhachHang, NgaySinh, GioiTinh, DiaChi, SDT, LoaiKhachHang, GhiChu };
            i = Models.Connection.Excute_Sql("spUpdateKhachHang", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteKhachHang()
        {
            int i = 0;
            string[] para = new string[1] { "@MaKhachHang" };
            object[] value = new object[1] { MaKhachHang };
            i = Models.Connection.Excute_Sql("exec spDeleteKhachHang " + MaKhachHang);
            return i;
        }
        public static DataSet FillDataSetKhachHang()
        {
            return Models.Connection.FillDataSet("spgetKhachHang", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getKhachHangByMaKhachHang()
        {
            DataSet ds = new DataSet();
            string[] para = new string[1] { "@MaKhachHang" };
            object[] value = new object[1] { MaKhachHang };
            ds = Models.Connection.FillDataSet("spgetKhachHangByMaKhachHang", CommandType.StoredProcedure, para, value);
            return ds;
        }
    }
}
