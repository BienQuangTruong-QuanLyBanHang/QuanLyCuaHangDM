using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Models
{
    class ChiTietHoaDonModel
    {
        protected string MaCTHD { get; set; }
        protected string MaHoaDon { get; set; }
        protected string MaSanPham { get; set; }
        protected int SoLuong { get; set; }
        protected int TongTien { get; set; }
        protected string GhiChu { get; set; }

        public ChiTietHoaDonModel()
        {

        }
        public ChiTietHoaDonModel(string _MaHD)
        {
            MaHoaDon = _MaHD;
        }
        public ChiTietHoaDonModel(string _MaCTHD, string _MaHoaDon, string _MaSanPham, int _SoLuong, int _TongTien, string _GhiChu)
        {
            MaCTHD = _MaCTHD;
            MaHoaDon = _MaHoaDon;
            MaSanPham = _MaSanPham;
            SoLuong = _SoLuong;
            TongTien = _TongTien;
            GhiChu = _GhiChu;
        }
        public int InsertCTHD()
        {
            int i = 0;
            string[] para = new string[4] { "@MaHoaDon", "@MaSanPham", "@SoLuong", "@GhiChu" };
            object[] value = new object[4] { MaHoaDon, MaSanPham, SoLuong, GhiChu };
            i = Models.Connection.Excute_Sql("spInsertCTHD", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdateCTHD()
        {
            int i = 0;
            string[] para = new string[5] { "@MaCTHD", "@MaHoaDon", "@MaSanPham", "@SoLuong", "@GhiChu" };
            object[] value = new object[5] { MaCTHD, MaHoaDon, MaSanPham, SoLuong, GhiChu };
            i = Models.Connection.Excute_Sql("spUpdateCTHD", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteCTHD()
        {
            int i = 0;
            string[] para = new string[1] { "@MaCTHD" };
            object[] value = new object[1] { MaCTHD };
            i = Models.Connection.Excute_Sql("exec spDeleteCTHD " + MaCTHD);
            return i;
        }
        public static DataSet FillDataSetCTHD()
        {
            return Models.Connection.FillDataSet("spgetCTHD", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getCTHDByMaCTHD()
        {
            DataSet ds = new DataSet();
            string[] para = new string[1] { "@MaHoaDon" };
            object[] value = new object[1] { MaHoaDon };
            ds = Models.Connection.FillDataSet("spgetCTHDByMaHD", CommandType.StoredProcedure, para, value);
            return ds;
        }
    }
}
