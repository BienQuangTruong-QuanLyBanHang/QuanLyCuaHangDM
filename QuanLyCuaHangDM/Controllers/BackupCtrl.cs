using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDM.Controllers
{
    class BackupCtrl
    {
        public static int Backup(string _path)
        {
            try
            {
                Models.BackupModel _bk = new Models.BackupModel(_path);
                return _bk.Backup();
            }
            catch { return 0; }
        }
    }
}
