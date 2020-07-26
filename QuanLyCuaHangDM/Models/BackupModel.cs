using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDM.Models
{
    class BackupModel
    {
        protected string Path { get; set; }
        public BackupModel()
        {

        }
        public BackupModel(string _Path)
        {
            Path = _Path;
        }
        public int Backup()
        {
            int i = 0;
            string[] para = new string[1] { "@path" };
            object[] value = new object[1] { Path };
            i = Models.Connection.Excute_Sql("spBackup", System.Data.CommandType.StoredProcedure, para, value);
            return i;
        }
    }
}
