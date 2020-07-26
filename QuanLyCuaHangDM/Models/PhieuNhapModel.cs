using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Models
{
    class PhieuNhapModel
    {
        protected string MaPhieuNhap { get; set; }
        protected string MaNhanVien { get; set; }
        protected string MaNhaPhanPhoi { get; set; }
        protected int TongTien { get; set; }
        protected DateTime NgayNhap { get; set; }
        protected string TinhTrang { get; set; }

        public PhieuNhapModel()
        {

        }
        public PhieuNhapModel(string _MaPhieuNhap)
        {
            MaPhieuNhap = _MaPhieuNhap;
        }
        public PhieuNhapModel(string _MaPhieuNhap, string _MaNhanVien, string _MaNhaPhanPhoi, int _TongTien, DateTime _NgayNhap, string _TinhTrang)
        {
            MaPhieuNhap = _MaPhieuNhap;
            MaNhanVien = _MaNhanVien;
            MaNhaPhanPhoi = _MaNhaPhanPhoi;
            TongTien = _TongTien;
            NgayNhap = _NgayNhap;
            TinhTrang = _TinhTrang;
        }
        public int InsertPhieuNhap()
        {
            int i = 0;
            string[] para = new string[2] { "@MaNhanVien", "@MaNhaPhanPhoi" };
            object[] value = new object[2] { MaNhanVien, MaNhaPhanPhoi };
            i = Models.Connection.Excute_Sql("spInsertPhieuNhap", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdatePhieuNhap()
        {
            int i = 0;
            string[] para = new string[2] { "@MaPhieuNhap", "@MaNhaPhanPhoi" };
            object[] value = new object[2] { MaPhieuNhap, MaNhaPhanPhoi };
            i = Models.Connection.Excute_Sql("spUpdatePhieuNhap", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdateTinhTrangPhieuNhap()
        {
            int i = 0;
            string[] para = new string[1] { "@MaPhieuNhap" };
            object[] value = new object[1] { MaPhieuNhap };
            i = Models.Connection.Excute_Sql("spUpdateTinhTrangPhieuNhap", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeletePhieuNhap()
        {
            int i = 0;
            string[] para = new string[1] { "@MaPhieuNhap" };
            object[] value = new object[1] { MaPhieuNhap };
            i = Models.Connection.Excute_Sql("exec spDeletePhieuNhap " + MaPhieuNhap);
            return i;
        }
        public string CheckTinhTrangPhieuNhap()
        {
            string str = "";
            string[] para = new string[1] { "@MaPhieuNhap" };
            object[] value = new object[1] { MaPhieuNhap };
            str = Models.Connection.ExcuteScalar("spCheckTinhTrangPhieuNhap", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public static DataSet FillDataSetPhieuNhap()
        {
            return Models.Connection.FillDataSet("spgetPhieuNhap", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getPhieuNhapByMaPhieuNhap()
        {
            DataSet ds = new DataSet();
            string[] para = new string[1] { "@MaPhieuNhap" };
            object[] value = new object[1] { MaPhieuNhap };
            ds = Models.Connection.FillDataSet("spgetPhieuNhapByMaPhieuNhap", CommandType.StoredProcedure, para, value);
            return ds;
        }
        public string GetMaNVByMaPhieuNhap()
        {
            string str = "";
            string[] para = new string[1] { "@MaPhieuNhap" };
            object[] value = new object[1] { MaPhieuNhap };
            str = Models.Connection.ExcuteScalar("spGetMaNVByMaPhieuNhap", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetMaNPPByMaPhieuNhap()
        {
            string str = "";
            string[] para = new string[1] { "@MaPhieuNhap" };
            object[] value = new object[1] { MaPhieuNhap };
            str = Models.Connection.ExcuteScalar("spGetMaNPPByMaPhieuNhap", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetTongTienByMaPhieuNhap()
        {
            string str = "";
            string[] para = new string[1] { "@MaPhieuNhap" };
            object[] value = new object[1] { MaPhieuNhap };
            str = Models.Connection.ExcuteScalar("spGetTongTienByMaPhieuNhap", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetNgayNhapByMaPhieuNhap()
        {
            string str = "";
            string[] para = new string[1] { "@MaPhieuNhap" };
            object[] value = new object[1] { MaPhieuNhap };
            str = Models.Connection.ExcuteScalar("spGetNgayNhapByMaPhieuNhap", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetTinhTrangByMaPhieuNhap()
        {
            string str = "";
            string[] para = new string[1] { "@MaPhieuNhap" };
            object[] value = new object[1] { MaPhieuNhap };
            str = Models.Connection.ExcuteScalar("spGetTinhTrangByMaPhieuNhap", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
    }
}
