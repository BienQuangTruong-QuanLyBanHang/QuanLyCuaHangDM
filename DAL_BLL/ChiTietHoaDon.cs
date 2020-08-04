using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public partial class ChiTietHoaDon
    {
        string _TenSanPham = "";
        int _DonGia = 0;
        public string TenSanPham { get => _TenSanPham; set => _TenSanPham = value; }
        public int DonGia { get => _DonGia; set => _DonGia = value; }
    }
}
