using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL_BLL
{
    public class DAL_BLL_User
    {
        QLHHDataContext qlhh = new QLHHDataContext();
        public DAL_BLL_User()
        {

        }
        public IQueryable GetUsers()
        {
            return (from us in qlhh.Users
                    join nv in qlhh.NhanViens on us.MaNhanVien equals nv.MaNhanVien
                    select new
                    {
                        us.ID,
                        us.TenDangNhap,
                        us.MatKhau,
                        us.MaNhanVien,
                        nv.TenNhanVien
                    });
        }
        public int AddUsers(string qId, string qMaNV, string qTenDN, string qMatKhau)
        {
            User users = qlhh.Users.Where(t => t.ID == qId).FirstOrDefault();
            if (users == null)
            {
                User us = new User();
                us.ID = qId;
                us.MaNhanVien = qMaNV;
                us.TenDangNhap = qTenDN;
                us.MatKhau = SHA256(qMatKhau);
                qlhh.Users.InsertOnSubmit(us);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DeleteUsers(string qId)
        {
            User users = qlhh.Users.Where(t => t.ID == qId).FirstOrDefault();
            if (users != null)
            {
                qlhh.Users.DeleteOnSubmit(users);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int UpdateUsers(string qId, string qMaNV, string qTenDN, string qMatKhau)
        {
            User users = qlhh.Users.Where(t => t.ID == qId).FirstOrDefault();
            if (users != null)
            {
                users.MaNhanVien = qMaNV;
                users.TenDangNhap = qTenDN;
                users.MatKhau = SHA256(qMatKhau);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int kiemTraKhoaChinh(string qTenDN, string qMatKhau)
        {
            User users = qlhh.Users.Where(t => t.TenDangNhap == qTenDN && t.MatKhau== SHA256(qMatKhau)).FirstOrDefault();
            if(users != null)
            {
                return 1;
            }
            return 0;
        }
        public string GetLastMaUsers()
        {
            User us = qlhh.Users.Where(t => t.ID == "U001").FirstOrDefault();
            if (us == null)
            {
                return "U001";
            }
            return qlhh.Users.OrderByDescending(t => t.ID).FirstOrDefault().ID;
        }
        public string SHA256(string qMatKhau)
        {
            try
            {
                SHA256Managed crypt = new SHA256Managed();
                string hash = string.Empty;
                byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(qMatKhau), 0, Encoding.UTF8.GetByteCount(qMatKhau));
                foreach (byte bit in crypto)
                {
                    hash += bit.ToString("x2");
                }
                return hash;
            }
            catch { return null; }
        }
        public int DoiMatKhau(string qTenDN, string qMatKhau)
        {
            User users = qlhh.Users.Where(t => t.TenDangNhap == qTenDN).FirstOrDefault();
            if (users != null)
            {
                users.MatKhau = SHA256(qMatKhau);
                qlhh.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string GetIdUsers(string qTenDN)
        {
            return qlhh.Users.Where(t => t.TenDangNhap == qTenDN).FirstOrDefault().MaNhanVien;
        }
        public int KiemTraTenDangNhap(string qTenDN)
        {
            User u = qlhh.Users.Where(t => t.TenDangNhap == qTenDN).FirstOrDefault();
            if(u == null)
            {
                return 1;
            }
            return 0;
        }
        public int KiemTraMaNV(string _qMaNV)
        {
            User u = qlhh.Users.Where(t => t.MaNhanVien == _qMaNV).FirstOrDefault();
            if (u == null)
            {
                return 1;
            }
            return 0;
        }
    }
}
