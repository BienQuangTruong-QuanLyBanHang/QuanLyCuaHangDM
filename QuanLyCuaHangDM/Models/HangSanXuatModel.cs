using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangDM.Models
{
    class HangSanXuatModel
    {
        protected string MaHangSanXuat { get; set; }
        protected string TenHangSanXuat { get; set; }
        public HangSanXuatModel()
        {

        }
        public HangSanXuatModel(string _MaHangSanXuat)
        {
            MaHangSanXuat = _MaHangSanXuat;
        }
        public HangSanXuatModel(string _MaHangSanXuat, string _TenHangSanXuat)
        {
            MaHangSanXuat = _MaHangSanXuat;
            TenHangSanXuat = _TenHangSanXuat;
        }
        public int InsertHangSanXuat()
        {
            int i = 0;
            string[] para = new string[1] {  "@TenHangSanXuat" };
            object[] value = new object[1] { TenHangSanXuat };
            i = Models.Connection.Excute_Sql("spInsertHangSX", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int UpdatetHangSanXuat()
        {
            int i = 0;
            string[] para = new string[2] { "@MaHangSanXuat", "@TenHangSanXuat" };
            object[] value = new object[2] { MaHangSanXuat, TenHangSanXuat };
            i = Models.Connection.Excute_Sql("spUpdateHangSX", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int DeleteHangSanXuat()
        {
            int i = 0;
            string[] para = new string[1] { "@MaHangSanXuat" };
            object[] value = new object[1] { MaHangSanXuat };
            i = Models.Connection.Excute_Sql("exec spDeleteHangSX " + MaHangSanXuat);
            return i;
        }
        public static DataSet FillDataSetHangSanXuat()
        {
            return Models.Connection.FillDataSet("spgetHangSX", CommandType.StoredProcedure);
        }
    }
}
