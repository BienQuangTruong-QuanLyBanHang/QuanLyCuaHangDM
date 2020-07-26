using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Models
{
    class HoaDonModel
    {
        protected string MaHoaDon { get; set; }
        protected string MaKhachHang { get; set; }
        protected string MaNhanVien { get; set; }
        protected DateTime NgaylapHoaDon { get; set; }
        protected int TongTien { get; set; }
        protected string TinhTrang { get; set; }

        public HoaDonModel()
        {

        }
        public HoaDonModel(string _MaHoaDon)
        {
            MaHoaDon = _MaHoaDon;
        }
        public HoaDonModel(string _MaHoaDon, string _MaKhachHang, string _MaNhanVien, DateTime _NgayLapHoaDon, int _TongTien, string _TinhTrang)
        {
            MaHoaDon = _MaHoaDon;
            MaKhachHang = _MaKhachHang;
            MaNhanVien = _MaNhanVien;
            NgaylapHoaDon = _NgayLapHoaDon;
            TongTien = _TongTien;
            TinhTrang = _TinhTrang;
        }
        public int InsertHoaDon()
        {
            int i = 0;
            string[] para = new string[2] { "@MaKhachHang", "@MaNhanVien" };
            object[] value = new object[2] { MaKhachHang, MaNhanVien };
            i = Models.Connection.Excute_Sql("spInsertHoaDon", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdateHoaDon()
        {
            int i = 0;
            string[] para = new string[2] {  "@MaHoaDon", "@MaKhachHang" };
            object[] value = new object[2] { MaHoaDon, MaKhachHang };
            i = Models.Connection.Excute_Sql("spUpdateHoaDon", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdateTinhTrangHoaDon()
        {
            int i = 0;
            string[] para = new string[1] { "@MaHoaDon" };
            object[] value = new object[1] { MaHoaDon };
            i = Models.Connection.Excute_Sql("spUpdateTinhTrangHoaDon", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteHoaDon()
        {
            int i = 0;
            string[] para = new string[1] { "@MaHoaDon" };
            object[] value = new object[1] { MaHoaDon };
            i = Models.Connection.Excute_Sql("exec spDeleteHoaDon " + MaHoaDon);
            return i;
        }
        public string CheckTinhTrangHoaDon()
        {
            string str = "";
            string[] para = new string[1] { "@MaHoaDon" };
            object[] value = new object[1] { MaHoaDon };
            str = Models.Connection.ExcuteScalar("spCheckTinhTrangHoaDon", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public static DataSet FillDataSetHoaDon()
        {
            return Models.Connection.FillDataSet("spgetHoaDon", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getHoaDonByMaHoaDon()
        {
            DataSet ds = new DataSet();
            string[] para = new string[1] { "@MaHoaDon" };
            object[] value = new object[1] { MaHoaDon };
            ds = Models.Connection.FillDataSet("spgetHoaDonByMaHoaDon", CommandType.StoredProcedure, para, value);
            return ds;
        }
        public string GetMaNVByMaHoaDon()
        {
            string str = "";
            string[] para = new string[1] { "@MaHoaDon" };
            object[] value = new object[1] { MaHoaDon };
            str = Models.Connection.ExcuteScalar("spGetMaNVByMaHoaDon", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetMaKHByMaHoaDon()
        {
            string str = "";
            string[] para = new string[1] { "@MaHoaDon" };
            object[] value = new object[1] { MaHoaDon };
            str = Models.Connection.ExcuteScalar("spGetMaKHByMaHoaDon", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetTongTienByMaHoaDon()
        {
            string str = "";
            string[] para = new string[1] { "@MaHoaDon" };
            object[] value = new object[1] { MaHoaDon };
            str = Models.Connection.ExcuteScalar("spGetTongTienByMaHoaDon", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetNgayNhapByMaHoaDon()
        {
            string str = "";
            string[] para = new string[1] { "@MaHoaDon" };
            object[] value = new object[1] { MaHoaDon };
            str = Models.Connection.ExcuteScalar("spGetNgayLapHoaDonByMaHoaDon", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetTinhTrangByMaHoaDon()
        {
            string str = "";
            string[] para = new string[1] { "@MaHoaDon" };
            object[] value = new object[1] { MaHoaDon };
            str = Models.Connection.ExcuteScalar("spGetTinhTrangByMaHoaDon", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public int InsertViewHoaDon()
        {
            int i = 0;
            string[] para = new string[0] { };
            object[] value = new object[0] {  };
            i = Models.Connection.Excute_Sql("spInsertViewHoaDon", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
    }
}
