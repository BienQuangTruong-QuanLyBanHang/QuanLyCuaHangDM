using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDM.Models
{
    class RestoreModel
    {
        protected string FileName { get; set; }
        public RestoreModel()
        {

        }
        public RestoreModel(string _FileName)
        { 
            FileName = _FileName;
        }
        public int RestoreFullAndLog()
        {
            int i = 0;
            string[] para = new string[1] { "@fileName" };
            object[] value = new object[1] { FileName };
            i = Models.Connection.Excute_Sql("spRestoreFullAndLog", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
        public int RestoreTail()
        {
            int i = 0;
            string[] para = new string[1] { "@fileName" };
            object[] value = new object[1] { FileName };
            i = Models.Connection.Excute_Sql("spRestoreTail", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
    }
}
