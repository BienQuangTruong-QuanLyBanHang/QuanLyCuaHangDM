using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_HangSanXuat
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_HangSanXuat()
        {

        }
        public IQueryable<HangSanXuat> GetHangSanXuats()
        {
            return qlhh.HangSanXuats.Select(t => t);
        }
        public int addHangSanXuat(string maSX, string tenNSX)
        {
            HangSanXuat hsx = qlhh.HangSanXuats.Where(t => t.MaHangSanXuat == maSX).FirstOrDefault();
            if(hsx == null)
            {
                HangSanXuat hsx1 = new HangSanXuat();
                hsx1.MaHangSanXuat = maSX;
                hsx1.TenHangSanXuat = tenNSX;
                qlhh.HangSanXuats.InsertOnSubmit(hsx1);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int updateHangSanXuat(string maSX, string tenNSX)
        {
            HangSanXuat hsx = qlhh.HangSanXuats.Where(t => t.MaHangSanXuat == maSX).FirstOrDefault();
            if (hsx != null)
            {
                hsx.TenHangSanXuat = tenNSX;
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int deleteHangSanXuat(string maSX, string tenNSX)
        {
            HangSanXuat hsx = qlhh.HangSanXuats.Where(t => t.MaHangSanXuat == maSX).FirstOrDefault();
            if(hsx != null)
            {
                qlhh.HangSanXuats.DeleteOnSubmit(hsx);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int kiemTraKhoaNgoai(string maSX)
        {
            SanPham sanphams = qlhh.SanPhams.Where(t => t.HangSanXuat == maSX).FirstOrDefault();
            if (sanphams == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
