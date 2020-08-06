using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public partial class HoaDon
    {
        string _TenNV;
        string _TenKH;
        string _MaKH;
        string _DiaChi;
        string _TenSP;
        string _DVT;
        int _GiaBan;
        int _SoLuong;
        int _ThanhTien;

        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public string DVT { get => _DVT; set => _DVT = value; }
        public int GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int ThanhTienCTHD { get => _ThanhTien; set => _ThanhTien = value; }
    }
}
