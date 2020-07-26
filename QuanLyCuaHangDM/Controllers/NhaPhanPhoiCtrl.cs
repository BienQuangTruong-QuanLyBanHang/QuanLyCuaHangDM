using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangDM.Controllers
{
    class NhaPhanPhoiCtrl
    {
        public static DataSet FillDataSet_getNhaPhanPhoiByMaNhaPhanPhoi(string _MaNhaPhanPhoi)
        {
            try
            {
                Models.NhaPhanPhoiModel npp = new Models.NhaPhanPhoiModel(_MaNhaPhanPhoi);
                return npp.FillDataSet_getNhaPhanPhoiByMaNhaPhanPhoi();
            }
            catch { return null; }
        }
        public static int InsertNhaPhanPhoi(string _MaNhaPhanPhoi, string _TenNhaPhanPhoi, string _DiaChi, string _SDT, string _Email, string _ChuThich)
        {
            try
            {
                Models.NhaPhanPhoiModel _npp = new Models.NhaPhanPhoiModel(_MaNhaPhanPhoi, _TenNhaPhanPhoi, _DiaChi, _SDT, _Email, _ChuThich);
                return _npp.InsertNhaPhanPhoi();
            }
            catch { return 0; }
        }
        public static int UpdateNhaPhanPhoi(string _MaNhaPhanPhoi, string _TenNhaPhanPhoi, string _DiaChi, string _SDT, string _Email, string _ChuThich)
        {
            try
            {
                Models.NhaPhanPhoiModel _npp = new Models.NhaPhanPhoiModel(_MaNhaPhanPhoi, _TenNhaPhanPhoi, _DiaChi, _SDT, _Email, _ChuThich);
                return _npp.UpdatetNhaPhanPhoi();
            }
            catch { return 0; }
        }
        public static int DeleteNhaPhanPhoi(string _MaNhaPhanPhoi)
        {
            try
            {
                Models.NhaPhanPhoiModel _npp = new Models.NhaPhanPhoiModel(_MaNhaPhanPhoi);
                return _npp.DeleteNhaPhanPhoi();
            }
            catch { return 0; }
        }
    }
}
