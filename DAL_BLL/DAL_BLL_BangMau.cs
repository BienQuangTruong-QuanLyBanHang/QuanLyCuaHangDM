using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_BangMau
    {
        QLHHDataContext qlbh = new QLHHDataContext();
        public DAL_BLL_BangMau()
        {

        }
        public IQueryable<BangMau> GetBangMaus()
        {
            return qlbh.BangMaus.Select(t => t);
        }
        public int AddBangMaus(string maMau, string tenMau)
        {
            BangMau bangMau = qlbh.BangMaus.Where(t => t.MaMau == maMau).FirstOrDefault();
            if(bangMau == null)
            {
                BangMau bm = new BangMau();
                bm.MaMau = maMau;
                bm.TenMau = tenMau;
                qlbh.BangMaus.InsertOnSubmit(bm);
                qlbh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int UpdateBangMaus(string maMau, string tenMau)
        {
            BangMau bangmaus = qlbh.BangMaus.Where(t => t.MaMau == maMau).FirstOrDefault();
            if(bangmaus != null)
            {
                bangmaus.TenMau = tenMau;
                qlbh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeleteBangMaus(string maMau)
        {
            BangMau bangmaus = qlbh.BangMaus.Where(t => t.MaMau == maMau).FirstOrDefault();
            if(bangmaus != null)
            {
                qlbh.BangMaus.DeleteOnSubmit(bangmaus);
                qlbh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
