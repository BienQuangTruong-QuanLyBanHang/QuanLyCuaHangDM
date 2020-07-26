using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Models
{
    class ChucVuModel
    {
        protected string MaChucVu { get; set; }
        protected string TenChucVu { get; set; }
        protected string GhiChu { get; set; }
        public ChucVuModel()
        {

        }
        public ChucVuModel(string _MaChucVu)
        {
            MaChucVu = _MaChucVu;
        }
        public ChucVuModel(string _MaChucVu, string _TenChucVu, string _GhiChu)
        {
            MaChucVu = _MaChucVu;
            TenChucVu = _TenChucVu;
            GhiChu = _GhiChu;
        }
        public int InsertChucVu()
        {
            int i = 0;
            string[] para = new string[2] { "@TenChucVu", "@GhiChu" };
            object[] value = new object[2] { TenChucVu, GhiChu };
            i = Models.Connection.Excute_Sql("spInsertChucVu", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdateChucVu()
        {
            int i = 0;
            string[] para = new string[3] { "@MaChucVu", "@TenChuVu", "@GhiChu" };
            object[] value = new object[3] { MaChucVu, TenChucVu, GhiChu };
            i = Models.Connection.Excute_Sql("spUpdateChucVu", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteChucVu()
        {
            int i = 0;
            string[] para = new string[1] { "@MaChucVu" };
            object[] value = new object[1] { MaChucVu };
            i = Models.Connection.Excute_Sql("exec spDeleteChucVu " + MaChucVu);
            return i;
        }
        public static DataSet FillDataSetChucVu()
        {
            return Models.Connection.FillDataSet("spgetChucVu", CommandType.StoredProcedure);
        }
    }
}
