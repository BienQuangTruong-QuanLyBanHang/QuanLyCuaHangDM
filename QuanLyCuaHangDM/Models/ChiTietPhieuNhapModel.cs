using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Models
{
    class ChiTietPhieuNhapModel
    {
        protected string MaCTPN { get; set; }
        protected string MaPhieuNhap { get; set; }
        protected string MaSanPham { get; set; }
        protected int SoLuong { get; set; }
        protected int TongTien { get; set; }
        protected string ChuThich { get; set; }

        public ChiTietPhieuNhapModel()
        {

        }
        public ChiTietPhieuNhapModel(string _MaPN)
        {
            MaPhieuNhap = _MaPN;
        }
        public ChiTietPhieuNhapModel(string _MaCTPN, string _MaPhieuNhap, string _MaSanPham, int _SoLuong, int _TongTien, string _ChuThich)
        {
            MaCTPN = _MaCTPN;
            MaPhieuNhap = _MaPhieuNhap;
            MaSanPham = _MaSanPham;
            SoLuong = _SoLuong;
            TongTien = _TongTien;
            ChuThich = _ChuThich;
        }
        public int InsertCTPN()
        {
            int i = 0;
            string[] para = new string[4] { "@MaPhieuNhap", "@MaSanPham", "@SoLuong", "@ChuThich" };
            object[] value = new object[4] { MaPhieuNhap, MaSanPham, SoLuong, ChuThich };
            i = Models.Connection.Excute_Sql("spInsertCTPN", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdateCTPN()
        {
            int i = 0;
            string[] para = new string[5] { "@MaCTPN", "@MaPhieuNhap", "@MaSanPham", "@SoLuong", "@ChuThich" };
            object[] value = new object[5] { MaCTPN, MaPhieuNhap, MaSanPham, SoLuong, ChuThich };
            i = Models.Connection.Excute_Sql("spUpdateCTPN", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteCTPN()
        {
            int i = 0;
            string[] para = new string[1] { "@MaCTPN" };
            object[] value = new object[1] { MaCTPN };
            i = Models.Connection.Excute_Sql("spDeleteCTPN", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public static DataSet FillDataSetCTPN()
        {
            return Models.Connection.FillDataSet("spgetCTPN", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getCTPNByMaPN()
        {
            DataSet ds = new DataSet();
            string[] para = new string[1] { "@MaPhieuNhap" };
            object[] value = new object[1] { MaPhieuNhap };
            ds = Models.Connection.FillDataSet("spgetCTPNByMaPN", CommandType.StoredProcedure, para, value);
            return ds;
        }
    }
}
