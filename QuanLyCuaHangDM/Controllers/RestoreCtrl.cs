using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDM.Controllers
{
    class RestoreCtrl
    {
        public static int RestoreFullAndLog(string _FileName)
        {
            try
            {
                Models.RestoreModel _bk = new Models.RestoreModel(_FileName);
                return _bk.RestoreFullAndLog();
            }
            catch { return 0; }
        }
        public static int RestoreTail(string _FileName)
        {
            try
            {
                Models.RestoreModel _bk = new Models.RestoreModel(_FileName);
                return _bk.RestoreTail();
            }
            catch { return 0; }
        }
    }
}
