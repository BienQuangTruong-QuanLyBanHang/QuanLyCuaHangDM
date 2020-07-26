using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DAL_BLL_ManHinh
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_ManHinh()
        {

        }
        public IQueryable<ManHinh> GetManHinhs()
        {
            return qlhh.ManHinhs.Select(t => t);
        }
        public int AddManHinhs(string qMaMH, string qTenMH)
        {
            ManHinh manHinhs = qlhh.ManHinhs.Where(t => t.MaMH == qMaMH).FirstOrDefault();
            if (manHinhs == null)
            {
                ManHinh mh = new ManHinh();
                mh.MaMH = qMaMH;
                mh.TenMH = qTenMH;
                qlhh.ManHinhs.InsertOnSubmit(mh);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeleteManHinhs(string qMaMH)
        {
            ManHinh manHinhs = qlhh.ManHinhs.Where(t => t.MaMH == qMaMH).FirstOrDefault();
            if (manHinhs != null)
            {
                qlhh.ManHinhs.DeleteOnSubmit(manHinhs);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int UpdateManHinhs(string qMaMH, string qTenMH)
        {
            ManHinh manHinhs = qlhh.ManHinhs.Where(t => t.MaMH == qMaMH).FirstOrDefault();
            if (manHinhs != null)
            {
                manHinhs.TenMH = qTenMH;
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
