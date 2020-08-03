using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public partial class ChiTietPhieuNhap
    {
        string _TenSanPham = "";

        public string TenSanPham { get => _TenSanPham; set => _TenSanPham = value; }
    }
}
