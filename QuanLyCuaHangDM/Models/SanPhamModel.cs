using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCuaHangDM.Models
{
    class SanPhamModel
    {
        protected string MaSanPham { get; set; }
        protected string TenSanPham { get; set; }
        protected string LoaiSanPham { get; set; }
        protected string HangSanXuat { get; set; }
        protected int GiaNhap { get; set; }
        protected int GiaBan { get; set; }
        protected int TonKho { get; set; }
        protected string TrangThai { get; set; }
        protected string HinhSanPham { get; set; }
        protected string ChuThich { get; set; }

        public SanPhamModel()
        {

        }
        public SanPhamModel(string _MaSanPham)
        {
            MaSanPham = _MaSanPham;
        }
        public SanPhamModel(string _MaSanPham, string _TenSanPham, string _LoaiSanPham, string _HangSanXuat, int _GiaNhap, int _GiaBan, int _TonKho, string _TrangThai, string _HinhSanPham, string _ChuThich)
        {
            MaSanPham = _MaSanPham;
            TenSanPham = _TenSanPham;
            LoaiSanPham = _LoaiSanPham;
            HangSanXuat = _HangSanXuat;
            GiaNhap = _GiaNhap;
            GiaBan = _GiaBan;
            TonKho = _TonKho;
            TrangThai = _TrangThai;
            HinhSanPham = _HinhSanPham;
            ChuThich = _ChuThich;
        }
        public int InsertSanPham()
        {
            int i = 0;
            string[] para = new string[9] { "@TenSanPham", "@LoaiSanPham", "@HangSanXuat", "@GiaNhap", "@GiaBan", "@TonKho", "@TrangThai", "@Image", "@ChuThich" };
            object[] value = new object[9] { TenSanPham, LoaiSanPham, HangSanXuat, GiaNhap, GiaBan, TonKho, TrangThai, HinhSanPham, ChuThich };
            i = Models.Connection.Excute_Sql("spInsertSanPham", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdateSanPham()
        {
            int i = 0;
            string[] para = new string[10] { "@MaSanPham", "@TenSanPham", "@LoaiSanPham", "@HangSanXuat", "@GiaNhap", "@GiaBan", "@TonKho", "@TrangThai", "@Image", "@ChuThich" };
            object[] value = new object[10] { MaSanPham, TenSanPham, LoaiSanPham, HangSanXuat, GiaNhap, GiaBan, TonKho, TrangThai, HinhSanPham, ChuThich };
            i = Models.Connection.Excute_Sql("spUpdateSanPham", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteSanPham()
        {
            int i = 0;
            string[] para = new string[1] { "@MaSanPham" };
            object[] value = new object[1] { MaSanPham };
            i = Models.Connection.Excute_Sql("exec spDeleteSanPham " + MaSanPham);
            return i;
        }
        public static DataSet FillDataSetSanPham()
        {
            return Models.Connection.FillDataSet("spgetSanPham", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getSanPhamByMaSanPham()
        {
            DataSet ds = new DataSet();
            string[] para = new string[1] { "@MaSanPham" };
            object[] value = new object[1] { MaSanPham };
            ds = Models.Connection.FillDataSet("spgetSanPhamByMaSanPham", CommandType.StoredProcedure, para, value);
            return ds;
        }
        public string GetGiaNhapByMaSanPham()
        {
            string str = "";
            string[] para = new string[1] { "@MaSanPham" };
            object[] value = new object[1] { MaSanPham };
            str = Models.Connection.ExcuteScalar("spGetGiaNhapByMaSanPham", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public string GetGiaBanByMaSanPham()
        {
            string str = "";
            string[] para = new string[1] { "@MaSanPham" };
            object[] value = new object[1] { MaSanPham };
            str = Models.Connection.ExcuteScalar("spGetGiaBanByMaSanPham", System.Data.CommandType.StoredProcedure, para, value);
            return str;
        }
        public int GetTonKho()
        {
            int i = 0;
            string[] para = new string[1] { "@MaSanPham"};
            object[] value = new object[1] { MaSanPham};
            i = Convert.ToInt32(Models.Connection.ExcuteScalar("spGetTonKho", System.Data.CommandType.StoredProcedure, para, value));
            return i;
        }
    }
}
