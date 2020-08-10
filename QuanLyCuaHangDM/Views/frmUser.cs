using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL_BLL;

namespace QuanLyCuaHangDM
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        DAL_BLL_User bll_user = new DAL_BLL_User();
        DAL_BLL_NhanVien bll_nv = new DAL_BLL_NhanVien();
        public frmUser()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        int flag = 0;
        public static frmUser us = new frmUser();
        public void HienThiDSUser()
        {
            gridCtrlUser.DataSource = bll_user.GetUsers();
        }
        void disEnd(bool e)
        {
            txtMatKhau.Enabled = e;
            txtTenDN.Enabled = e;
            cboMaNV.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
        }
        void loadControl_cboMaNV()
        {
            cboMaNV.DataSource = bll_nv.GetNhanViens();
            cboMaNV.DisplayMember = "MaNhanVien";
            cboMaNV.ValueMember = "MaNhanVien";
            cboMaNV.SelectedIndex = 0;
        }
        void clearData()
        {
            txtID.Text = "";
            txtMatKhau.Text = "";
            txtTenDN.Text = "";
        }
        void reActive()
        {
            HienThiDSUser();
            disEnd(false);
            gv_User.RowClick += gv_User_RowClick;
        }
        bool kiemTraTextLength(string _Str)
        {
            if (_Str.Length < 5 || _Str.Length > 50)
                return false;
            return true;
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            HienThiDSUser();
            disEnd(false);
            loadControl_cboMaNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            disEnd(true);
            loadControl_cboMaNV();
            clearData();

            gv_User.RowClick -= gv_User_RowClick;
            string str = bll_user.GetLastMaUsers();
            int str2 = Convert.ToInt32(str.Remove(0, 1));
            if (str2 + 1 < 10)
            {
                txtID.Text = "U00" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 100)
            {
                txtID.Text = "U0" + (str2 + 1).ToString();
            }
            else if (str2 + 1 < 1000)
            {
                txtID.Text = "U" + (str2 + 1).ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _ID = "";
            string _MaNhanVien = "";
            string _TenDangNhap = "";
            string _MatKhau = "";
            try
            {
                _ID = (txtID.Text);
            }
            catch { }
            try
            {
                _MatKhau = txtMatKhau.Text;
            }
            catch { }
            try
            {
                _MaNhanVien = cboMaNV.Text;
            }
            catch { }
            try
            {
                _TenDangNhap = txtTenDN.Text;
            }
            catch { }
            if (_MatKhau == "" || _TenDangNhap == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if(!kiemTraTextLength(_TenDangNhap))
            {
                XtraMessageBox.Show("Tên đăng nhập giới hạn 5 ~ 50 kí tự");
                return;
            }
            if (!kiemTraTextLength(_MatKhau))
            {
                XtraMessageBox.Show("Mật khẩu giới hạn 5 ~ 50 kí tự");
                return;
            }
            if (flag == 0)
            {
                int rs2 = bll_user.KiemTraMaNV(_MaNhanVien);
                if (rs2 > 0)
                {
                    int rs = bll_user.KiemTraTenDangNhap(_TenDangNhap);
                    if (rs > 0)
                    {
                        int i = bll_user.AddUsers(_ID, _MaNhanVien, _TenDangNhap, _MatKhau);
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm mới thành công", "Thông báo");
                            reActive();
                        }
                        else
                            MessageBox.Show("Thêm mới thất bại", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập này đã tồn tại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên này đã có tài khoản", "Thông báo");
                }
            }
            else
            {
                if (_ID != string.Empty)
                {
                    int i = bll_user.UpdateUsers(_ID, _MaNhanVien, _TenDangNhap, _MatKhau);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Sửa thành công");
                        reActive();
                    }
                    else
                        XtraMessageBox.Show("Sửa thất bại");
                }
                else
                {
                    XtraMessageBox.Show("Hãy chọn tài khoản cần sửa");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disEnd(true);
            gv_User.RowClick -= gv_User_RowClick;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _ID = "";
            try
            {
                _ID = (txtID.Text);
            }
            catch { }
            if (_ID != string.Empty)
            {
                DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = bll_user.DeleteUsers(_ID);
                    if (i > 0)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        HienThiDSUser();
                        frmUser_Load(sender, e);
                    }
                    else
                        XtraMessageBox.Show("Xóa thất bại !");
                }
                else
                    return;
            }
            else
            {
                XtraMessageBox.Show("Hãy chọn tài khoản cần xóa");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmUser_Load(sender, e);
            reActive();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!gridCtrlUser.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }
            gridCtrlUser.ShowPrintPreview();
        }

        private void gv_User_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                txtID.Text = gv_User.GetRowCellValue(e.RowHandle, gc_ID).ToString();
                txtTenDN.Text = gv_User.GetRowCellValue(e.RowHandle, gc_TenDN).ToString();
                txtMatKhau.Text = gv_User.GetRowCellValue(e.RowHandle, gc_MK).ToString();
                cboMaNV.SelectedValue = gv_User.GetRowCellValue(e.RowHandle, gc_MaNV).ToString();
            }
            catch { }
        }

        private void txtTenDN_Leave(object sender, EventArgs e)
        {

        }

        private void txtTenDN_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                XtraMessageBox.Show("Cut/Copy and Paste Options are disabled");
            }
        }

        private void txtTenDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                XtraMessageBox.Show("Cut/Copy and Paste Options are disabled");
            }
        }
    }
}