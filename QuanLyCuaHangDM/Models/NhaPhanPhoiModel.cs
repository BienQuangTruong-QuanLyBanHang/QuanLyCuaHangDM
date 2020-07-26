using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Models
{
    class NhaPhanPhoiModel
    {
        protected string MaNhaPhanPhoi { get; set; }
        protected string TenNhaPhanPhoi { get; set; }
        protected string DiaChi { get; set; }
        protected string SDT { get; set; }
        protected string Email { get; set; }
        protected string ChuThich { get; set; }

        public NhaPhanPhoiModel()
        {

        }
        public NhaPhanPhoiModel(string _MaNhaPhanPhoi)
        {
            MaNhaPhanPhoi = _MaNhaPhanPhoi;
        }
        public NhaPhanPhoiModel(string _MaNhaPhanPhoi, string _TenNhaPhanPhoi, string _DiaChi, string _SDT, string _Email, string _ChuThich)
        {
            MaNhaPhanPhoi = _MaNhaPhanPhoi;
            TenNhaPhanPhoi = _TenNhaPhanPhoi;
            DiaChi = _DiaChi;
            SDT = _SDT;
            Email = _Email;
            ChuThich = _ChuThich;
        }
        public int InsertNhaPhanPhoi()
        {
            int i = 0;
            string[] para = new string[5] { "@TenNhaPhanPhoi", "@DiaChi", "@SDT", "@Email", "@ChuThich" };
            object[] value = new object[5] { TenNhaPhanPhoi, DiaChi, SDT, Email, ChuThich };
            i = Models.Connection.Excute_Sql("spInsertNhaPhanPhoi", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdatetNhaPhanPhoi()
        {
            int i = 0;
            string[] para = new string[6] { "@MaNhaPhanPhoi", "@TenNhaPhanPhoi", "@DiaChi", "@SDT", "@Email", "@ChuThich" };
            object[] value = new object[6] { MaNhaPhanPhoi, TenNhaPhanPhoi, DiaChi, SDT, Email, ChuThich };
            i = Models.Connection.Excute_Sql("spUpdateNhaPhanPhoi", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteNhaPhanPhoi()
        {
            int i = 0;
            string[] para = new string[1] { "@MaNhaPhanPhoi" };
            object[] value = new object[1] { MaNhaPhanPhoi };
            i = Models.Connection.Excute_Sql("exec spDeleteNhaPhanPhoi " + MaNhaPhanPhoi);
            return i;
        }
        public static DataSet FillDataSetNhaPhanPhoi()
        {
            return Models.Connection.FillDataSet("spgetNhaPhanPhoi", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getNhaPhanPhoiByMaNhaPhanPhoi()
        {
            DataSet ds = new DataSet();
            string[] para = new string[1] { "@MaNhaPhanPhoi" };
            object[] value = new object[1] { MaNhaPhanPhoi };
            ds = Models.Connection.FillDataSet("spgetNhaPhanPhoiByMaNhaPhanPhoi", CommandType.StoredProcedure, para, value);
            return ds;
        }
    }
}
