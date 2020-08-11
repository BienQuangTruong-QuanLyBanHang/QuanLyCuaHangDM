using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.IO;
using DAL_BLL;

namespace QuanLyCuaHangDM
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DAL_BLL_User bll_us = new DAL_BLL_User();
        DAL_BLL_PhanQuyenManHinh bll_pq = new DAL_BLL_PhanQuyenManHinh();
        DAL_BLL_NhanVien bll_nv = new DAL_BLL_NhanVien();
        public static string user;
        public static string IdLogin;
        public static string IdUser;
        public static int count = 0;
        public static int num = 0;
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            DisEndMenuLogin(true, IdLogin);
        }

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            theme.LookAndFeel.SkinName = "Office 2019 Colorful";
        }

        public void DisEndMenuLogin(bool e, string _idlogin)
        {
            btnLogin.Enabled = e;
            btnChangePass.Enabled = !e;
            btnLogout.Enabled = !e;
            btnGrant.Enabled = !e;
            btnRestore.Enabled = !e;
            btnBackup.Enabled = !e;
            btnBanHang.Enabled = !e;
            btnNhanVien.Enabled = !e;
            btnKhachHang.Enabled = !e;
            btnLoaiSP.Enabled = !e;
            btnSanPham.Enabled = !e;
            btnNCC.Enabled = !e;
            btnNhapHang.Enabled = !e;
            btnHangSX.Enabled = !e;
            btnInDSHoaDon.Enabled = !e;
            btnInDSPN.Enabled = !e;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            skin();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = XtraMessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin login = null;
            Check_Login:
            if (login == null || login.IsDisposed)
                login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.txtUser.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập vào username !");
                    goto Check_Login;
                }
                if (login.txtPass.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập vào password !");
                    goto Check_Login;
                }
                user = login.txtUser.Text;
                string pass = login.txtPass.Text;
                int rs = bll_us.kiemTraKhoaChinh(user, pass);
                if (rs == 0)
                {
                    XtraMessageBox.Show("Đăng nhập thất bại. Kiểm tra lại username hoặc password !");
                    goto Check_Login;
                }
                else
                {
                    List<string> lstBtn = new List<string>() { "btnBanHang", "BtnNhapHang"}
                    List<PhanQuyenManHinh> lst = new List<PhanQuyenManHinh>();
                    lst = bll_pq.GetPhanQuyenManHinhs(bll_nv.GetChucVuBy(bll_us.GetIdUsers(IdUser)));
                    for(int i = 0;i<lst.Count;i++)
                    {
                        //if(btnBanHang.Tag)
                    }
                    DisEndMenuLogin(false, IdLogin);
                    IdUser = login.txtUser.Text;
                }
                //else
                //{
                //    string cv = Controllers.LoginCtrl.GetChucVu(user, pass);
                //    if (cv == "CV001")
                //        DisEndMenuLogin(false, IdLogin);
                //    else if (cv == "CV003")
                //    {
                //        btnNhapHang.Enabled = true;
                //        btnSanPham.Enabled = true;
                //        btnNCC.Enabled = true;
                //        btnHangSX.Enabled = true;
                //        btnLogin.Enabled = false;
                //        btnDki.Enabled = false;
                //        btnLogout.Enabled = true;
                //        btnChangePass.Enabled = true;
                //        btnInDSPN.Enabled = true;
                //        btnInDSHoaDon.Enabled = true;
                //    }
                //    else if (cv == "CV002")
                //    {
                //        btnBanHang.Enabled = true;
                //        btnLogin.Enabled = false;
                //        btnDki.Enabled = false;
                //        btnLogout.Enabled = true;
                //        btnChangePass.Enabled = true;
                //    }
                //    else if (cv == "CV007")
                //    {
                //        btnNhanVien.Enabled = true;
                //        btnKhachHang.Enabled = true;
                //        btnLogin.Enabled = false;
                //        btnDki.Enabled = false;
                //        btnLogout.Enabled = true;
                //        btnChangePass.Enabled = true;
                //    }
                //    IdUser = Controllers.LoginCtrl.GetIdUser(user, pass);
                if (login.chkBoxRemember.Checked)
                {
                    Properties.Settings.Default.userName = login.txtUser.Text;
                    Properties.Settings.Default.pass = login.txtPass.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.userName = "";
                    Properties.Settings.Default.pass = "";
                    Properties.Settings.Default.Save();
                }
                //    XtraMessageBox.Show("User: " + user + " đăng nhập thành công !");
                //}
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisEndMenuLogin(true, IdLogin);
                btnLogin_ItemClick(sender, e);
            }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapHang np = new frmNhapHang(bll_us.GetIdUsers(IdUser));
            np.MdiParent = this;
            np.Show();
        }

        private void btnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBanHang banhang = new frmBanHang(bll_us.GetIdUsers(IdUser));
            banhang.MdiParent = this;
            banhang.Show();
        }

        private void btnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            sp.MdiParent = this;
            sp.Show();
        }

        private void btnDki_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnLoaiSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoaiSP loaisp = new frmLoaiSP();
            loaisp.MdiParent = this;
            loaisp.Show();
        }

        private void btnHangSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHangSX hangsx = new frmHangSX();
            hangsx.MdiParent = this;
            hangsx.Show();
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau changepass = null;
            Check_changepass:
            if (changepass == null || changepass.IsDisposed)
                changepass = new frmDoiMatKhau();
            if (changepass.ShowDialog() == DialogResult.OK)
            {
                if (changepass.txtUser.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập vào tên tài khoản !");
                    goto Check_changepass;
                }
                if (changepass.txtMatKhauCu.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập vào mật khẩu cũ !");
                    goto Check_changepass;
                }
                if (changepass.txtMatKhauMoi.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập vào mật khẩu mới !");
                    goto Check_changepass;
                }
                if (changepass.txtMatKhauNhapLai.Text == "")
                {
                    XtraMessageBox.Show("Hãy xác nhận mật khẩu !");
                    goto Check_changepass;
                }
                if (changepass.txtMatKhauNhapLai.Text != changepass.txtMatKhauMoi.Text)
                {
                    XtraMessageBox.Show("Mật khẩu nhập lại không chính xác !");
                    goto Check_changepass;
                }
                user = changepass.txtUser.Text;
                string mkcu = changepass.txtMatKhauCu.Text;
                string mkmoi = changepass.txtMatKhauMoi.Text;
                int rs1 = bll_us.kiemTraKhoaChinh(user, mkcu);
                
                if (rs1 == 0)
                {
                    XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu sai !");
                    goto Check_changepass;
                }
                else
                {
                    int rs2 = bll_us.DoiMatKhau(user, mkmoi);
                    if (rs2 > 0)
                    {
                        XtraMessageBox.Show("Đổi mật khẩu thành công !");
                        DisEndMenuLogin(true, IdLogin);
                        btnLogin_ItemClick(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Đổi mật khẩu thất bại !");
                }
            }
        }

        private void btnNCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhaPhanPhoi nhapp = new frmNhaPhanPhoi();
            nhapp.MdiParent = this;
            nhapp.Show();
        }

        private void btnNhanVien_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void btnGrant_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUser us = new frmUser();
            us.MdiParent = this;
            us.Show();
        }

        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraOpenFileDialog folderBrowser = new XtraOpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                //XtraMessageBox.Show(folderPath);
                XtraMessageBox.Show("Backup thành công !");
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        if (xtraOpenFileDialog1.CheckFileExists)
            //        {
            //            //string extension = System.IO.Path.GetExtension(xtraOpenFileDialog1.FileName);

            //            //if (extension == ".BAK")
            //            //{
            //                System.IO.FileInfo fInfo = new System.IO.FileInfo(xtraOpenFileDialog1.FileName);
            //                string strFileName = fInfo.Name;
            //                string strFilePath = fInfo.DirectoryName;
            //                string fileName = strFilePath + "\\" + strFileName;
            //                string[] str1 = fileName.Split('_');
            //                if (count == 0)
            //                {
            //                    XtraMessageBox.Show("Hướng dẫn Restore: Hãy chọn lần lượt các file ..Full.BAK, ..Diff.BAK, ..Log.TRN, ..Tail.TRN");
            //                    if (str1[1] == "Full.BAK")
            //                    {
            //                        count++;
            //                        //XtraMessageBox.Show(fileName);
            //                        fileFull = fileName;
            //                    }
            //                    else
            //                        XtraMessageBox.Show("Hãy chọn file ..Full.BAK !");
            //                }
            //                else if(count == 1)
            //                {
            //                    if (str1[1] == "Diff.BAK")
            //                    {
            //                        count++;
            //                        fileDiff = fileName;
            //                    }
            //                    else
            //                        XtraMessageBox.Show("Hãy chọn file ...Diff.BAK !");
            //                }
            //                else if (count == 2)
            //                {
            //                    if (str1[1] == "Log.TRN")
            //                    {
            //                        count++;
            //                        fileLog = fileName;
            //                    }
            //                    else
            //                        XtraMessageBox.Show("Hãy chọn file ..Log.TRN !");
            //                }
            //                else if (count == 3)
            //                {
            //                    if (str1[1] == "Tail.TRN")
            //                    {
            //                        count++;
            //                        fileTail = fileName;
            //                    try
            //                    {
            //                        Controllers.RestoreCtrl.RestoreFullAndLog(fileFull);
            //                        Controllers.RestoreCtrl.RestoreFullAndLog(fileDiff);
            //                        Controllers.RestoreCtrl.RestoreFullAndLog(fileLog);
            //                        Controllers.RestoreCtrl.RestoreTail(fileTail);
            //                        XtraMessageBox.Show("Restore hoàn tất !");
            //                    }
            //                    catch { XtraMessageBox.Show("Restore thất bại"); }
            //                    }
            //                    else
            //                        XtraMessageBox.Show("Hãy chọn file ..Tail.TRN !");
            //                }
            //            //}
            //            //else
            //            //{
            //                //XtraMessageBox.Show("Chỉ cho phép file .BAK !");
            //            //}
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
            //        $"Details:\n\n{ex.StackTrace}");
            //    }
            //}
            //XtraMessageBox.Show("Liên hệ Admin để Restore !");
        }

        private void btnInDSPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhSachPhieuNhap d = new frmDanhSachPhieuNhap();
            d.MdiParent = this;
            d.Show();
        }

        private void btnInDSHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhSachHoaDon d = new frmDanhSachHoaDon();
            d.MdiParent = this;
            d.Show();
        }
    }
}
